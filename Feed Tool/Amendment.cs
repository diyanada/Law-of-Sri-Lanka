using System;
using System.Collections.Generic;
using System.Text;

namespace ActLankaTool
{
    class Amendment
    {
        private String _Table = "AMENDMENTS";
        private int _ActID;
        public int ActID
        {
            get { return this._ActID; }
            set
            {
                if (value <= 0)
                {
                    throw new ActIDException();
                }

                this._ActID = value;
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
        public EmendType EmendType
        {
            get;
            set;
        }
        public String SQLInsert
        {
            get
            {
                String _Query = "INSERT INTO [" + this._Table + "] ([ACTID], [NUMBER], [YEAR], [FILE] , [TYPE], [DATETIME]) VALUES ('";
                _Query += this._ActID + "', '";
                _Query += this._Number + "', '";
                _Query += this._Year + "', '";
                _Query += this._File + "', '";
                _Query += this.EmendType + "', '";
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
        public String SQLSelectActs
        {
            get
            {
                return "SELECT * FROM [ACTS] ORDER BY [ID] DESC;";
            }
        }

        internal string SQLSelectShow(int _ShowOnly)
        {
            return "SELECT * FROM [" + this._Table + "] WHERE [ACTID] = '" + _ShowOnly + "' ORDER BY [ID] DESC;";
        }
    }
}
