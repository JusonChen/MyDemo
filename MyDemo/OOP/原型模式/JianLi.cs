using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.原型模式
{
    /// <summary>
    /// 简历类
    /// </summary>
    public class JianLi:ICloneable
    {
        private string Name;

        private int Age;

        private WorkExpersience work;

        public JianLi()
        {

            work = new WorkExpersience();
        }

        /// <summary>
        /// 私有构造函数，以便对工作经验实体进行克隆数据
        /// </summary>
        /// <param name="_work"></param>
        private JianLi(WorkExpersience _work)
        {
            //对引用类型，需要这样处理
            work = (WorkExpersience)_work.Clone();
        }

        /// <summary>
        /// 设置工作经验
        /// </summary>
        public void SetWorkExpersience(string companName,string yearRange)
        {
            this.work.CompanyName = companName;
            this.work.YearsRange = yearRange;
            
        }

        public void SetPersonalInfo(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("姓名:{0},年龄:{1},工作经历>公司:{2}，年限:{3}", Name, Age, work.CompanyName, work.YearsRange));
        }

        public object Clone()
        {
            JianLi jl = new JianLi(this.work);
            jl.Name = this.Name;
            jl.Age = this.Age;
            return jl;
        }
    }
}
