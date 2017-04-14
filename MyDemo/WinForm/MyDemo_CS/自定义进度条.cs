using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyDemo_CS
{
    public partial class 自定义进度条 : UserControl
    {
        public 自定义进度条()
        {
            InitializeComponent();
        }       

        // 显示进度条
        public void ShowProgress(int totalStep, int currentStep,string msg)
        {

            if (_Progress.InvokeRequired)
            {
                ShowProgressDelegate showProgress = new ShowProgressDelegate(ShowProgress);

                // 为了避免工作线程被阻塞，采用异步调用委托
                this.BeginInvoke(showProgress, new object[] { totalStep, currentStep, msg });
            }
            else
            {
                _Progress.Maximum = totalStep;
                _Progress.Value = currentStep;
                lbProcessMsg.Text = msg;
            }
        }
       
    }
}
