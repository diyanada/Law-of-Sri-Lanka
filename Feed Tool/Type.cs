using System;
using System.Collections.Generic;
using System.Text;

namespace ActLankaTool
{
    class Type
    {
        private String _Table = "TYPES";
        private String _Name;
        public String Name
        {
            get { return this._Name; }
            set
            {
                if (value == "")
                {
                    throw new TypeException();
                }

                this._Name = value;
            }
        }
        public String SQLInsert
        {
            get
            {
                String _Query = "INSERT INTO [" + this._Table + "] ([NAME], [DATETIME]) VALUES ('";
                _Query += this._Name + "', '";
                _Query += DateTime.Now + "');";

                return _Query;
            }
        }
        public String SQLSelect
        {
            get
            {
                return "SELECT * FROM [" + this._Table + "] ORDER BY [ID] DESC;";
            }
        }
    }
}
