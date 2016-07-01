namespace Acts_of_Sri_Lanka
{
    partial class FaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._DataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this._PictureBox = new System.Windows.Forms.PictureBox();
            this._NumberError = new System.Windows.Forms.Label();
            this._YearError = new System.Windows.Forms.Label();
            this._Year = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this._Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.publicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 609);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this._DataGrid);
            this.panel3.Location = new System.Drawing.Point(469, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 603);
            this.panel3.TabIndex = 3;
            // 
            // _DataGrid
            // 
            this._DataGrid.AllowUserToAddRows = false;
            this._DataGrid.AllowUserToDeleteRows = false;
            this._DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this._DataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this._DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this._DataGrid.Location = new System.Drawing.Point(20, 20);
            this._DataGrid.Name = "_DataGrid";
            this._DataGrid.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._DataGrid.Size = new System.Drawing.Size(650, 580);
            this._DataGrid.TabIndex = 0;
            this._DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGrid_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this._PictureBox);
            this.panel2.Controls.Add(this._NumberError);
            this.panel2.Controls.Add(this._YearError);
            this.panel2.Controls.Add(this._Year);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this._Number);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this._Name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 603);
            this.panel2.TabIndex = 2;
            // 
            // _PictureBox
            // 
            this._PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_PictureBox.Image")));
            this._PictureBox.Location = new System.Drawing.Point(123, 530);
            this._PictureBox.Name = "_PictureBox";
            this._PictureBox.Size = new System.Drawing.Size(200, 70);
            this._PictureBox.TabIndex = 18;
            this._PictureBox.TabStop = false;
            this._PictureBox.Click += new System.EventHandler(this._PictureBox_Click);
            // 
            // _NumberError
            // 
            this._NumberError.AutoSize = true;
            this._NumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._NumberError.ForeColor = System.Drawing.Color.Red;
            this._NumberError.Location = new System.Drawing.Point(429, 356);
            this._NumberError.Name = "_NumberError";
            this._NumberError.Size = new System.Drawing.Size(20, 25);
            this._NumberError.TabIndex = 17;
            this._NumberError.Text = "*";
            this._NumberError.Visible = false;
            // 
            // _YearError
            // 
            this._YearError.AutoSize = true;
            this._YearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._YearError.ForeColor = System.Drawing.Color.Red;
            this._YearError.Location = new System.Drawing.Point(429, 286);
            this._YearError.Name = "_YearError";
            this._YearError.Size = new System.Drawing.Size(20, 25);
            this._YearError.TabIndex = 16;
            this._YearError.Text = "*";
            this._YearError.Visible = false;
            // 
            // _Year
            // 
            this._Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Year.Location = new System.Drawing.Point(23, 286);
            this._Year.Name = "_Year";
            this._Year.Size = new System.Drawing.Size(400, 26);
            this._Year.TabIndex = 14;
            this._Year.TextChanged += new System.EventHandler(this.TextSerch);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(123, 405);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(200, 50);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // _Number
            // 
            this._Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Number.Location = new System.Drawing.Point(23, 356);
            this._Number.Name = "_Number";
            this._Number.Size = new System.Drawing.Size(400, 26);
            this._Number.TabIndex = 9;
            this._Number.TextChanged += new System.EventHandler(this.TextSerch);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number / Volume  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year / Chapter :";
            // 
            // _Name
            // 
            this._Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Name.Location = new System.Drawing.Point(23, 216);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(400, 26);
            this._Name.TabIndex = 5;
            this._Name.TextChanged += new System.EventHandler(this.TextSerch);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compiled by\r\nKALINGA INDATISSA\r\nPresident’s Counsel\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "AN INDEX TO THE ACTS OF SRI   LANKA\r\nFrom    1980 - 2016\r\n(Without Incorporations" +
                ")\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicationsToolStripMenuItem,
            this.prefaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // publicationsToolStripMenuItem
            // 
            this.publicationsToolStripMenuItem.Name = "publicationsToolStripMenuItem";
            this.publicationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.publicationsToolStripMenuItem.Text = "Publications ";
            this.publicationsToolStripMenuItem.Click += new System.EventHandler(this.publicationsToolStripMenuItem_Click);
            // 
            // prefaceToolStripMenuItem
            // 
            this.prefaceToolStripMenuItem.Name = "prefaceToolStripMenuItem";
            this.prefaceToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.prefaceToolStripMenuItem.Text = "Preface";
            this.prefaceToolStripMenuItem.Click += new System.EventHandler(this.prefaceToolStripMenuItem_Click);
            // 
            // FaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaceForm";
            this.Text = "Acts of Sri Lanka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem publicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefaceToolStripMenuItem;
        private System.Windows.Forms.TextBox _Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView _DataGrid;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox _Year;
        private System.Windows.Forms.Label _YearError;
        private System.Windows.Forms.Label _NumberError;
        private System.Windows.Forms.PictureBox _PictureBox;
    }
}

