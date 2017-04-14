using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.外观模式
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class Facade
    {
        private SubSystemOne sysOne;
        private SubSystemTwo sysTwo;
        private SubSystemThree sysThree;
        private SubSystemFour sysfour;

        public Facade()
        {
            sysOne = new SubSystemOne();
            sysTwo = new SubSystemTwo();
            sysThree = new SubSystemThree();
            sysfour = new SubSystemFour();
        }
        /// <summary>
        /// 自定义方法，组合方法
        /// </summary>
        public void DefineFunction1()
        {
            sysOne.SubSystemOne_Fn();
            sysTwo.SubSystemTwo_Fn();          
        }

        /// <summary>
        /// 自定义方法，组合方法
        /// </summary>
        public void DefineFunction2()
        {          
            sysTwo.SubSystemTwo_Fn();
            sysThree.SubSystemThree_Fn();
            sysfour.SubSystemFour_Fn();
        }
    }
}
