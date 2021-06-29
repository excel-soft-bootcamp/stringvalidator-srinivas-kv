using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    public interface IStringValidatorControl
    {
        bool Validate(string data);
    }
}
