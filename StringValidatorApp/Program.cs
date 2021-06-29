using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringLength stringLength = new StringLength();
            StringStartWith stringStratWith = new StringStartWith();
            StringReader stringReader = new StringReader();
            bool lengthvalue = stringLength.Validate("Srinivas");
            bool startWithValue = stringStratWith.Validate("excelSoft");
            bool readerValue = stringReader.Validate("");
            Console.WriteLine(lengthvalue);
            Console.WriteLine(startWithValue);
            Console.WriteLine(readerValue);
        }
    }
}
