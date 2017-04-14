using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂改进版
{
    class SqlserverFactory_ : IFactory_
    {

        public override IDepartment_ CreateDepartment()
        {
            return new SqlserverDepartment_();
        }

        public override IUser_ CreateUser()
        {
            return new SqlserverUser_();
        }
    }
}
