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
            Manager manager = new Manager();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine(manager._title);
                manager.GetPersonList();
                manager.MainMenu();
            }
        }
    }
}
