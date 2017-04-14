using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.组合模式
{
    /// <summary>
    /// 具体公司类
    /// </summary>
    class ConcretCompany : Company
    {
        private IList<Company> companys = new List<Company>();
        public ConcretCompany(string name) : base(name)
        { }
        public override void Add(Company _company)
        {
            companys.Add(_company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+_name);
            foreach (Company item in companys)
            {
                item.Display(depth + 2);
            }
        }

        public override void Duty()
        {
            foreach (Company item in companys)
            {
                item.Duty();
            }
        }

        public override void Remove(Company _company)
        {
            companys.Remove(_company);
        }
    }
}
