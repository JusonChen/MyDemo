using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.状态模式
{
    //与work一样的道理，对比下work，work类把所有状态都提取到独立的对象类里
    public class 写成一堆的方法_臭味道_
    {
        public int Hour { get; set; }

        public bool IsFinished { get; set; }

        public string WritePrograme()
        {
            string msg = string.Empty;
            if (Hour < 12)
            {
                msg = string.Format("当前时间:{0}点，精神百倍！", Hour);
            }
            else if (Hour < 13)
            {
                msg = string.Format("当前时间:{0}点，饿了，午饭。困了，午休！", Hour);
            }
            else if (Hour < 17)
            {
                msg = string.Format("当前时间:{0}点，下午工作状态还不错，继续工作！", Hour);
            }
            else
            {
                if (IsFinished)
                {
                    msg = string.Format("当前时间:{0}点，工作完成，下班了！", Hour);
                }
                else
                {
                    if (Hour < 21)
                    {
                        msg = string.Format("当前时间:{0}点，加班哦，实在困！", Hour);
                    }
                    else
                    {
                        msg = string.Format("当前时间:{0}点，不行了，回家睡觉！", Hour);
                    }
                }
            }
            return msg;
        }
    }
}
