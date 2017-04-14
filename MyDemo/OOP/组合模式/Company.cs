using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.组合模式
{
    abstract class Company
    {
        protected string _name = string.Empty;
        public Company(string name)
        {
            _name = name;
        }

        public abstract void Add(Company _company);

        public abstract void Remove(Company _company);

        public abstract void Display(int depth);

        public abstract void Duty();
    }
}
