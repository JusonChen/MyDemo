using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Log
{
    ///写日志
    public static class ErrorLog
    {

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="sErrorLog">日志信息</param>
        public static void Write(string sErrorLog)
        {

            try
            {
                //读取LOG文件
                FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + @"log.txt", FileMode.Append);
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
        /// <summary>
        /// 清空日志
        /// </summary>
        public static void DeleteLog()
        {
            try
            {
                FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + @"log.txt", FileMode.Create, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string content = sr.ReadToEnd();
                content = "";
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(content);
                sw.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
