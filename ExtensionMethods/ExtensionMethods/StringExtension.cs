using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static string FirsttoUpper(this String str)
        {
            string Primeira = str.Substring(0, 1);
            
            string Segunda = str.Substring(1);

            return Primeira.ToUpper() + Segunda;
        }

    }
}
