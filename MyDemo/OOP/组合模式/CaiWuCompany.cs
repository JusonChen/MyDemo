using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.组合模式
{
    /// <summary>
    /// 财务部
    /// </summary>
    class CaiWuCompany : Company
    {
        public CaiWuCompany(string name) : base(name) { }
        public override void Add(Company _company)
        {
           
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+_name);
        }

        public override void Duty()
        {
            Console.WriteLine(_name+"算钱啦");
        }

        public override void Remove(Company _company)
        {
          
        }
    }
}
