using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public static class DaoFactory<T> where T :BaseDao
    {
        public static T GetDao()
        {
            var T = Activator.CreateInstance<T>();
            return T;
        }
    }
}
