using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.建造者模式
{
    /// <summary>
    /// 抽象建造类
    /// </summary>
    abstract class Builder
    {
        public abstract void BuildPart1();

        public abstract void BuildPart2();


        public abstract Product GetResult();
    }
}
