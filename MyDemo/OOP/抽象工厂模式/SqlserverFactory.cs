using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂模式
{
    class SqlserverFactory : IFactory
    {
        public override ICompany CreateCompany()
        {
            return new SqlServerCompany();
        }

        public override IDepartment CreateDepartment()
        {
            return new SqlserverDepartment();
        }

        public override IUser CreateUser()
        {
            return new SqlserverUser();
        }
    }
}
