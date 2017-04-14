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

namespace MyDemo_CS
{
    public partial class 进度条例子Fm : Form
    {
        public 进度条例子Fm()
        {
            InitializeComponent();
        }

        public ShowProgressEvent showEvent
        {
            get; set;
        }

        public delegate void UpdateUI(object sender, myEvent e);

        private void button1_Click(object sender, EventArgs e)
        {           

            MethodInvoker inv = new MethodInvoker(Run);
            inv.BeginInvoke(null, null);
        }

        public void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                showEvent.Excute(10, i, "abc");
                Thread.Sleep(250);
            }

            BeginInvoke(new UpdateUI(ToUpdateUI),this,new myEvent("hahaha"));
           
        }

        public void ToUpdateUI(object sender, myEvent e)
        {
            myProcessBar.Hide();
            string msg = e.MyMsg;
        }


        private void 进度条例子Fm_Load(object sender, EventArgs e)
        {
            var numA = 0.3 + 0.1;
            var dateRandom = DateTime.Now.ToString("yyMMddHHmmss");
            Random ran = new Random();
            int ab = 123;
            var cccc = ab.ToString("000");
            int RandKey = ran.Next(1, 999);
            var aa = dateRandom + RandKey;
            showEvent = new ShowProgressEvent();
            showEvent.showProgressEvent += myProcessBar.ShowProgress;
          
        }
    }
    public class myEvent : EventArgs
    {
        public string MyMsg { get; set; }

        public myEvent(string msg)
        {
            MyMsg = msg;
        }
    }
}
