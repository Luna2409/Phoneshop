using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phoneshop
{
    public class Program
    {
        private readonly static PhoneService phoneService = new();
        private static Dictionary<int, Phone> listOfPhones;

        public Program()
        {
            listOfPhones = new Dictionary<int, Phone>();
        }

        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            listOfPhones = phoneService.GetList().ToDictionary(x => x.Id);

            var index = 1;

            foreach (var phone in listOfPhones)
            {
                Console.WriteLine($"{index}. {phone.Value.Brand}, {phone.Value.Type}");
                index++;
            }
            Console.WriteLine($"{listOfPhones.Count + 1}. Search");


            Console.Write("\nType the number of the option you want: ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.Clear();
                Console.WriteLine("invalid number \n");

                MainMenu();
            }

            if (number == (listOfPhones.Count + 1))
                Search();
            else
                Details(number);
        }

        private static void Details(int number)
        {
            Console.Clear();

            try
            {
                Phone phoneFound = phoneService.Get(number);

                Console.WriteLine($"{phoneFound.Brand}, {phoneFound.Type}, {phoneFound.PriceWithTax} \n");
                Console.WriteLine($"{phoneFound.Description}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("phone not found \n");

                MainMenu();
            }

            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        private static void Search()
        {
            Console.Clear();

            Console.Write("Search: ");
            var input = Console.ReadLine();

            var result = phoneService.Search(input);

            foreach (var phone in result)
            {
                Console.WriteLine($"{phone.Brand}");
            }

            Console.WriteLine("\nPress a key to go back");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }
    }
}
