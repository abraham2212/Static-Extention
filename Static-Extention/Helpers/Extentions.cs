using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static_Extention.Helpers
{
    public static class Extentions
    {
        public static int GetNum( this int num)
        {
            return num;
        }
        
        public static bool CheckDigitString(this string text)
        {
            return Regex.IsMatch(text, @"\d");
        }
        public static bool CheckString(this string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }



    }
}
