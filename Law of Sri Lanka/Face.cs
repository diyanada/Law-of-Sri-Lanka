using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Acts_of_Sri_Lanka
{
    public partial class Face : Form
    {
        public Face()
        {
            InitializeComponent();
            
        }

        private void Face_Shown(object sender, EventArgs e)
        {

            for (int i = 0; i <= 100; i = i + 10)
            {
                Thread.Sleep(500);

                this._ProgressBar.Value = i;
            }

            this.Close();
        }        

        
    }
}
