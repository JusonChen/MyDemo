using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class QueryInfoEnumerable<T> : DBContextBase where T : class
    {
        public QueryInfoEnumerable(string MainSql, List<SqlParameter> parameterst)
        {
            query = dbContext.Database.SqlQuery<T>(MainSql, parameterst.ToArray());           
        }

        #region 记录的属性
        public bool DoCount { get; set; } 
      
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotalCount { get; set; }  
      
        #endregion

        public IEnumerable<T> query { get; set; }

        public void Count()
        {
            DoCount = true;
        }

        public List<T> Select()
        {
            var list=new List<T>();
            //try
            //{
            //    query = dbContext.Database.SqlQuery<T>(MainSql, parameterst.ToArray());
            //    if (DoCount)
            //    {
            //        TotalCount = query.Count();
            //    }

            //    List<SqlParameter> newPara = new List<SqlParameter>();
            //    foreach (SqlParameter item in parameterst)
            //    {
            //        newPara.Add(new SqlParameter(item.ParameterName, item.Value));
            //    }

            //    query = dbContext.Database.SqlQuery<T>(MainSql, newPara.ToArray());
            //    if (PageIndex != null)
            //    {
            //        query = query.Skip(PageIndex.GetValueOrDefault(0));
            //    }
            //    if (PageSize != null)
            //    {
            //        query = query.Take(PageSize.GetValueOrDefault(0));
            //    }
            //    //打印sql语句           
            //    ReturnSql = MainSql;
            //    list=query.ToList();
                
            //}
            //catch (Exception ex)
            //{

             
            //}
            return list;
        }


      
        
    }
}
