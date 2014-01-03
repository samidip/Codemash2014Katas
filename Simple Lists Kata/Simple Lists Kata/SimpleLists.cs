using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Lists_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Lists. Please enter first string in list: ");
            string firstString = Console.ReadLine();
            SingleLinkedList linkedListStart = new SingleLinkedList(firstString);

            Console.WriteLine("Please enter next string to add to list: ");
            string secondString = Console.ReadLine();
            linkedListStart.Add(secondString);

            Console.WriteLine("Please enter next string to add to list: ");
            string thirdString = Console.ReadLine();
            linkedListStart.Add(thirdString);

            Console.WriteLine("Please enter a string to search the list: ");
            string searchString = Console.ReadLine();
            bool found = linkedListStart.Find(searchString);
            Console.WriteLine("Search result found: " + found);

            Console.WriteLine("Please enter a string to drop from list: ");
            string dropString = Console.ReadLine();
            linkedListStart.Remove(dropString);
            Console.WriteLine("Node dropped");

            Console.WriteLine("Please enter a string to search the list: ");
            string anotherSearchString = Console.ReadLine();
            bool foundAgain = linkedListStart.Find(anotherSearchString);
            Console.WriteLine("Search result found: " + foundAgain);
        }
    }
}
