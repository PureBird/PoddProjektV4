using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Validering
    {
        //Returnerar true om strängen är tom.
        public static bool IsTomStrang(string testStrang)
        {
            return string.IsNullOrEmpty(testStrang);
            
        }

        public static bool arHTTPSLank(string testStrang)
        {
            if( testStrang.StartsWith("https://"))
            {
                return false;
            }
            return true;
        }
    }
}
