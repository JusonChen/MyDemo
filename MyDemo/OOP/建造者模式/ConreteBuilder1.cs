using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.建造者模式
{
    /// <summary>
    /// 建造类1
    /// </summary>
    class ConreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuildPart1()
        {
            product.Add("部件1");
        }

        public override void BuildPart2()
        {
            product.Add("部件2");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
