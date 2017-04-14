using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{

    public class QueryInfo<T> : DBContextBase where T : class
    {
        public QueryInfo()
        {
            query = dbContext.Set<T>();          
        }

        #region 记录的属性
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 是否执行统计数量
        /// </summary>
        private bool DoCount { get; set; }

        /// <summary>
        /// 返回的sql
        /// </summary>
        public string ReturnSql { get; set; }
  
        #endregion

        public IQueryable<T> query { get; set; }       


       

        public QueryInfo<T> Count()
        {
            DoCount = true;
            return this;
        }

       

      


        public List<T> SelectList()
        {
            if (DoCount)
            {
                TotalCount = query.Count();
            }
            //打印sql语句           
            ReturnSql = query.ToObjectQuery().ToTraceString();
            return query.ToList();
        }

        public T SelectOne()
        {
            if (DoCount)
            {
                TotalCount = query.Count();
            }
            //打印sql语句           
            ReturnSql = query.ToObjectQuery().ToTraceString();
            return query.FirstOrDefault();
        }
    }
}
