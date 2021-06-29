using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    class StringLength : IStringValidatorControl
    {
        public bool Validate(string data)
        {

            if (data.Length > 8)
            {
                return false;
            }
            return true;
         
        }
    }
}
