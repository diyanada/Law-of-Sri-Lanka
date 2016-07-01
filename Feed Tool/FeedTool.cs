using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ActLankaTool
{
    public partial class FeedTool : Form
    {
        private String _FileName = null;
        private SystemString _SystemString;
        private SqlConnection _Connection;
        private SqlDataAdapter _DataAdapter, _DataAdapterE, _DataAdapterA, _DataAdapterActs;
        private DataSet _DataSet, _DataSetE, _DataSetA, _DataSetActs;

        public FeedTool()
        {
            InitializeComponent();

            _Number.Minimum = 1;
            _Number.Maximum = 99;

            _NumberA.Minimum = 1;
            _NumberA.Maximum = 99;

            _Year.Minimum = 1948;
            _Year.Maximum = DateTime.Now.Year;

            _YearA.Minimum = 1948;
            _YearA.Maximum = DateTime.Now.Year;

            this._SystemString = new SystemString();

            this._Connection = new SqlConnection();

            this._Connection.ConnectionString = this._SystemString.DBString;

            Act _Act = new Act();
            Enactment _Enactment = new Enactment();
            Type _Type = new Type();
            Amendment _Amendment = new Amendment();

            this._DataAdapter = new SqlDataAdapter(_Act.SQLSelect, this._Connection);
            this._DataAdapterE = new SqlDataAdapter(_Enactment.SQLSelect, this._Connection);
            this._DataAdapterA = new SqlDataAdapter(_Amendment.SQLSelect, this._Connection);
            this._DataAdapterActs = new SqlDataAdapter(_Amendment.SQLSelectActs, this._Connection);

            new SqlCommandBuilder(this._DataAdapter);
            new SqlCommandBuilder(this._DataAdapterE);
            new SqlCommandBuilder(this._DataAdapterA);

            this._DataSet = new DataSet();
            this._DataSetE = new DataSet();
            this._DataSetA = new DataSet();
            this._DataSetActs = new DataSet();

            this._DataAdapter.Fill(this._DataSet);
            this._DataAdapterE.Fill(this._DataSetE);
            this._DataAdapterA.Fill(this._DataSetA);
            this._DataAdapterActs.Fill(this._DataSetActs);

            this._DataGrid.DataSource = _DataSet.Tables[0];
            this._DataGrid.Columns["ID"].Visible = false;
            this._DataGrid.Columns["FILE"].Visible = false;
            this._DataGrid.Columns["CATEGORY"].Visible = false;
            this._DataGrid.Columns["DATETIME"].Visible = false;

            this._DataGridE.DataSource = _DataSetE.Tables[0];
            this._DataGridE.Columns["ID"].Visible = false;
            this._DataGridE.Columns["FILE"].Visible = false;
            this._DataGridE.Columns["CATEGORY"].Visible = false;
            this._DataGridE.Columns["DATETIME"].Visible = false;

            this._DataGridA.DataSource = _DataSetA.Tables[0];
            this._DataGridA.Columns["ID"].Visible = false;
            this._DataGridA.Columns["ACTID"].Visible = false;
            this._DataGridA.Columns["FILE"].Visible = false;
            this._DataGridA.Columns["DATETIME"].Visible = false;

            this._AmendFrom.DataSource = _DataSetActs.Tables[0];
            this._AmendFrom.ValueMember = "ID";
            this._AmendFrom.DisplayMember = "NAME";

            _AmendType.DataSource = Enum.GetValues(typeof(EmendType));

            try
            {
                int _ShowOnly = Convert.ToInt16(this._AmendFrom.SelectedValue.ToString());

                this.AmenmendLoad(_ShowOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog _FileDialog = new OpenFileDialog();
                _FileDialog.Filter = "PDF File|*.pdf";
                _FileDialog.Multiselect = false;
                _FileDialog.ShowDialog();

                PDF _PDF = new PDF();

                this._FileName = _PDF.Coppy(_FileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                Act _Act = new Act();

                _Act.Name = this._Name.Text.ToString();
                _Act.Number = Convert.ToInt16(this._Number.Text.ToString());
                _Act.Year = Convert.ToInt16(this._Year.Text.ToString());
                _Act.File = this._FileName;

                this._Connection.Open();               

                SqlCommand _Command = new SqlCommand(_Act.SQLInsert, this._Connection);

                _Command.ExecuteReader();

                this._Connection.Close();

                this._Name.Text = null;
                this._Number.Value = 1;
                this._Year.Value = 1948;
                this._FileName = null;

                this._DataSet.Reset();
                this._DataAdapter.Fill(this._DataSet);
                this._DataGrid.DataSource = _DataSet.Tables[0];

            }
            catch (Exception ex)
            {
                if (_Connection.State == ConnectionState.Open)
                {
                    this._Connection.Close();
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButtonE_Click(object sender, EventArgs e)
        {
            try
            {
                Enactment _Enactment = new Enactment();

                _Enactment.Name = this._NameE.Text.ToString();
                _Enactment.Volume = ConvertRomanToNumber(this._VolumeE.Text.ToString());
                _Enactment.Chapter = Convert.ToInt16(this._ChapterE.Text.ToString());
                _Enactment.File = this._FileName;

                this._Connection.Open();

                SqlCommand _Command = new SqlCommand(_Enactment.SQLInsert, this._Connection);

                _Command.ExecuteReader();

                this._Connection.Close();

                this._NameE.Text = null;
                this._VolumeE.Text = null;
                this._ChapterE.Value = 1;
                this._FileName = null;

                this._DataSetE.Reset();
                this._DataAdapterE.Fill(this._DataSetE);
                this._DataGridE.DataSource = _DataSetE.Tables[0];

            }
            catch (Exception ex)
            {
                if (_Connection.State == ConnectionState.Open)
                {
                    this._Connection.Close();
                }
                MessageBox.Show(ex.Message);
            }
        }
        
        private void SaveButtonA_Click(object sender, EventArgs e)
        {
            try
            {
                Amendment _Amendment = new Amendment();

                _Amendment.ActID = Convert.ToInt16(this._AmendFrom.SelectedValue);
                _Amendment.Number = Convert.ToInt16(this._NumberA.Text.ToString());
                _Amendment.Year = Convert.ToInt16(this._YearA.Text.ToString());
                _Amendment.EmendType = (EmendType)Enum.Parse(typeof(EmendType), this._AmendType.SelectedItem.ToString(), true); 
                _Amendment.File = this._FileName;

                this._Connection.Open();

                SqlCommand _Command = new SqlCommand(_Amendment.SQLInsert, this._Connection);

                _Command.ExecuteReader();

                this._Connection.Close();

                this._NumberA.Value = 1;
                this._YearA.Value = 1948;
                this._FileName = null;

                this.AmenmendLoad(_Amendment.ActID);

            }
            catch (Exception ex)
            {
                if (_Connection.State == ConnectionState.Open)
                {
                    this._Connection.Close();
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this._DataSet.GetChanges() != null)
                {
                    this._DataAdapter.Update(this._DataSet.GetChanges());

                    MessageBox.Show("Successfully changed.");
                }
                else
                {
                    MessageBox.Show("Nothing to change.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButtonE_Click(object sender, EventArgs e)
        {
            try
            {

                if (this._DataSetE.GetChanges() != null)
                {
                    this._DataAdapterE.Update(this._DataSetE.GetChanges());

                    MessageBox.Show("Successfully changed.");
                }
                else
                {
                    MessageBox.Show("Nothing to change.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void UpdateButtonA_Click(object sender, EventArgs e)
        {
            try
            {

                if (this._DataSetA.GetChanges() != null)
                {
                    this._DataAdapterA.Update(this._DataSetA.GetChanges());

                    MessageBox.Show("Successfully changed.");
                }
                else
                {
                    MessageBox.Show("Nothing to change.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RelordButton_Click(object sender, EventArgs e)
        {
            this._DataSet = new DataSet();
            this._DataSetE = new DataSet();
            this._DataSetA = new DataSet();
            this._DataSetActs = new DataSet();

            this._DataAdapter.Fill(this._DataSet);
            this._DataAdapterE.Fill(this._DataSetE);
            this._DataAdapterA.Fill(this._DataSetA);
            this._DataAdapterActs.Fill(this._DataSetActs);

            this._DataGrid.DataSource = _DataSet.Tables[0];
            this._DataGridE.DataSource = _DataSetE.Tables[0];
            this._DataGridA.DataSource = _DataSetA.Tables[0];

            this._AmendFrom.DataSource = _DataSetActs.Tables[0];
            this._AmendFrom.ValueMember = "ID";
            this._AmendFrom.DisplayMember = "NAME";

            try
            {
                int _ShowOnly = Convert.ToInt16(this._AmendFrom.SelectedValue.ToString());

                this.AmenmendLoad(_ShowOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void TabChange(object sender, EventArgs e)
        {
            this._FileName = null;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int _ShowOnly = Convert.ToInt16(this._AmendFrom.SelectedValue.ToString());

                this.AmenmendLoad(_ShowOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AmenmendLoad(int _ShowOnly)
        {
            try
            {
                this._DataSetA = new DataSet();

                Amendment _Amendment = new Amendment();

                SqlDataAdapter _DataAdapter = new SqlDataAdapter(_Amendment.SQLSelectShow(_ShowOnly), this._Connection);

                new SqlCommandBuilder(_DataAdapter);

                _DataAdapter.Fill(this._DataSetA);

                this._DataGridA.DataSource = _DataSetA.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
