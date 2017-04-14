using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class MyDemoCSDao:BaseDao
    {
        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable SelectDataTable(string mainSql, List<SqlParameter> paras)     
        {
            
            return dbContext.SelectDataTable(mainSql, paras.ToArray());
        }

        public  List<T> Selectlist<T>(string mainSql, List<SqlParameter> paras,int pageIndex,int pageSize,out int totalCount) where T :class
        {
            totalCount = 0;
            totalCount = dbContext.Database.SqlQuery<T>(mainSql, paras.ToArray()).Count();
            List<SqlParameter> newPara = new List<SqlParameter>();
            foreach (SqlParameter item in paras)
            {
                newPara.Add(new SqlParameter(item.ParameterName, item.Value));
            }
            var list = dbContext.Database.SqlQuery<T>(mainSql, newPara.ToArray()).Skip(pageIndex).Take(pageSize).ToList();
            return list;           
        }

        public List<T> SelectList<T>(int pageIndex, int pageSize, out int totalCount,out string sql) where T :class
        {
            totalCount = dbContext.Set<T>().Count();
            var query = dbContext.Set<T>().Skip(pageIndex).Take(pageSize);
            sql = query.ToObjectQuery().ToTraceString();
            return query.ToList();
        }



    }
}
