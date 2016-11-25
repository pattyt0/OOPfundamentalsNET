using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class StringHandler
    {
        public static String InsertSpaces(string source)
        {
            string result = string.Empty;
            if (string.IsNullOrWhiteSpace(result))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
                result += result.Trim();

            }

            return result;
        }
    }
}
