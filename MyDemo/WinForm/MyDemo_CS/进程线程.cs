using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo_CS
{
    public partial class 进程线程 : Form
    {
        public 进程线程()
        {
            InitializeComponent();
        }

        private void 进程线程_Load(object sender, EventArgs e)
        {
            int iNumTest = 21;
            ChangeInt(iNumTest);
            string nameEva = "eeeeeehh";
            ChangeString(nameEva);
            TestModel2 objtest = new TestModel2();
            objtest.Age = 100;
            objtest.Name = "czs";
            Change(objtest);

            var dateTest = DateTime.Parse("2017-03-26").AddMonths(-3);
            var strValue2 = "czs";
            char[] charsCZS = strValue2.ToArray();
            Array.Reverse(charsCZS);
            var newStrValue = new String(charsCZS);

            List<TestModel2> models = new List<TestModel2>();
            models.Add(new TestModel2());
            models.Add(new TestModel2());
            foreach (TestModel2 item in models)
            {
                Change(item);


            }
            ThreadLocal<Dictionary<string,object>> ttAAA = new ThreadLocal<Dictionary<string, object>>();
            Dictionary<string, object> ttCCC = ttAAA.Value;
            long lGuid= BitConverter.ToInt64(Guid.NewGuid().ToByteArray(),0);

            string sValue = "修改人：吴华安，修改时间：2017-03-10 19:59:27 详细地址从[莲前啊354221讯）]变为[莲前街道软件园二期观日路22号401（南讯1）]性别从[女]变为[男]，";
            var values = sValue.Split('，');
            foreach (var strValue in values)
            {              
                if (strValue.IndexOf("手机号码") > 0|| strValue.IndexOf("详细地址") > 0 ||strValue.IndexOf("Email") > 0 )
                {
                    int leftStart = strValue.IndexOf("[");
                    int leftEnd = strValue.LastIndexOf("[");
                    int rightStart = strValue.IndexOf("]");
                    int rightEnd = strValue.LastIndexOf("]");
                    string oldChangeValue = strValue.Substring(leftStart + 1, rightStart - (leftStart + 1));
                    string newChangeValue = strValue.Substring(leftEnd + 1, rightEnd - (leftEnd + 1));
                    sValue = sValue.Replace(oldChangeValue, oldChangeValue+"陈主胜").Replace(newChangeValue, newChangeValue+ "陈主胜");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process _process = Process.Start(@"D:\测试的项目\MyDemo\CZSCallForm\bin\Debug\CZSCallForm.exe", "abchehe，haha");
        
        }


        private void Change(TestModel2 item)
        {
            item = new TestModel2();
            item.Name = "czs";
            item.Age = 18;
        }

        private void ChangeInt(int num)
        {
            num++;
        }

        private void ChangeString(string num)
        {
            num = "czs";
        }
    }
    public class TestModel2
    {
        public string Name {  get; set; }

        public int Age { get; set; }
    }
}
