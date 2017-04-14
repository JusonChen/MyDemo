using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ManagerFactory<T> where T :BaseManager
    {
        public static T GetManager()
        {
            var manager = Activator.CreateInstance<T>();
            manager.OnInit();
            return manager;
        }
    }
}
