using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonBook.Data;

namespace TelefonBook.Data
{
    public class DataStore
    {
        private static List<Person> _personList = new List<Person>()
        {
            new Person { Name = "Lei", Tel = "0123456789" },
            new Person { Name = "Daniella", Tel = "9876543210" },
            new Person { Name = "Ahmad", Tel = "321987654" },
            new Person { Name = "Simon", Tel = "654987321" }
        };

        public void AddPerson(Person newPerson)
        {
            _personList.Add(newPerson);
        }

        public void RemovePerson(int removeId)
        {
            _personList.RemoveAt(removeId - 1);
        }

        public Person GetPerson(int id)
        {
            return _personList[id - 1];
        }

        public void ReorderList()
        {
            List<Person> _newPersonList = new List<Person>();
            foreach (Person person in _personList)
            {
                _newPersonList.Add(person);
            }
            _personList = _newPersonList;
        }

        public List<Person> GetPersonList()
        {
            return _personList;
        }
    }
}
