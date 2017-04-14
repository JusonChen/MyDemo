using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZSCallForm
{
    public abstract class BaseProcess
    {       

        public  void Write(string sErrorLog)
        {
            try
            {
                //读取LOG文件
                FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + GetFileName(), FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                //把Error写入LOG
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine(sErrorLog);
                //清空资源
                sw.Close();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception)
            {
            }
        }

        public virtual string GetFileName()
        {
            return "log.txt";
        }

        public abstract void Run();
    }
}
