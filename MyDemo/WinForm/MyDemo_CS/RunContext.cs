using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyDemo_CS
{
    public class RunContext
    {


        public void Import()
        {
            for (int i = 0; i < 500;i++)
            {
                Thread.Sleep(250);

            }
        }
    }
}
