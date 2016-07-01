using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Serial_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"LicenseKey.txt"))
            {
                File.Delete(@"LicenseKey.txt");
            }

            StreamWriter _File = new StreamWriter(@"LicenseKey.txt", true);


            Console.WriteLine("Serial Number Generator for Acts Application.");
            Console.WriteLine("Developed By Diyanada J. Gunawardena.");
            Console.WriteLine("(+94) 71 3 196876.");
            Console.WriteLine("diyanada@gmail.com.");
            Console.WriteLine();

            //------------------------------------------------------------------------
            int _Sum = 0;
            String _Key = null;

            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        _Sum = i;
                        _Sum += j;
                        _Sum += k;

                        if (_Sum % 7 == 0)
                        {
                            Common _Common = new Common();

                            _Key = _Common.RandNumbers(i);

                            _Key += "-" + _Common.RandWord();

                            _Key += "-" + _Common.RandNumbers(j);

                            _Key += "-" + _Common.RandWord();
                            
                            _Key += "-" + _Common.RandNumbers(k);

                            Console.WriteLine(_Key);

                            _File.WriteLine(_Key);
                        }
                    }
                }
            }
            //------------------------------------------------------------------------

            String _Args;


            _File.Close();

            Console.WriteLine("Those license keys are successfully saved on '{0}'", Path.GetFullPath(@"LicenseKey.txt"));

            do
            {

                Console.Write("Type 'quit' to exit : ");
                _Args = Console.ReadLine();
            }
            while (_Args != "quit");
        }
    }

    class Common
    {
        private static Random _Rnd = new Random();

        public String RandNumbers(int _Value)
        {
            String _Return = "";            

            _Return += _Rnd.Next(1, 9).ToString();
            _Return += _Rnd.Next(1, 9).ToString();
            _Return += _Rnd.Next(1, 9).ToString();

            _Return += _Value.ToString();

            return _Return;
        }

        public String RandWord()
        {
            String _Return = "";

            _Return += (char)('A' + _Rnd.Next(0, 26));
            _Return += (char)('A' + _Rnd.Next(0, 26));
            _Return += (char)('A' + _Rnd.Next(0, 26));
            _Return += (char)('A' + _Rnd.Next(0, 26));

            return _Return;
        }
    }
}
