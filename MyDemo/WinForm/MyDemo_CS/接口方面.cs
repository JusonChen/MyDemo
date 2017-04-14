using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDemo_CS.MyWebServiceTest;
using System.Net.Http;

namespace MyDemo_CS
{
    public partial class 接口方面 : Form
    {
        public 接口方面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebUtils webHelper = new WebUtils();
            string testURL = "http://192.168.20.122:8090/api/platform/getCompanyGuid";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("companyName", "上海百雀羚日用化学有限公司");
            var result = JsonConvert.DeserializeObject<OAApiInfo>(webHelper.DoGet(testURL, dic));

            string testURL2 = "http://www.nascent.cn/webApi_industry.php?page=1";
            var result2 = JsonConvert.DeserializeObject<APIZhiku>(webHelper.DoGet(testURL2, null));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test20170116 testWs = new Test20170116();
            MessageBox.Show(testWs.HelloWorld("czs", 16, "信息"));
        }

        /// <summary>
        /// 调取Asp.net WebAPI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress=new Uri( "http://localhost:1397/");
            var rsp =client.GetAsync("api/czsAPITest/1");

            #region 通用的方法
            WebUtils webHelper = new WebUtils();
            string testURL = "http://localhost:1397/apiCZS/czsAPITest/Delete";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", "5");
            var result = JsonConvert.DeserializeObject<String>(webHelper.DoGet(testURL, dic));
            #endregion


        }
    }
    public class OAApiInfo
    {
        public string result { get; set; }

        public string guid { get; set; }

        public string msg { get; set; }

    }

    public class APIZhiku
    {
        /// <summary>
        /// 状态
        /// </summary>
        public string success { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        public List<ApiZhikuData> data { get; set; }
    }

    public class ApiZhikuData
    {
        /// <summary>
        /// 链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public string time { get; set; }


    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Num { get; set; }

        public bool IsOK { get; set; }
    }
}
