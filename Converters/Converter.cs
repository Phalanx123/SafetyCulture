using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyCulture.Converters
{
    internal class Converter
    {
        public static string NullableBoolToStringConverter(bool? inputBool)
        {
            if (inputBool.HasValue)
            {
                return inputBool.Value ? "true" : "false";
            }
            else
            {
                return "both";
            }
        }
    }
}
