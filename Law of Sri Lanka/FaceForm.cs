using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.IO;

namespace Acts_of_Sri_Lanka
{
    public partial class FaceForm : Form
    {
        private SystemString _SystemString;
        private DataSet _DataSet;
        private DataView _DataView;

        public FaceForm()
        {            
            try
            {
                Face _Face = new Face();
                _Face.Show();

                InitializeComponent();

                this._SystemString = new SystemString();
                this._DataSet = new DataSet();

                XmlReader _File;
                _File = XmlReader.Create(this._SystemString.FileLocation + "ACTS", new XmlReaderSettings());
                this._DataSet.ReadXml(_File);

                this._DataView = new DataView(this._DataSet.Tables[0]);

                this._DataGrid.DataSource = this._DataSet.Tables[0];
                this._DataGrid.Columns["ID"].Visible = false;
                this._DataGrid.Columns["FILE"].Visible = false;

                this._DataGrid.Sort(this._DataGrid.Columns["NAME"], ListSortDirection.Ascending);

                this._DataGrid.Columns["YEAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this._DataGrid.Columns["YEAR"].Width = 70;

                this._DataGrid.Columns["NUMBER"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this._DataGrid.Columns["NUMBER"].Width = 70;

                this._DataGrid.Columns["CATEGORY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this._DataGrid.Columns["CATEGORY"].Width = 80;

                this._DataGrid.Columns["NUMBER"].HeaderText = "NUMBER OR VOLUME";
                this._DataGrid.Columns["YEAR"].HeaderText = "YEAR OR CHAPTER";

                DataGridViewButtonColumn _ViewButton = new DataGridViewButtonColumn();
                _ViewButton.HeaderText = "View PDF";
                _ViewButton.Text = "View";
                _ViewButton.Name = "ViewButton";
                _ViewButton.UseColumnTextForButtonValue = true;

                this._DataGrid.Columns.Add(_ViewButton);

                this._DataGrid.Columns["ViewButton"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this._DataGrid.Columns["ViewButton"].Width = 50;

                DataGridViewButtonColumn _AmendButton = new DataGridViewButtonColumn();
                _AmendButton.HeaderText = "View";
                _AmendButton.Text = "Amendments";
                _AmendButton.Name = "AmendmentButton";
                _AmendButton.UseColumnTextForButtonValue = true;

                this._DataGrid.Columns.Add(_AmendButton);

                this._DataGrid.Columns["AmendmentButton"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this._DataGrid.Columns["AmendmentButton"].Width = 75;

                //-------------------------------------------------------------------------------------

                _Name.AutoCompleteMode = AutoCompleteMode.Suggest;
                _Name.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection _Acsc = new AutoCompleteStringCollection();

                XmlDocument _Doc = new XmlDocument();
                _Doc.Load(this._SystemString.FileLocation + "ACTS");

                XmlNodeList _ElemList = _Doc.GetElementsByTagName("ACT");

                foreach (XmlNode _Node in _ElemList)
                {
                    _Acsc.Add(_Node.Attributes["NAME"].Value);
                }
      

                _Name.AutoCompleteCustomSource = _Acsc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridUpdate()
        {
            this._DataGrid.DataSource = _DataSet.Tables[0];
        }

        private void publicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Loader _Loader = new Loader("Publications", "Publications");
                _Loader.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prefaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Loader _Loader = new Loader("Preface", "Preface");
                _Loader.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {   
                try
                {
                    DataGridViewRow _Row = this._DataGrid.Rows[e.RowIndex];

                    String _File = _Row.Cells["FILE"].Value.ToString();                    

                    String _EndFile = Path.GetTempPath() + "ACTLANKA/";

                    Directory.CreateDirectory(_EndFile);

                    String _EndFileName = _Row.Cells["NAME"].Value.ToString() + ".pdf";

                    foreach (char _Char in System.IO.Path.GetInvalidFileNameChars())
                    {
                        _EndFileName = _EndFileName.Replace(_Char.ToString(), string.Empty);
                    }

                    _EndFile += _EndFileName;

                    String _StartFile = this._SystemString.FileLocation + "FILES/" + _File;

                    File.Copy(_StartFile, _EndFile , true);

                    Process.Start(_EndFile);
                }
                catch (Win32Exception)
                {
                    if (MessageBox.Show("Install adobe reader to read pdf files. Do you need install?", "Adobe reader not installed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("AdobeXI.exe");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not load file.");
                }
                
            }
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                try
                {
                    int _Row = e.RowIndex;

                    String _ActID = this._DataGrid.Rows[_Row].Cells["ID"].Value.ToString();

                    String _ActName = this._DataGrid.Rows[_Row].Cells["NAME"].Value.ToString();

                    Amendments _Amendments = new Amendments(int.Parse(_ActID), _ActName);
                    _Amendments.Show();

                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("No amendments for this!.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {           

            this.DataGridUpdate();

            this._Name.Text = "";
            this._Year.Text = "";
            this._Number.Text = "";
        }

        private static Dictionary<char, int> _romanMap = new Dictionary<char, int> 
        { 
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };

        private static int ConvertRomanToNumber(string text)
        {
            int totalValue = 0, prevValue = 0;
            foreach (var c in text)
            {
                if (!_romanMap.ContainsKey(c))
                    return 0;
                var crtValue = _romanMap[c];
                totalValue += crtValue;
                if (prevValue != 0 && prevValue < crtValue)
                {
                    if (prevValue == 1 && (crtValue == 5 || crtValue == 10)
                        || prevValue == 10 && (crtValue == 50 || crtValue == 100)
                        || prevValue == 100 && (crtValue == 500 || crtValue == 1000))
                        totalValue -= 2 * prevValue;
                    else
                        return 0;
                }
                prevValue = crtValue;
            }
            return totalValue;
        }

        private void TextSerch(object _Sender, EventArgs e)
        {            
            String _Name = this._Name.Text.Replace("'", "''");
            int _Year;
            int _Number;

            if (int.TryParse(this._Year.Text, out _Year))
            {
                this._YearError.Visible = false;
            }
            else
            {
                if (this._Year.Text != string.Empty)
                {
                    this._YearError.Visible = true;
                }
            }            

            int _NumberTemp = ConvertRomanToNumber(this._Number.Text);


            if (int.TryParse(this._Number.Text, out _Number))
            {
                this._NumberError.Visible = false;
            }
            else if (_NumberTemp != 0)
            {
                this._NumberError.Visible = false;

                _Number = _NumberTemp;
            }
            else
            {
                if (this._Number.Text != string.Empty)
                {
                    this._NumberError.Visible = true;
                }
            }

            if (_Number == 0 && _Year == 0)
            {
                this._DataView.RowFilter = string.Format("NAME LIKE '%{0}%'", _Name);
            }
            else if (_Number == 0)
            {
                this._DataView.RowFilter = string.Format("NAME LIKE '%{0}%' AND YEAR LIKE '%{1}%'", _Name, _Year);
            }
            else if (_Year == 0)
            {
                this._DataView.RowFilter = string.Format("NAME LIKE '%{0}%' AND NUMBER LIKE '%{1}%'", _Name, _Number);
            }
            else
            {
                this._DataView.RowFilter = string.Format("NAME LIKE '%{0}%' AND YEAR LIKE '%{1}%' AND NUMBER LIKE '%{2}%'", _Name, _Year, _Number);
            }

            this._DataGrid.DataSource = this._DataView;
        }

        private void _PictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("http://dynamete.com");
        }

    }
}
