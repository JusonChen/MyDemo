using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.建造者模式
{
    public class Product
    {
        private List<string> Names = new List<string>();
        public void Add(string partName)
        {
            Names.Add(partName);
        }

        public void Show()
        {
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
