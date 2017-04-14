using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace OOP.抽象工厂改进版
{
    /// <summary>
    /// 反射+配置文件，解决工厂的switch,case 分支,   做到开放扩展，修改关闭
    /// </summary>
    public class DataAccess
    {
        public readonly static string DBAccess = ConfigurationSettings.AppSettings["DB"];
       

        public static IUser_ CreateUser()
        {

            return (IUser_)Assembly.GetExecutingAssembly().CreateInstance(Assembly.GetExecutingAssembly().GetName().Name + ".抽象工厂改进版." + DBAccess + "User_");
        }

        public static IDepartment_ CreateDepartment()
        {            
            return (IDepartment_)Assembly.Load("OOP").CreateInstance("OOP.抽象工厂改进版." + DBAccess + "Department_");
        }

        public static ICompany_ CreateCompany()
        {
            return (ICompany_)Assembly.Load("OOP").CreateInstance("OOP.抽象工厂改进版." + DBAccess + "Company_");
        }
    }
}
