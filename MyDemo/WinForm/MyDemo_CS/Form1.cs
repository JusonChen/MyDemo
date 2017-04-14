using Manager;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sTestMsg = "D2uplicate entry '22454031546' for key 'PR2IMARY' of table 'jdlppzgfqjd.kd_trade'";
            if ((sTestMsg.IndexOf("Duplicate entry") < 0) && (sTestMsg.IndexOf("key 'PRIMARY'") < 0))
            {

                backgroundWorker1.RunWorkerAsync();

            }

          //  try
          //  {
          //      string errorMsg = "";
          //      for (int i = 0; i <150000; i++)
          //      {
          //          errorMsg += "报错信息：1皮秒等于一万亿分之一秒（10-12秒1皮秒等于一万亿分之一秒（10-12秒" + i;
          //      }
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show(ex.Message);
          //  }
           
          //  MessageBox.Show("OK");
          //  string values = "15080296001";

          //  values =values.Substring(values.Length - 11, 11);


          //// Int64 a= Int64.Parse(values);
          //  values = "2016-02-06 10:55:55.0";
          //  DateTime dd = DateTime.Parse(values);
          //  Type t = Type.GetType("MyDemo_CS.trade");
          //  object obj = Activator.CreateInstance(t);
          //  PropertyInfo[] pi = t.GetProperties();
          //  foreach (PropertyInfo _item in pi)
          //  {


          //  }


          //  string value= "=\"1330832237282969\"";
          //  value = value.Trim();
          //  value = ((value.Substring(0, 2) == "=\"") ? value.Trim().Substring(2) : value).TrimEnd('"');
          //  value = value.TrimEnd('"');

          //  winformManager manager = ManagerFactory<winformManager>.GetManager();
          //  User user = new User();

          //  //Hashtable hs = getMappings();
          //  //string shuxingName = dic["名字"];
          //  //#region
          //  //#endregion
          //  //PropertyInfo[] propertys = user.GetType().GetProperties();
          //  //foreach (PropertyInfo item in propertys)
          //  //{
          //  //    //if(item.Name.ToLower()==)
          //  //}
          //  user.UserName = "czs";
          //  manager.Insert(user);
        }

        public Hashtable getMappings()
        {
            Hashtable hs =new Hashtable();
            hs.Add("名字", "UserName");
            return hs;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 11; i++)

            {

                Thread.Sleep(2000);

                backgroundWorker1.ReportProgress(i * 10);

                if (backgroundWorker1.CancellationPending)

                {

                    e.Cancel = true;
                  
                    return;

                }

            }
            e.Result = "完成";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _Progress.Value = e.ProgressPercentage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)

            {

                MessageBox.Show("Operation Cancelled"+ e.Result);

            }

            else

            {

                MessageBox.Show("OperationCompleted"+ e.Result);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallContext.SetData("czs", "123");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = CallContext.GetData("czs")==null ? "不存在": CallContext.GetData("czs").ToString();
            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable tb_Data = new DataTable();
            tb_Data.Columns.Add("Name");
            tb_Data.Columns.Add("Nick");
            tb_Data.Columns.Add("Sex");
            tb_Data.Columns.Add("Phone");
            tb_Data.Columns.Add("Year");
            tb_Data.Columns.Add("Money", typeof(int));
            tb_Data.Columns.Add("Remark");
            tb_Data.Columns.Add("CreateDateTime");
            tb_Data.Columns.Add("CreateUser");
            for (int i = 0; i < 100000; i++)
            {
                tb_Data.Rows.Add("czs" + i, "Nick" + i, "Sex" + i, "Phone" + i, "Year" + i,  i, "Remark" + i, DateTime.Now, "eve"+i);
            }
            string Name = "Name12";
            if (Name.Contains("Name1"))
            {

            }
            var aa = tb_Data.AsEnumerable().Where<DataRow>(c =>int.Parse( c["Money"].ToString())>5000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
