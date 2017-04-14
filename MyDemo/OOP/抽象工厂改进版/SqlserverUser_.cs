using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂改进版
{
    class SqlserverUser_ : IUser_
    {
        public  void Get()
        {
            Console.WriteLine("你Get了一条SqlserverUser");
        }

        public  void Insert()
        {
            Console.WriteLine("你Insert了一条SqlserverUser");
        }
    }
}
