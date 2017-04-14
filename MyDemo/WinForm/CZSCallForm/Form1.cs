using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZSCallForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] processName = { "TestAProccess", "TestBProccess", "TestCProccess" };
            for (int i = 0; i < processName.Length; i++)
            {

                Thread t = new Thread(new ParameterizedThreadStart(ThreadFn));
                t.Start(processName[i]);
            }
        }
        private  void ThreadFn(object processName)
        {

            ErrorLog.Write(processName.ToString());
            Type serverType = Type.GetType(string.Format("CZSCallForm.{0}", processName.ToString()));
            if (serverType != null)
            {
                object serverObject = Activator.CreateInstance(serverType);
                if (serverObject is BaseProcess)
                {
                    BaseProcess curProcessor = (BaseProcess)serverObject;
                    curProcessor.Run();
                }
            }
        }
    }
}
