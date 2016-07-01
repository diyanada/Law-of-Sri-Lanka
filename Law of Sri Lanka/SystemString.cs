using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Acts_of_Sri_Lanka
{
    class SystemString
    {
        public String FileLocation
        {
            get 
            {
                return Directory.GetCurrentDirectory() + "/DATA/";
            }
        }
    }
}
