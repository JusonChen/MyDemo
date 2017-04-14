using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CZSCallForm
{
    public class TestCProccess : BaseProcess
    {
        public override string GetFileName()
        {
            return "TestCProccess.txt";
        }

        public override void Run()
        {
            for (int i = 1; i < 10000; i++)
            {
                base.Write("TestCProccess Test,次数" + i);
                Thread.Sleep(1000);
            }
        }
    }
}
