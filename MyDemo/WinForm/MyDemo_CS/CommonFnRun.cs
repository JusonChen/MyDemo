using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;
using Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MyDemo_CS
{
    public partial class CommonFnRun : Form
    {
        public CommonFnRun()
        {
            InitializeComponent();
        }

        private void EnumFn_Click(object sender, EventArgs e)
        {
            var EnumName = EnumDescription.GetFieldName(PingTaiEnum.TianMao);
        }

        private void CommonFnRun_Load(object sender, EventArgs e)
        {
            int num = 1;
            int num2 = 2;
            num = num++;
            string requestValue = "2,3";
            StringBuilder select = new StringBuilder();
            string testValue = "A,|B,2,3|C,5";
            string[] sValues = testValue.Split('|');
            foreach (string s in sValues)
            {
                var abc = s.Substring(s.IndexOf(',') + 1);
                select.AppendFormat("<option value='{0}' {1}>{2}</option>", s.Split(',')[1], requestValue == s.Split(',')[1] ? "selected='selected'" : "", s.Split(',')[0]);
            }

            //假数据
            List<TestModel> lsModelTemp = new List<TestModel>();
            List<TestModel> lsModel = new List<TestModel>();
            for (int i = 0; i < 10; i++)
            {
                lsModel.Add(new TestModel() { UserName = "czs" + i, Password = "pas" + i, ShowTime = DateTime.Now });
            }

            List<TestModel> lsMode2 = new List<TestModel>();
            for (int i = 0; i < 10; i++)
            {
                lsMode2.Add(new TestModel() { UserName = "czs2" + i, Password = "pas2" + i, ShowTime = DateTime.Now });
            }

            List<TestModel> lsMode3 = new List<TestModel>();
            for (int i = 0; i < 10; i++)
            {
                lsMode3.Add(new TestModel() { UserName = "czs3" + i, Password = "pas3" + i, ShowTime = DateTime.Now });
            }
            lsModelTemp.AddRange(lsModel);
            lsModelTemp.AddRange(lsMode2);
            lsModelTemp.AddRange(lsMode3);
            var jArr = new JArray();
            lsModel.ForEach(u =>
            {
                var jObj = new JObject();
                jObj.Add(new JProperty("UIUserNameField", u.UserName));
                jObj.Add(new JProperty("UIPasswordField", u.Password));
                jObj.Add(new JProperty("UIShowTimeField", u.ShowTime));
                jArr.Add(jObj);
            });
            var jsonObj = new JObject(new JProperty("UIData", jArr));
            var timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            string returnJson = JsonConvert.SerializeObject(jsonObj, Formatting.Indented, timeFormat);

        }

        /// <summary>
        /// 特性方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var t1 = typeof(AttributeHelp);

            var abc = t1.GetCustomAttributes(true);

            foreach (MyClassAttribute item in abc)
            {
                MessageBox.Show(item.Documentation);
            }

            var abc2 = t1.GetMethods();

            foreach (var item in abc2)
            {
                var MethodAtt = item.GetCustomAttributes(true).FirstOrDefault() as MyMethodAttribute;
                if (MethodAtt != null)
                {
                    MessageBox.Show(MethodAtt.Documentation);
                }
            }


        }
        [MyMethod("特性测试")]
        public void CSAttribute()
        {

        }
    }

    [MyClass("测试类的特性")]
    public class TestModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime ShowTime { get; set; }
    }
}
