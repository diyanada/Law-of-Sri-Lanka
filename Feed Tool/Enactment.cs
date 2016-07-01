using System;
using System.Collections.Generic;
using System.Text;

namespace ActLankaTool
{
    class Enactment
    {
        private String _Table = "ACTS";
        private String _Category = "ENACTMENT";
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
        private int _Volume;
        public int Volume
        {
            get { return this._Volume; }
            set
            {
                if (value <= 0)
                {
                    throw new VolumeException();
                }

                this._Volume = value;
            }
        }
        private int _Chapter;
        public int Chapter
        {
            get { return this._Chapter; }
            set
            {
                if (value <= 0)
                {
                    throw new ChapterException();
                }

                this._Chapter = value;
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
                _Query += this._Volume + "', '";
                _Query += this._Chapter + "', '";
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
                return "SELECT [ID], [NAME], [NUMBER] AS [VOLUME], [YEAR] AS [CHAPTER], [FILE], [CATEGORY], [DATETIME] FROM [" + this._Table + "] WHERE [CATEGORY] = '" + this._Category + "' ORDER BY [ID] DESC;";
            }
        }
    }
}
