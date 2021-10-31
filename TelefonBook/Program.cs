using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonBook.Data;

namespace TelefonBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore dataStore = new DataStore();
            Manager manager = new Manager();
            dataStore.InitList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Telephone Book");
                Console.WriteLine(dataStore._seperator);
                dataStore.PersonList();
                manager.MainMenu();
            }

        }
    }
}
