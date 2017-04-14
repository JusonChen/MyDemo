using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂改进版
{
    abstract class IFactory_
    {
        public abstract IUser_ CreateUser();

        public abstract IDepartment_ CreateDepartment();

  
    }
}
