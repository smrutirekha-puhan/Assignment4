using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWord
{
   public  class Program
    {
        public static void Main()
        {
            ArrayList ArrayWords = new ArrayList();
            ArrayWords.Add("Boat");
            ArrayWords.Add("house");
            ArrayWords.Add("cat");
            ArrayWords.Add("river"); ;
            ArrayWords.Add("cupboard");

            Console.WriteLine("Length Of Array : ");
            Console.WriteLine(ArrayWords.Count);

            //Printing plurals
            Console.WriteLine("Plural Of All Words :");
            foreach (string word in ArrayWords)
            {
                Console.WriteLine(word + "s");
            }

            ArrayWords.Add("Achieve");
            Console.WriteLine("Length Of Array After Insertion Of New Element : ");
            Console.WriteLine(ArrayWords.Count);

            //Replace Of 2nd word with it's synonym
            for (int i = 0; i < ArrayWords.Count; i++)
            {
                if((string)ArrayWords[i]=="house")
                {
                    ArrayWords[i] = "home";
                }
            }
            Console.WriteLine("Now House Changed to its synonym :");
            Console.WriteLine( ArrayWords[1]);

            //Printing The Words Having Length 7
            Console.WriteLine("Printing Words of Length 7");
            for (int i = 0; i < ArrayWords.Count; i++)
            {
                string w = (string)ArrayWords[i];
                if (w.Length==7)
               {
                   Console.WriteLine(ArrayWords[i]);
                }
                
            }
            
            Console.WriteLine("Word On 3rd Position :");
            Console.WriteLine(ArrayWords[2]);
            //Sorting Of Array In Ascending Order
            Console.WriteLine("After sorting :");
            for (int i = 0; i < ArrayWords.Count; i++)
            {
                
                ArrayWords.Sort();
                
                Console.WriteLine(ArrayWords[i]);
            }
            //Reverse Of Array
            Console.WriteLine("Reverse Order Of Array :");
            for (int i = 0; i < ArrayWords.Count; i++)
            {
                ArrayWords.Reverse();
                Console.WriteLine(ArrayWords[i]);
            }
            Console.ReadKey();
                
            }

        private static void PrintValues(IEnumerable ArrayWords)
        {
            foreach (Object obj in ArrayWords)
            {
                Console.WriteLine("  {0}", obj);
                Console.WriteLine();
            }
        }
    }
}
