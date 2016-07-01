using System;
using System.Collections.Generic;
using System.Text;

namespace ActLankaTool
{
    class Act
    {
        private String _Table = "ACTS";
        private String _Category = "ACT";
        private String _Name;
        public String Name
        {
            get { return this._Name; }
            set
            {
                if (value == "")
                {
                    throw new NameException();
                }

                this._Name = value;
            }
        }
        private int _Number;
        public int Number
        {
            get { return this._Number; }
            set
            {
                if (value < 1 || 99 < value)
                {
                    throw new NumberException();
                }

                this._Number = value;
            }
        }
        private int _Year;
        public int Year
        {
            get { return this._Year; }
            set
            {
                if (value < 1948 || DateTime.Now.Year < value)
                {
                    throw new YearException();
                }

                this._Year = value;
            }
        }
        private String _File;
        public String File
        {
            get { return this._File; }
            set
            {
                if (value == null)
                {
                    throw new FileException();
                }
                this._File = value;
            }
        }
        public String SQLInsert
        {
            get
            {
                String _Query = "INSERT INTO [" + this._Table + "] ([NAME], [NUMBER], [YEAR], [FILE], [CATEGORY], [DATETIME]) VALUES ('";
                _Query += this._Name + "', '";
                _Query += this._Number + "', '";
                _Query += this._Year + "', '";
                _Query += this._File + "', '";
                _Query += this._Category + "', '";
                _Query += DateTime.Now + "');";

                return _Query;
            }
        }
        public String SQLSelect
        {
            get
            {
                return "SELECT * FROM [" + this._Table + "] WHERE [CATEGORY] = '" + this._Category + "' ORDER BY [ID] DESC;";
            }
        }
    }
}
