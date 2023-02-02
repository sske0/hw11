using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    internal static class Extension
    {
        public static bool LenghtIs7(this string PIN)
        {
            if (PIN.Length == 7 && PIN.ToUpper() == PIN)
                return true;

            else
                return false;
        }
    }
}
