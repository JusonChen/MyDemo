using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.原型模式
{
    public class WorkExpersience:ICloneable
    {
        /// <summary>
        /// 公司名字
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 时间范围
        /// </summary>
        public string YearsRange { get; set; }

        /// <summary>
        /// 工作经验实现克隆
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //MemberwiseClone 浅复制，对值类型没问题，对引用类型，就只是复制了引用，对引用的对象，还是原来的对象
            return this.MemberwiseClone();
        }
    }
}
