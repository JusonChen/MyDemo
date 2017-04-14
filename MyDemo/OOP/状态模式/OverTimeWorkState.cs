using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class OverTimeWorkState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 21)
            {
                Console.WriteLine(string.Format("当前时间:{0}点，加班哦，实在困！", work.Hour));
            }
            else
            {
                Console.WriteLine(string.Format("当前时间:{0}点，不行了，回家睡觉！", work.Hour));
            }
        }
    }
}
