using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo_CS
{
    // 显示进度条的委托声明
    public delegate void ShowProgressDelegate(int totalStep, int currentStep, string msg);

    public class ShowProgressEvent
    {
        public event ShowProgressDelegate showProgressEvent;


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="totalStep">总的进度</param>
        /// <param name="currentStep">当前进度</param>
        /// <param name="msg">文本消息</param>
        public void Excute(int totalStep, int currentStep, string msg)
        {
            if (showProgressEvent != null)
            {
                showProgressEvent(totalStep, currentStep, msg);
               
            }
        }
    }
}
