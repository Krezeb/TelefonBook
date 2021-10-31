using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBook.Data
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Tel { get; set; }

        private static int _idCounter = 0; //Is kept in memory and used every time the Person Class is called ("Static")

        public Person()
        {
            Id = _idCounter++;
        }
    }
}
