using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //下午状态类
    public class PMWorkState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine(string.Format("当前时间:{0}点，下午工作状态还不错，继续工作！", work.Hour));
            }
            else
            {
                work.SetState(new GoOffWorkState());              
                work.WriteProgram();
            }
        }
    }
}
