using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardLinkUI
{
    public static class Global
    {
        internal static readonly string currentDir = Directory.GetCurrentDirectory();
        internal static readonly string dbDir = currentDir + @"\DB";
        internal static readonly string xmlDir = currentDir + @"\XML";
    }
}
