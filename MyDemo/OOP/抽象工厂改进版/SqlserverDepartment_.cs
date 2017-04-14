using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂改进版
{
    class SqlserverDepartment_ : IDepartment_
    {
        public  void Get()
        {
            Console.WriteLine("你Get了一条SqlserverDepartment");
        }

        public  void Insert()
        {
            Console.WriteLine("你Insert了一条SqlserverDepartment");
        }
    }
}
