using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace review5
{
    internal class Sorting
    {
        //Sorting Names
       // Use a C# collection like List<T> to store a list of names. Sort them alphabetically without using built-in sorting methods.

        public static List<string> SortListOfNmaes()
        {
            List<string> names = new List<string> {"chetan", "asmita", "bhumesh","dhruv","faiyaz"};

            for (int i = 0; i < names.Count-1; i++) { 
                for (int j = 0; j < names.Count -1; j++)
                {
                    int strLength = Sorting.CompareStrings(names[j], names[j + 1]);
                    if (strLength> 0 )
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;

                    }
                }
            }
            return names;

        }

        public static int CompareStrings(string str1, string str2)
        {
            
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;

            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] != str2[i])
                {
                    return str1[i] - str2[i]; 
                }
            }

            
            return str1.Length - str2.Length;
        }
    }
}
