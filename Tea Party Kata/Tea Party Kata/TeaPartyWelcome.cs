using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Party_Kata
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Tea Party. Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Knighted: ");
            string isKnightedString = Console.ReadLine();

            bool isKnighted = false;
            if (isKnightedString == "Yes" || isKnightedString == "YES" || isKnightedString == "True" || isKnightedString == "TRUE")
                isKnighted = true;

            TeaPartyWelcome teaPartyWelcome = new TeaPartyWelcome();
            string welcomeString = teaPartyWelcome.Welcome(lastName, gender, isKnighted);
            Console.WriteLine(welcomeString);
        }
    }

    public class TeaPartyWelcome : ITeaPartyWelcome
    {       
        public string Welcome(string lastName, string gender, bool isKnighted)
        {
            string welcomeString = "Hello ";

            if (isKnighted)
                welcomeString += "Sir ";
            else if (gender == "Male")
                welcomeString += "Mr. ";
            else if  (gender == "Female")
                welcomeString += "Ms. ";

            welcomeString += lastName;
            return welcomeString;
        }
    }
}
