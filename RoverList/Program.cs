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

            for (int i = 0; i < myList.Count; i++)
                if (i % 3 == 0)
                    myList.RemoveAt(i);


            myList.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
