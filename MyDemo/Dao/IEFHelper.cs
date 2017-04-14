using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface IEFHelper
    {
        /// <summary>
        /// 根据数据库实体—》插入记录
        /// </summary>
        int Insert(object entity);
        /// <summary>
        /// 根据数据库实体—》更新记录
        /// </summary>
        int Update(object entity);
        /// <summary>
        /// 删除单条记录
        /// </summary>
        int Delete(object entity);
        /// <summary>
        /// 查找单条记录
        /// </summary>
        T GetByKey<T>(object key) where T :class;
        /// <summary>
        /// Get all elements of type {T} in repository
        /// </summary>
        /// <returns>List of selected elements</returns>
        IQueryable<T> GetEntities<T>() where T : class;
        /// <summary>
        /// 实现对数据库的查询  
        /// </summary>
        /// <param name="whereLambda">拉姆达表达式</param>
        /// <returns>实体集合</returns>
        IQueryable<T> GetEntities<T>(Expression<Func<T, bool>> whereLambda)where T :class;
        /// <summary>
        /// 调用存储过程返回结果集
        /// </summary>
        /// <param name="commonText">执行存储过程的语句</param>
        /// <param name="parameters">存储过程的参数</param>
        /// <returns>TEntity</returns>
        //List<T> SelectList<T>(string commonText, params object[] parameters);
        /// <summary>
        /// 调用存储过程返回受影响行数
        /// </summary>
        /// <param name="commonText">执行存储过程的语句</param>
        /// <param name="parameters">存储过程的参数</param>
        /// <returns>int</returns>
        int ExecuteSqlCommand(string commonText, params object[] parameters);
    }
}
