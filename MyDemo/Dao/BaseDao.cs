
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class BaseDao
    {     

        public DBContext dbContext
        {
            get
            {
                var dbContext = CallContext.GetData("DbContext") as DBContext;
                if (dbContext == null)  //线程在数据槽里面没有此上下文
                {
                    dbContext = new DBContext(); //创建一个EF上下文               
                    CallContext.SetData("DbContext", dbContext);
                }
                return dbContext;
            }
        }
        
    }
}
