using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂模式
{
    class OracleFactory : IFactory
    {
        public override ICompany CreateCompany()
        {
            return new OracleCompany();
        }

        public override IDepartment CreateDepartment()
        {
            return new OracelDepartment();
        }

        public override IUser CreateUser()
        {
            return new OracelUser();
        }
    }
}
