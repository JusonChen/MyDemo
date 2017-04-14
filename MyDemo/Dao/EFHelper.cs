using EntityFramework.BulkInsert.Extensions;
using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Model;
using Dao;
using System.Data.Entity.Core.Objects;

namespace Dao
{
    public class EFHelper : DBContextBase, IEFHelper
    {
        #region Insert
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="oEntity"></param>
        /// <returns></returns>
        public int Insert(object oEntity)
        {
            this.dbContext.Entry(oEntity).State = EntityState.Added;
            return this.SaveChanges();         
        }

        /// <summary>
        /// 新增(返回导入后的最后一笔ＩＤ)
        /// </summary>
        /// <param name="oEntity">实体</param>
        /// <param name="lastInsertID">返回导入的最后一笔的ID</param>
        /// <returns></returns>
        public int Insert(object oEntity, out int lastInsertID)
        {
            lastInsertID = 0;
            this.dbContext.Entry(oEntity).State = EntityState.Added;            
            var result = this.SaveChanges();
            Type t = oEntity.GetType();
            int.TryParse(t.GetProperty("ID").GetValue(oEntity) == null ? "0" : t.GetProperty("ID").GetValue(oEntity).ToString(), out lastInsertID);
            return result;
        }

        /// <summary>
        /// 批量导入
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="oEntity">实体数据</param>
        /// <returns></returns>
        public int Insert<T>(List<T> oEntity)
        {
            dbContext.BulkInsert(oEntity);
            return dbContext.SaveChanges();
        }

        /// <summary>
        /// 原生sql导入
        /// </summary>
        /// <param name="sql">原生sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public int Insert(string sql, params object[] parameters)
        {
            return ExecuteSqlCommand(sql, parameters);
        }
        #endregion

        #region Update
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="oEntity">实体</param>
        /// <returns></returns>
        public int Update(object oEntity)
        {          
            dbContext.Entry(oEntity).State = EntityState.Modified;
            return this.SaveChanges();
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereExpression">Where表达式</param>
        /// <param name="updateExpression">数据更新表达式</param>
        /// <returns></returns>
        public int Update<T>(Expression<Func<T,bool>> whereExpression, Expression<Func<T,T>> updateExpression) where T :class
        {
            return dbContext.Set<T>().Where(whereExpression).Update(updateExpression);      
        }

        /// <summary>
        /// 原生sql更新
        /// </summary>
        /// <param name="sql">原生sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public int Update(string sql, params object[] parameters)
        {
            return ExecuteSqlCommand(sql, parameters);
        }
        #endregion

        #region Delete
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="oEntity">实体</param>
        /// <returns></returns>
        public int Delete(object oEntity)
        {
            this.dbContext.Entry(oEntity).State = EntityState.Deleted;
            return this.SaveChanges();
        }

        /// <summary>
        /// 原生sql删除
        /// </summary>
        /// <param name="sql">原生sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public int Delete(string sql, params object[] parameters)
        {
            return ExecuteSqlCommand(sql, parameters);
        }

        /// <summary>
        /// 批量删除(表达式)
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="predicate">条件表达式</param>
        /// <returns></returns>
        public int Delete<T>(Expression<Func<T, bool>> whereExpression) where T : class
        {
            return dbContext.Set<T>().Where(whereExpression).Delete();
        }
        #endregion

        #region Select
        #region Select List        
        /// <summary>
        /// 执行sql语句查询
        /// </summary>
        /// <typeparam name="T">返回什么实体</typeparam>
        /// <param name="commonText">sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public List<T> SelectList<T>(string commonText, List<SqlParameter> parameterst)
        {           
            var tempList = this.dbContext.Database.SqlQuery<T>(commonText, parameterst).ToList();           
            return tempList;           
        }


        /// <summary>
        /// 执行sql语句查询(带分页和总条数)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryInfo"></param>
        /// <returns></returns>
        public List<T> SelectList<T>(QueryInfoEnumerable<T> queryInfo) where T :class
        {
            var tempList = queryInfo.Select();           
            return tempList;
        }

        /// <summary>
        /// 获取DataTable(原生ADO.NET)
        /// </summary>
        /// <param name="commonText">sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public DataTable SelectDataTable(string commonText, params object[] parameters)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = dbContext.Database.Connection.ConnectionString;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = commonText;
            if (parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    cmd.Parameters.Add(item);
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tempData = new DataTable();
            adapter.Fill(tempData);
            return tempData;
        }

       
        /// <summary>
        /// 分页取数据(有指定字段排序)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="whereExpression"></param>
        /// <param name="order"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<T> SelectList<T>(QueryInfo<T> qInfo) where T : class
        {         
            return qInfo.SelectList();
        }
        #endregion

        #region Select One
        /// <summary>
        /// 执行sql语句查询
        /// </summary>
        /// <typeparam name="T">返回什么实体</typeparam>
        /// <param name="commonText">sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public T SelectOne<T>(string commonText,params SqlParameter [] parameterst)
        {

            var tempList = this.dbContext.Database.SqlQuery<T>(commonText, parameterst).First();
            return tempList;
        }        

        public T SelectOne<T>( QueryInfo<T> info=null) where T : class
        {
            if (info == null)
            {
                return dbContext.Set<T>().FirstOrDefault();
            }
            else
            {
                return info.SelectOne();
            }
        }
        #endregion

        #region Select One Column
        public T SelectOneColumn<T>(string commonText, params SqlParameter[] parameterst)
        {
            var tempList = this.dbContext.Database.SqlQuery<T>(commonText, parameterst).First();
            return tempList;
        }

        public List<T> SelectOneColumn<T>(QueryInfo<T> qInfo) where T :class
        {         
            return qInfo.SelectList();
        }
        #endregion
        #endregion

        #region 执行sql命令
        /// <summary>
        /// 执行sql命令
        /// </summary>
        /// <param name="commonText">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public int ExecuteSqlCommand(string commonText, params object[] parameters)
        {
            return dbContext.Database.ExecuteSqlCommand(commonText, parameters);
        }       
        #endregion


        public T GetByKey<T>(object key)where T :class
        {

            return this.dbContext.Set<T>().Find(key);
        }
        public IQueryable<T> GetEntities<T>() where T:class
        {

            return this.dbContext.Set<T>().AsQueryable();

        }
        

        public IQueryable<T> GetEntities<T>(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda) where T : class
        {
            try
            {
                return this.dbContext.Set<T>().Where<T>(whereLambda).AsQueryable();
            }
            catch (Exception ex)
            {
                // Log.Error(ex);
                throw ex;
            }
        }


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }



        
    }

    public interface ISimpleList
    {
        void Add(object element);
    }
}
