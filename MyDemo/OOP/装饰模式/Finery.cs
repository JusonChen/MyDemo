using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Finery:Person
    {
        Person component;
        public void Decorate(Person person)
        {
            this.component = person;
        }
        public override void Show()
        {
            if (component != null)
                component.Show();
        }
    }
}
