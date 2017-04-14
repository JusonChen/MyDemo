using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class GoOffWorkState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.IsFinished)
            {
                Console.WriteLine(string.Format("当前时间:{0}点，工作完成，下班了！", work.Hour));
            }
            else
            {
                work.SetState(new OverTimeWorkState());              
                work.WriteProgram();
            }
        }
    }
}
