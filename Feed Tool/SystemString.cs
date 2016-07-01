using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

namespace ActLankaTool
{
    class SystemString
    {
        public String FileLocation
        {
            get
            {
                return Directory.GetCurrentDirectory() + "/Data/";
            }
        }
        public String DBString
        {
            get { return ConfigurationManager.ConnectionStrings["Storage"].ConnectionString; }
        }
    }
}
