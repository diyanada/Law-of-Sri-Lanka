using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Acts_of_Sri_Lanka
{
    public partial class Loader : Form
    {
        public Loader(String _File, String _Text)
        {
            InitializeComponent();

            this.Text = _Text;

            SystemString _SystemString = new SystemString();

            String _Path = _SystemString.FileLocation;

            _RichText.LoadFile(_Path + _File);
        }
    }
}
