using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public abstract class DBContextBase
    {
        /// <summary>
        /// 数据源对象
        /// </summary>
        public DbContext dbContext = CreateInstance();

       

        #region 单例模式创建一个数据源对象
        /// <summary>
        /// 数据源对象
        /// </summary>
        //private static DBContext _dbContext = null;
        protected static DBContext CreateInstance()
        {
            var dbContext = CallContext.GetData("DbContext") as DBContext;
            if (dbContext == null)  //线程在数据槽里面没有此上下文
            {
                dbContext = new DBContext(); //创建一个EF上下文               
                CallContext.SetData("DbContext", dbContext);
            }

            return dbContext;
        }

        protected static DbContext RefreshInstance()
        {
            DBContext dbContext = new DBContext(); //创建一个EF上下文
            CallContext.SetData("DbContext", dbContext);
            return dbContext;
        }

        #endregion

        /// <summary>
        /// 提交变化 service层可能也会使用本方法,所以声明为public
        /// </summary>
        public virtual int SaveChanges()
        {
            this.dbContext.Configuration.ValidateOnSaveEnabled = false;
            return this.dbContext.SaveChanges();
        }
    }
    
}
