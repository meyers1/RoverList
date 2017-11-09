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
            //Create a RoverList and then fill it with 16 words
            RoverList myList = new RoverList();
            String[] data = "Success is not final, failure is not fatal: it is the courage to continue that counts".Split(' ');

            foreach (string a in data)
                myList.Add(a);

            //Print out the list
            Console.Write("LIST: ");
            myList.ListNodes();
            Console.WriteLine();
            //Remove every 3rd word
            for (int i = myList.Count; i > 0; i--)
                if (i % 3 == 0)
                    myList.RemoveAt(i-1);

            //Print out the list
            Console.Write("\nLIST: ");
            myList.ListNodes();
            Console.WriteLine("\n");

            //Prompt the user to input words, add those words to the list until they enter the word "done"
            bool end = false;
            while(!end)
            {
                Console.WriteLine("Input word(s) to be added to the list.  Type \"done\" when finished: ");
                string[] words = Console.ReadLine().Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].ToUpper() == "DONE")
                        end = true;
                    else
                        myList.Add(words[i]);
                }
            }

            //Print out the list
            Console.Write("\nLIST: ");
            myList.ListNodes();
            Console.WriteLine("\n");

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

            //Print out the list
            Console.Write("\nLIST: ");
            myList.ListNodes();
            Console.WriteLine();

            //Remove every word with an odd length
            for (int i = myList.Count-1; i >= 0; i--)
            {
                if (((string)myList.ElementAt(i).Data).Length % 2 != 0)
                    myList.RemoveAt(i);
            }

            //Print out the list
            Console.Write("\nLIST: ");
            myList.ListNodes();
            Console.WriteLine();

            //Clear the list
            myList.Clear();

            //Print out the list
            Console.Write("\nLIST: ");
            myList.ListNodes();
            Console.WriteLine("\n");
        }
    }
}
