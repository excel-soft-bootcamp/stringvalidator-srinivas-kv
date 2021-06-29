using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorApp
{
    public class StringValidator 
    {
        IStringValidatorControl _validatorControl;
        public StringValidator(IStringValidatorControl stringValue)
        {
            this._validatorControl = stringValue;
        }
        public void ValidatingString(string dataValue)
        {
           _validatorControl.Validate(dataValue);
        }
    }
}
