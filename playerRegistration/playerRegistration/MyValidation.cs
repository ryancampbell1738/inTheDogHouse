using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playerRegistration
{
    class MyValidation
    {
        public static bool validLength(String txt, int min, int max)
        {
            bool ok = true;

            if (String.IsNullOrEmpty(txt))
                ok = false;

            else if (txt.Length < min || txt.Length > max)
                ok = false;

            return ok;
        }

        public static bool validNumber(string txt)
        {
            bool ok = true;
            for(int x=0; x<txt.Length; x++)
            {
                if(!(char.IsNumber(txt[x])))
                {
                    ok = false;
                }
            }
            return ok;
        }

        public static bool validLetter(String txt)      //Allows Alphabetic Characters
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for(int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validLetterWhiteSpace(String txt)        // Allows Alphabetic Characters and Whitespace
        {
            bool ok = true;

            if(txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for(int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                            ok = false;
                }
            }
            return ok;
        }
    }
}
