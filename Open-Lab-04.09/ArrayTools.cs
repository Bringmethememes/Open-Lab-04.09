using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            HashSet<string> bruh = new HashSet<string>(strings);
            string[] pleb = new string[bruh.Count];
            bruh.CopyTo(pleb);
            return pleb;

        }
    }
}
