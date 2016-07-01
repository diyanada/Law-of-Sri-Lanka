namespace Acts_of_Sri_Lanka
{
    partial class Amendments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amendments));
            this._DataGrid = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _DataGrid
            // 
            this._DataGrid.AllowUserToAddRows = false;
            this._DataGrid.AllowUserToDeleteRows = false;
            this._DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this._DataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this._DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DataGrid.Location = new System.Drawing.Point(12, 12);
            this._DataGrid.Name = "_DataGrid";
            this._DataGrid.ReadOnly = true;
            this._DataGrid.Size = new System.Drawing.Size(760, 492);
            this._DataGrid.TabIndex = 0;
            this._DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DataGrid_CellContentClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(332, 510);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Amendments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this._DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Amendments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amendments";
            ((System.ComponentModel.ISupportInitialize)(this._DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _DataGrid;
        private System.Windows.Forms.Button CloseButton;
    }
}