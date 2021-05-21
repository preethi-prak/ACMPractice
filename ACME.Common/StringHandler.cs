using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public static class StringHandler
    {
        //Extention Method on .NET type String 
        //Call using the string name instead of static class name 
        //Eg _productName.InsertSpaces() 
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrEmpty(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result; 

        }
    }
}
