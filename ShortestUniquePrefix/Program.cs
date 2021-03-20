using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestUniquePrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sb = new string[] {"bat","barn","bit","cab" };
            //Hashset to ensure uniqueness of the prefix of the words.
            HashSet<string> results = new HashSet<string>();
            
            int vlc = 0;
            int i = 0;
            StringBuilder snb = new StringBuilder(); //Using String Builder to improve performance 
                                                     //as we will perform multiple string operations.

            foreach (string item in sb)
            {
                for (i = 0; i <= vlc;)
                {
                    snb.Append(item[i]);
                    i++;
                    if (results.Add(snb.ToString())) //If unique prefix has been added to our results 
                    {
                        i = 0;  //Resetting the indices and string builder
                        vlc = 0;
                        snb.Clear(); 
                        break; //To break from the loop and goto next item.
                    } else
                    {
                        vlc += 1; //If we couldn't add the prefix with a single charaacter, then increment the prefix length
                    }
                }
            }            

            //Print the results
            foreach(string st in results)
            {
                Console.WriteLine(st);
            }
            Console.ReadKey();
        }
    }
}
