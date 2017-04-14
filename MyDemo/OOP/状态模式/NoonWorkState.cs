using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //早上状态类；
    public class NoonWorkState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine(string.Format("当前时间:{0}点，精神百倍！", work.Hour));
            }
            else {
                work.SetState(new AfternoonWorkState());
                work.WriteProgram();
            }
        }
    }
}
