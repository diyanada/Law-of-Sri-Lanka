using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace Acts_of_Sri_Lanka
{
    public partial class Amendments : Form
    {

        private SystemString _SystemString;
        private DataSet _DataSet;

        public Amendments(int _ACTID, String _Text)
        {
            InitializeComponent();

            this.Text = "Amendments of " + _Text;

            this._SystemString = new SystemString();

            this._DataSet = new DataSet();

            //

            XmlReader _File;
            _File = XmlReader.Create(this._SystemString.FileLocation + "AMENDMENTS/" + _ACTID.ToString(), new XmlReaderSettings());
            _DataSet.ReadXml(_File);

            this._DataGrid.DataSource = _DataSet.Tables[0];

            this._DataGrid.Columns["FILE"].Visible = false;
            this._DataGrid.Columns["ID"].Visible = false;
            this._DataGrid.Columns["ACTID"].Visible = false;

            DataGridViewButtonColumn _ViewButton = new DataGridViewButtonColumn();
            _ViewButton.HeaderText = "View PDF";
            _ViewButton.Text = "View";
            _ViewButton.Name = "ViewButton";
            _ViewButton.UseColumnTextForButtonValue = true;

            this._DataGrid.Columns.Add(_ViewButton);

            this._DataGrid.Columns["ViewButton"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this._DataGrid.Columns["ViewButton"].Width = 60;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow _Row = this._DataGrid.Rows[e.RowIndex];

                    String _File = _Row.Cells["FILE"].Value.ToString();

                    String _EndFile = Path.GetTempPath() + "ACTLANKA/AMENDMENTS/";

                    Directory.CreateDirectory(_EndFile);

                    String _EndFileName = this.Text + ".pdf";

                    foreach (char _Char in System.IO.Path.GetInvalidFileNameChars())
                    {
                        _EndFileName = _EndFileName.Replace(_Char.ToString(), string.Empty);
                    }

                    _EndFile += _EndFileName;

                    String _StartFile = this._SystemString.FileLocation + "FILES/AMENDMENTS/" + _File;

                    File.Copy(_StartFile, _EndFile, true);

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
        }
    }
}
