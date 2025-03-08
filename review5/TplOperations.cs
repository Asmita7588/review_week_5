using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace review5
{
    //Use TPL to perform three independent operations in parallel:
    // Write numbers to a file.
    //Calculate the sum of an array.
    //Sort a list of strings.

    internal class TplOperations
    {


        public  static async Task  TplOperation() {
            Console.WriteLine("Running operations ");

            int[] array = { 122, 43, 45, 46, 5, 7 };

            Task<List<string>> task1 = TplOperations.SortListOfStrings();
            Task<int> task2 = TplOperations.SumOfArrayEle(array);
            Task task3 = TplOperations.WriteNumToFile();

            await Task.WhenAll(task1, task2, task3);

           List<string>  sortedstring =  await SortListOfStrings();
            foreach (string str in sortedstring) { 
                Console.WriteLine(str);
            }

            int sum = await SumOfArrayEle(array);
            Console.WriteLine(sum);
             
            Console.WriteLine("operation completed ");

        }




        public static async Task WriteNumToFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\review5\review5\Tplfile.txt";
            //File.Create(path);
 
            StreamWriter streamWriter = null;

            try
            {
                streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(2131);
                Console.WriteLine("file written successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();  
                }
            }

        }
        public  static async Task<int> SumOfArrayEle(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {

                sum = array[i];
            }
            
            return sum;
        }

        public static async Task<List<string>> SortListOfStrings()
        {
            List<string> names = new List<string> { "chetan", "asmita", "bhumesh", "dhruv", "faiyaz" };

            for (int i = 0; i < names.Count - 1; i++)
            {
                for (int j = 0; j < names.Count - 1; j++)
                {
                    int strLength = Sorting.CompareStrings(names[j], names[j + 1]);
                    if (strLength > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;

                    }
                }
            }
            return names;

        }
    }
}
