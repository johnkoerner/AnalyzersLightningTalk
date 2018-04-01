using System;
using System.Collections.Generic;
using System.Text;

namespace UsingAnalyzers
{
    internal class NameParser
    {
        public static (string first, string last) ParseName(string name)
        {
            return _splitIt(name);
        }

        private static (string first, string last) _splitIt(string name)
        {
            var f = name;
            var l = "";

            if (name.IndexOf(" ") > 0)
            {
                var idx = name.IndexOf(" ");
                f = name.Substring(0, idx+1);
                l = name.Substring(idx+1);
            }
            return (f, l);
        }
    }
}
