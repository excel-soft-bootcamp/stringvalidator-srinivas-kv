using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    public class StringStartWith : IStringValidatorControl
    {
        public bool Validate(string data)
        {

            if (data.StartsWith("ex"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
