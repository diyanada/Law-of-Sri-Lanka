using System;
using System.Collections.Generic;
using System.Text;

namespace ActLankaTool
{
    class NumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Number is not valid!";
            }
        }
    }
    class NameException : Exception
    {
        public override string Message
        {
            get
            {
                return "Name is not valid!";
            }
        }
    }
    class YearException : Exception
    {
        public override string Message
        {
            get
            {
                return "Year is not valid!";
            }
        }
    }
    class FileException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please browse the PDF file";
            }
        }
    }
    class VolumeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Enactment Volume is not vaild.";
            }
        }
    }
    class ChapterException : Exception
    {
        public override string Message
        {
            get
            {
                return "Enactment Chapter is not vaild.";
            }
        }
    }
    class TypeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Type name is not vaild.";
            }
        }
    }
    class ActIDException : Exception
    {
        public override string Message
        {
            get
            {
                return "Act or Enactment is not vaild.";
            }
        }
    }
}
