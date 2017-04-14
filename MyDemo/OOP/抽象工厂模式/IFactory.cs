using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂模式
{
    abstract class IFactory
    {
        public abstract IUser CreateUser();

        public abstract IDepartment CreateDepartment();

        public abstract ICompany CreateCompany();
    }
}
