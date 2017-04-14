using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //抽象状态类
    public abstract class WorkState
    {
       public abstract void WriteProgram(Work work);
    }
}
