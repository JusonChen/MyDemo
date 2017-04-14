using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件和委托例子
{
    public partial class 测试窗体 : Form
    {
        public 测试窗体()
        {
            InitializeComponent();
            eventCZS = new MyEvents();
        }

        private MyEvents eventCZS;

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 测试窗体_Load(object sender, EventArgs e)
        {
            //初始化这个事件绑定的方法
            eventCZS.czsThreeClick += MouseRun;
            eventCZS.czsThreeClick += PeopleSleep;
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ABC("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            //猫大叫一声，触发事件(执行事件里的方法)
            eventCZS.Excute(1);
        }


        public void MouseRun(int a )
        {
            MessageBox.Show("老鼠逃跑了");
        }
        public void ABC(string aaaaaaa1, string aaaaaaa2, string aaaaaaa4, string aaaaaaa3, string aaaaaaa5, string aaaaaaa6, string aaaaaaa7
            , string aaaaaaa8, string aaaaaaa9, string aaaaaaa10, string aaaaaaa11, string aaaaaaa12,
            string aaaaaaa13, string aaaaaaa14, string aaaaaaa15, string aaaaaaa16, string aaaaaaa17, string aaaaaaa18, string aaaaaaa19)
        {

        }


        public void PeopleSleep(int a)
        {
            MessageBox.Show("主人醒了");
        }


        
    }
}
