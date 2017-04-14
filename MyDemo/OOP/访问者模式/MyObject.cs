using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.访问者模式
{
    class MyObject
    {
        private IList<Person> lsPerson = new List<Person>();

        public void Add(Person p)
        {
            lsPerson.Add(p);
        }

        public void Remove(Person p)
        {
            lsPerson.Remove(p);
        }

        public void Excute(Action _action)
        {
            foreach (Person _person in lsPerson)
            {
                _person.Action(_action);
            }
        }
    }
}
