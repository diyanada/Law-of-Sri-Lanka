using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ActLankaTool
{
    class PDF
    {
        private SystemString _SystemString;
        private String _DesignationPath;
        public PDF()
        {
            this._SystemString = new SystemString();

            this._DesignationPath = _SystemString.FileLocation;

            if (!Directory.Exists(_DesignationPath))
            {
                Directory.CreateDirectory(_DesignationPath);
            }
        }
        public String Coppy(String _File)
        {
            String _DesignationFile = DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

            String _FileName = _DesignationPath + _DesignationFile;

            File.Copy(_File, _FileName, true);

            return _DesignationFile;
        }
    }
}
