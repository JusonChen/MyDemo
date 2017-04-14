using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.建造者模式
{
    /// <summary>
    /// 指挥类
    /// </summary>
    class Director
    {
        /// <summary>
        /// 指挥构造过程
        /// </summary>
        /// <param name="builder"></param>
        public void Run(Builder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }
}
