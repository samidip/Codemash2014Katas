using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Wrap_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Word Wrap. Enter you line: ");
            string line = Console.ReadLine();
            Console.WriteLine("Max length of line: ");
            int maxLineLen = Convert.ToInt32(Console.ReadLine());

            WordWrapper wrapper = new WordWrapper();
            string wrappedLine = wrapper.Wrap(line, maxLineLen);
            Console.WriteLine(wrappedLine);
        }        
    }

    public class WordWrapper
    {
        public string Wrap(string line, int maxLineLen)
        {
            if (line.Length <= maxLineLen)
            {
                return line;
            }

            int indexOfBlank = line.LastIndexOf(" ", maxLineLen);
            int split;
            int offset;

            if (indexOfBlank > -1)
            {
                split = indexOfBlank;
                offset = 1;
            }
            else
            {
                split = maxLineLen;
                offset = 0;
            }

            // Recursion.
            return line.Substring(0, split) + "\n\r" + Wrap(line.Substring(split + offset), maxLineLen);
        }
    }
}
