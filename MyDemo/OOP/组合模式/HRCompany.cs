using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.组合模式
{
    /// <summary>
    /// 人力资源部
    /// </summary>
    class HRCompany : Company
    {
        public HRCompany(string name) : base(name) { }
        public override void Add(Company _company)
        {
          
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }

        public override void Duty()
        {
            Console.WriteLine(_name+"统计考勤了");
        }

        public override void Remove(Company _company)
        {
           
        }
    }
}
