using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBook.Data
{
    public class Manager
    {
        public void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1: Add new person");
            Console.WriteLine("2: Remove person");
            Console.WriteLine("0: Exit\n");
            var input = Console.ReadLine();

            if (input == "1")
            {
                CreatePerson();
            }
            else if (input == "2")
            {
                RemovePerson();
            }
        }

        public void CreatePerson()
        {
            var _dataStore = new DataStore();
            while (true)
            {
                Person newPerson = new Person();
                Console.WriteLine("Add new Person");
                Console.WriteLine(_dataStore._seperator);
                Console.Write("Name: ");
                newPerson.Name = Console.ReadLine();
                Console.Write("Telephone Number: ");
                newPerson.Tel = Console.ReadLine();
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Name:", (newPerson.Name)));
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Telephone #:", (newPerson.Tel)));
                Console.WriteLine("Is this Information correct? (Y/n)");
                var input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "y":
                        {
                            _dataStore.AddPerson(newPerson);
                            return;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }
        }

        public void RemovePerson()
        {
            while (true)
            {
                var _dataStore = new DataStore();
                List<Person> _tempList = new List<Person>();

                Console.WriteLine("Remove Person");
                Console.WriteLine(_dataStore._seperator);
                Console.Write("ID: ");
                var removeId = Convert.ToInt32(Console.ReadLine());

                var tempPerson = _dataStore.GetPerson(removeId);

                Console.WriteLine(tempPerson.Name);
                Console.WriteLine(tempPerson.Tel);

                Console.WriteLine("Is this who you want to remove? (Y/n) ");
                var menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "y":
                        {
                            _dataStore.RemovePerson(removeId);
                            return;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }
        }

    }
}
