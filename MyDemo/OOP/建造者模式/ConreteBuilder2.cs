using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.建造者模式
{
    /// <summary>
    /// 建造类2
    /// </summary>
    class ConreteBuilder2 : Builder
    {
        private Product product = new Product();
        public override void BuildPart1()
        {
            product.Add("部件3");
        }

        public override void BuildPart2()
        {
            product.Add("部件4");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
