using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.抽象工厂模式
{
    class OracelUser : IUser
    {
        public override void Get()
        {
            Console.WriteLine("你Get了一条OracelUser");
        }

        public override void Insert()
        {
            Console.WriteLine("你Insert了一条OracelUser");
        }
    }
}
