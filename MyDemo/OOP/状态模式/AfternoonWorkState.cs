using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //下午状态类
    public class AfternoonWorkState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine(string.Format("当前时间:{0}点，饿了，午饭。困了，午休！", work.Hour));
            }
            else
            {
                work.SetState(new PMWorkState());
                work.WriteProgram();
            }
        }
    }
}
