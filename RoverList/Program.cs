using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList myList = new RoverList();
            String[] data = "Success is not final, failure is not fatal: it is the courage to continue that counts".Split(' ');

            foreach (string a in data)
                myList.Add(a);

            myList.ListNodes();
            Console.WriteLine();

            for (int i = myList.Count; i > 0; i--)
                if (i % 3 == 0)
                    myList.RemoveAt(i-1);


            myList.ListNodes();
            Console.WriteLine();

            //Prompt the user to input words, add those words to the list until they enter the word "done"
            bool end = false;
            while(!end)
            {
                Console.WriteLine("Input word(s) to be added to the list.  Type \"done\" when finished:");
                string[] words = Console.ReadLine().Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].ToUpper() == "DONE")
                        end = true;
                    else
                        myList.Add(words[i]);
                }
            }

            myList.ListNodes();
            Console.WriteLine();

            //Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            end = false;
            while (!end)
            {
                Console.WriteLine("Input word(s) to be added to the front of the list.  Type \"done\" when finished:");
                string[] words = Console.ReadLine().Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].ToUpper() == "DONE")
                        end = true;
                    else
                        myList.Add(0, words[i]);
                }
            }

            myList.ListNodes();
            Console.WriteLine();
            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list
        }
    }
}
