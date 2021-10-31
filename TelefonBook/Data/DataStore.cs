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
        private static List<Person> _personList = new List<Person>();
        public string _seperator = "------------------------------";

        public void InitList()
        {
            _personList.Add(new Person { Name = "Sally Mcquade", Tel = "0123456789" });
            _personList.Add(new Person { Name = "Gemma Robertson", Tel = "9876543210" });
        }

        public void AddPerson(Person newPerson)
        {
            _personList.Add(newPerson);
        }

        public void RemovePerson(int removeId)
        {
            _personList.RemoveAt(removeId-1);
            ReorderList();
        }

        public void PersonList()
        {
            var orderNum = 1;
            foreach (Person person in _personList)
            {

                Console.WriteLine(orderNum++);
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Name:", (person.Name)));
                Console.WriteLine(String.Format("{0,-15}{1,-50}", "Telephone #:", (person.Tel)));
                Console.WriteLine(_seperator);
            }
        }

        public Person GetPerson(int id)
        {
            return _personList[id-1];
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
    }
}
