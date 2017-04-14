using Common.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

/// <summary>
/// 我的服务测试
/// </summary>
namespace MyService
{
    public partial class MyService : ServiceBase
    {
        //定时器，此处切记不是winform的Timer
        System.Timers.Timer timer = new System.Timers.Timer();
        public MyService()
        {
            InitializeComponent();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            int iInterval = 0;
            int.TryParse(ConfigurationSettings.AppSettings["MyInterval"], out iInterval);
            timer.Interval = iInterval<=0?3000: iInterval;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ErrorLog.Write("Timer  Write," + DateTime.Now.ToString());
        }

        protected override void OnStart(string[] args)
        {
            ErrorLog.Write("服务被开启,"+DateTime.Now.ToString());
            // TODO: 在此处添加代码以启动服务。
            timer.Enabled = true;
            timer.Start();
        }

        protected override void OnStop()
        {
            ErrorLog.Write("服务被停止," + DateTime.Now.ToString());
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            timer.Enabled = false;
            timer.Stop();
        }

       
    }
}
