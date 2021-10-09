using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Compiler
{
    public static class Errors
    {
        public static List<string> Error_List = new List<string>();
        public static Dictionary<string, string> ErrorMsg = new Dictionary<string, string>()
        {
            ["IDEr"]= "Error in Identifier naming or in number formating    {0}",
            ["StrEr"]= "Error in string formating, expected Double quotes \"    {0}",
            ["OpEr"]= "Undefined Operator   {0}",

        };
    }
}
