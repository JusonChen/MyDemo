using OOP.中介者模式;
using OOP.原型模式;
using OOP.外观模式;
using OOP.工厂方法模式;
using OOP.工厂模式;
using OOP.建造者模式;
using OOP.模板方法模式;
using OOP.职责链模式;
using OOP.观察者模式;
using OOP.访问者模式;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using OOP.组合模式;
using OOP.抽象工厂模式;
using OOP.抽象工厂改进版;
using System.Reflection;


namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculationFactory factory = new CalculationFactory();
            CalculationBase calculationBase = factory.GetCalculation("-");
            calculationBase.numberA = 10;
            calculationBase.numberB = 3;
            var result = calculationBase.GetResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //如果算法发生改变，底层改变，客户端不会改变；(不用识别抽象类，只要识别策略类CalculationContext)
            //只是在策略类CalculationContext里，用工厂模式封装起来
            CalculationContext context = new CalculationContext("+",10,3);
            var result = context.GetResult();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person p = new Person("czs");
            TShirts tsh = new TShirts();
            BigTrouser bigTrouser = new BigTrouser();
            MaoZi maozi = new MaoZi();
            tsh.Decorate(p);
            bigTrouser.Decorate(tsh);
            maozi.Decorate(bigTrouser);
            maozi.Show();


            Person p2 = new Person("eva");

            maozi.Decorate(p2);
            tsh.Decorate(maozi);
            bigTrouser.Decorate(tsh);           
            bigTrouser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Proxy proxy = new Proxy();
            proxy.Request();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //与简单工厂模式相比
            //1.如果有新增功能，就不用在工厂类实例分支，修改工厂类的方法(开放封闭原则：扩展开放，修改封闭)。只要新增工厂和对应的功能类即可
            //客户端上，实例不同的工厂即可;
            ICalculationFactory addFacotry = new AddCalculationFactory();
            SunFaBase sunFaBase = addFacotry.GetCalculation();
            sunFaBase.numberA = 10;
            sunFaBase.numberB = 3;
            var abc = sunFaBase.GetResult();


            ICalculationFactory subFacotry = new SubtractionCalculationFactory();
            SunFaBase sunFaBase2 = subFacotry.GetCalculation();
            sunFaBase2.numberA = 10;
            sunFaBase2.numberB = 3;
            var abc2 = sunFaBase2.GetResult();

        }


        private void button6_Click(object sender, EventArgs e)
        {
            //实例一份简历1
            JianLi JL1 = new JianLi();
            JL1.SetPersonalInfo("czs", 27);
            JL1.SetWorkExpersience("GSEO", "2012~2014");

            //简历2  ，把简历1的简历克隆一份出来，再做修改;(不用再初始化)
            JianLi JL2 = (JianLi)JL1.Clone();
            JL2.SetWorkExpersience("Nascent", "2014~2016");

            JL1.Display();
            JL2.Display();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbstractClass abClass = new PrimitiveOperation1();
            AbstractClass abClass2 = new PrimitiveOperation2();

            abClass.CommonFn();
            abClass2.CommonFn();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Facade facade = new Facade();
            facade.DefineFunction1();
            facade.DefineFunction2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Director director = new Director();

            Builder builder1 = new ConreteBuilder1();
            director.Run(builder1);//用户告诉我，要ConreteBuilder1的建造类型
            Product p1 = builder1.GetResult();
            p1.Show();

            Builder builder2 = new ConreteBuilder2();
            director.Run(builder2);
            Product p2 = builder2.GetResult();
            p2.Show();

        }

        /// <summary>
        /// 就是执行一个通知者类的方法的时候，同时执行各个观察者类的方法(即将各个不同类的方法，委托给通知者类)；
        /// 执行通知者类的时候，会执行这个委托(绑定多个方法，就执行多个方法)的方法群;
        /// 先有观察者模式，再有委托事件的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            Notify_A notifyA = new Notify_A();
            notifyA.NotifyMessage = "【通知者A的信息】";

            NBAObserver nbaObserver = new NBAObserver(notifyA,"czs");            
            GuPiaoObserver guPiaoObserver = new GuPiaoObserver(notifyA, "eva");
            notifyA.ToNotify += new Update(nbaObserver.CloseNBA);//将NBA观察者的方法委托给   通知者的ToNotify
            notifyA.ToNotify += new Update(guPiaoObserver.CloseGuPiao);//将股票观察者的方法委托给   通知者的ToNotify
            notifyA.Notify();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                throw new MyError("hehe");
            }
            catch (MyError ex)
            {
              var abcf=  ex.MyErrorMsg;
            }

            StruckTest struck1 = new StruckTest();
            struck1.Name = "2222";
            var returnStr= struck1.GetName();
            var struck2 = struck1;
            struck2.Name = "55555";
            returnStr = struck1.GetName();
          


            TestClass c1 = new TestClass();
            c1.Name = "2222";
            returnStr = c1.GetName();
            var c2 = c1;
            c2.Name = "55555";
            returnStr = c1.GetName();
            TestFn fn = TestFn.GetInstrace();
            TestFn fn2 = TestFn.GetInstrace();
            if (fn == fn2)
            {

            }
            string abc = "20160531235213032019161";
            try
            {
                var lenght = long.MaxValue.ToString().Length;
                long.Parse(abc);
            }
            catch (Exception ex)
            {

              
            }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            JingLiManager jingliManange = new JingLiManager("经理");
            ZongJianManager zongJianManager = new ZongJianManager("总监");
            ZongJingliManager zongJingliManager = new ZongJingliManager("总经理");
            //流程1
            jingliManange.SetManager(zongJianManager);
            zongJianManager.SetManager(zongJingliManager);
            jingliManange.GetResult(20);

            //流程2
            jingliManange.SetManager(zongJingliManager);
            jingliManange.GetResult(55);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //中介则
            ConcretMediator mediator = new ConcretMediator();
            //同事类A，认识中介类
            ColleagueChildA c1 = new ColleagueChildA(mediator);
            //同事类B，认识中介类
            ColleagueChildB c2 = new ColleagueChildB(mediator);

            mediator.ColleagueA = c1;
            mediator.ColleagueB = c2;

            c1.Send("我请你吃饭");
            c2.Send("真的吗？");

            long guidLong= BitConverter.ToInt64((Guid.NewGuid().ToByteArray()), 0);
         
          
        }

        /// <summary>
        /// 访问者模式
        /// 男人成功时，背后多半有一个伟大的女人
        /// 女人成功时，背后多半有一个不成功的男人
        /// 男人失败时，闷头喝酒，谁也不用劝
        /// 女人失败时，眼泪汪汪，谁也劝不了
        /// 男人恋爱时，凡事不懂也要装懂
        /// 女人恋爱时，遇事懂也装不懂
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            MyObject myObject = new MyObject();         
            myObject.Add(new Man());
            myObject.Add(new Woman());

            FaileAction faile = new FaileAction();
            myObject.Excute(faile);

            SuccessAction success = new SuccessAction();
            myObject.Excute(success);
            //const
            //AppSettings
        }

        /// <summary>
        /// 组合模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            ConcretCompany CompanyMain = new ConcretCompany("公司总部");
            CaiWuCompany caiwu = new CaiWuCompany("总公司财务部");
            HRCompany hr = new HRCompany("总公司人力资源部");
            CompanyMain.Add(caiwu);
            CompanyMain.Add(hr);
            ConcretCompany CompanyChild_A = new ConcretCompany("子公司A");
            CaiWuCompany caiwuChild_A = new CaiWuCompany("子公司A财务部");
            HRCompany hrChild_A = new HRCompany("子公司A力资源部");
            CompanyChild_A.Add(caiwuChild_A);
            CompanyChild_A.Add(hrChild_A);
            CompanyMain.Add(CompanyChild_A);

            ConcretCompany CompanyChild_B = new ConcretCompany("子公司B");
            CaiWuCompany caiwuChild_B = new CaiWuCompany("子公司B财务部");
            HRCompany hrChild_B = new HRCompany("子公司B力资源部");
            CompanyChild_B.Add(caiwuChild_B);
            CompanyChild_B.Add(hrChild_B);
            CompanyMain.Add(CompanyChild_B);

            CompanyMain.Display(1);

            CompanyMain.Duty();

        }

        /// <summary>
        /// 抽象工厂(数据库切换为例)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            IFactory factorySqlserver = new SqlserverFactory();
            IUser user = factorySqlserver.CreateUser();
            user.Get();
            user.Insert();

            IFactory factoryOracle = new OracleFactory();
            IDepartment department = factoryOracle.CreateDepartment();
            department.Get();
            department.Insert();


        }

        /// <summary>
        /// 抽象工厂改进版
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            IUser_ user = DataAccess.CreateUser();
            user.Get();
            user.Insert();

            IDepartment_ department = DataAccess.CreateDepartment();
            department.Get();
            department.Insert();

            ICompany_ company = DataAccess.CreateCompany();
            company.Get();
            company.Insert();
        }

        /// <summary>
        /// 状态模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            #region 写成一堆的例子


            #endregion

            Work work = new Work();
            work.Hour = 22;
            work.WriteProgram();
        }
    }
}
