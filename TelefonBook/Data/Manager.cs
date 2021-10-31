using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBook.Data
{
    public class Manager
    {
        public readonly string _title = "Telephone Book\n------------------------------";
        public readonly string _seperator = "---------------";

        public void MainMenu()
        {
            Console.WriteLine("\n1: Add new person");
            Console.WriteLine("2: Remove person");
            Console.WriteLine("0: Exit");
            Console.Write("\nSvar: ");
            bool success = int.TryParse(Console.ReadLine(), out var input);
            if (success)
            {
                if (input == 1)
                {
                    CreatePerson();
                }
                else if (input == 2)
                {
                    RemovePerson();
                }
                else if (input == 0)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine($"Invalid number. Try Again....");
                Console.ReadLine();
            }
        }

        public void CreatePerson()
        {
            var dataStore = new DataStore();
            while (true)
            {
                Person newPerson = new Person();

                Console.Clear();
                Console.WriteLine(_title);
                Console.WriteLine("Add new Person");
                Console.WriteLine(_seperator);

                Console.Write("Name: ");
                newPerson.Name = Console.ReadLine();
                Console.Write("Telephone Number: ");
                newPerson.Tel = Console.ReadLine();

                Console.Clear();
                Console.WriteLine(_title);
                Console.WriteLine("Add new Person");
                Console.WriteLine(_seperator);
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Name:", (newPerson.Name)));
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Telephone #:", (newPerson.Tel)));
                Console.Write("\nIs this Information correct? (Y/n) : ");
                var input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "y":
                        {
                            dataStore.AddPerson(newPerson);
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
                var dataStore = new DataStore();
                var tempList = dataStore.GetPersonList();
                var counter = 1;

                Console.Clear();
                Console.WriteLine(_title);
                Console.WriteLine("Remove Person");
                Console.WriteLine(_seperator);

                foreach (Person person in tempList)
                {
                    Console.WriteLine($"ID: {counter++} : {person.Name}");
                }

                Console.Write("\nWhich person do you with to remove (ID): ");

                bool success = int.TryParse(Console.ReadLine(), out var removeId);
                if (success)
                {
                    if (removeId <= tempList.Count)
                    {
                        Console.Clear();
                        Console.WriteLine(_title);
                        Console.WriteLine("Remove Person");
                        Console.WriteLine(_seperator);

                        var tempPerson = dataStore.GetPerson(removeId);

                        Console.WriteLine(tempPerson.Name);
                        Console.WriteLine(tempPerson.Tel);

                        Console.WriteLine("\nIs this who you want to remove? (Y/n) ");
                        Console.Write("\nSvar: ");
                        var menuChoice = Console.ReadLine().ToLower();
                        switch (menuChoice)
                        {
                            case "y":
                                {
                                    dataStore.RemovePerson(removeId);
                                    return;
                                }
                            default:
                                {
                                    continue;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID not found...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid number. Try Again....");
                    Console.ReadLine();
                }
            }
        }
        public void GetPersonList()
        {
            var dataStore = new DataStore();
            var tempList = dataStore.GetPersonList();
            var orderNum = 1;

            foreach (Person person in tempList)
            {
                Console.WriteLine(orderNum++);
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Name:", (person.Name)));
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Telephone #:", (person.Tel)));
                Console.WriteLine(_seperator);
            }
        }

    }
}
