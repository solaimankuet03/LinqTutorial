using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public static class ExtensionHelper
    {
        public static int GetWordCount(this string str)
        {
            if (!String.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
}
