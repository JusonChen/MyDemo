using Dao;
using Model;
using SIStudio.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemo_CS
{
    public partial class EF_DBFunction : Form
    {
        public EF_DBFunction()
        {
            InitializeComponent();
        }
        MyDemoCSDao myDemoCSDao = new MyDemoCSDao();
        EFHelper ef = new EFHelper();

        private void EF_DBFunction_Load(object sender, EventArgs e)
        {
            long tradeID = SIConvert.ToInt64("2299774997796446");

            string value = "Id：看吧看吧看吧就这样吧";
            string ss = "Id：";

            string nick_ColumnName = "账号";
            string nick = value.TrimStart(ss.ToCharArray());

            long to_oid = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);

            //TestFn2();
        }

        #region Insert
        private void BulkInsert_Click(object sender, EventArgs e)
        {
            List<SysUser> lsUser = new List<SysUser>();
            for (int i = 0; i < 10000; i++)
            {
                SysUser user = new SysUser();
                user.UserName = "czs" + i;
                user.Password = "abc" + i;
                user.CreateDate = DateTime.Now;
                lsUser.Add(user);
            }

            Stopwatch ws = new Stopwatch();
            ws.Start();
            var result = ef.Insert(lsUser);
            ws.Stop();
            MessageBox.Show(ws.ElapsedMilliseconds + "");

        }

        private void InsertT_Click(object sender, EventArgs e)
        {
            try
            {
                SysUser user = new SysUser();
                user.ID = 2;
                user.UserName = "czshaha";
                user.Password = "abc123";
                user.CreateDate = DateTime.Now;
                var result = ef.Insert(user);
            }
            catch (Exception ex)
            {

            }

        }

        private void InsertOutLastInsertID_Click(object sender, EventArgs e)
        {
            try
            {
                object sValue=null ;
               var rs= int.Parse(sValue!=null?sValue.ToString():"0");

                SysUser user = new SysUser();
                user.ID = 2;
                user.UserName = "czshaha";
                user.Password = "abc123";
                user.CreateDate = DateTime.Now;
                int outLastInsertID = 0;
                var result = ef.Insert(user,out outLastInsertID);
            }
            catch (Exception ex)
            {

            }
        }

        private void InsertBySql_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"Insert into SysUser (ID,LoginName,CreateDate) values (2,@LoginName,@CreateDate)";
                List<SqlParameter> spValues = new List<SqlParameter>();
                spValues.Add(new SqlParameter("@LoginName", "InsertSql"));
                spValues.Add(new SqlParameter("@CreateDate", DateTime.Now));
                var result = ef.Insert(sql, spValues.ToArray());
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Update
        private void UpdateList_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {


            }
        }

        private void UpdateT_Click(object sender, EventArgs e)
        {
            try
            {
                SysUser user = ef.GetByKey<SysUser>(2);
                user.CreateDate = DateTime.Now;
                var result = ef.Update(user);
            }
            catch (Exception ex)
            {

           
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update SysUser set CreateDate=@CreateDate,LoginName=@LoginName where ID=@ID";
                List<SqlParameter> spValues = new List<SqlParameter>();
                spValues.Add(new SqlParameter("@LoginName", "UpdateSql2"));
                spValues.Add(new SqlParameter("@CreateDate", DateTime.Now));
                spValues.Add(new SqlParameter("@ID", 2));
                var result = ef.Update(sql, spValues.ToArray());
            }
            catch (Exception ex)
            {

            }
        }


        private void btnUpdateExpression_Click(object sender, EventArgs e)
        {
            try
            {
              var result=  ef.Update<SysUser>(x => x.ID >= 2, x => new SysUser { CreateDate = DateTime.Now });
            }
            catch (Exception ex)
            {
               
            }
        }

        #endregion

        #region Delete
        private void DeleteList_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
              
            }
        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            try
            {
                SysUser user = ef.GetByKey<SysUser>(6);
                user.CreateDate = DateTime.Now;
                var result = ef.Delete(user);
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteBySql_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"delete from SysUser  where ID=@ID";
                List<SqlParameter> spValues = new List<SqlParameter>();
              
                spValues.Add(new SqlParameter("@ID", 5));
                var result = ef.Update(sql, spValues.ToArray());
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteExpression_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ef.Delete<SysUser>(x => x.ID == 3);
            }
            catch (Exception ex)
            {

            }
        }


        #endregion


        #region MyRegion
        private void SelectDataTable_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select b.UserName,c.RoleName,d.DepartmentName from [dbo].[SysUserRole] a
                            join [dbo].[SysUser] b
                            on a.SysUserID=b.ID
                            join [dbo].[SysRole] c
                            on a.SysRoleID=c.ID
                            join [dbo].[SysDepartment] d
                            on d.ID=b.SysDepartmentID
                            where b.UserName =@UserName";
                List<SqlParameter> spValues = new List<SqlParameter>();
                spValues.Add(new SqlParameter("@UserName", "czs"));
                DataTable tbData = myDemoCSDao.SelectDataTable(sql, spValues);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void Selectlist_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = @"select b.UserName,c.RoleName,d.DepartmentName from [dbo].[SysUserRole] a
                            join [dbo].[SysUser] b
                            on a.SysUserID=b.ID
                            join [dbo].[SysRole] c
                            on a.SysRoleID=c.ID
                            join [dbo].[SysDepartment] d
                            on d.ID=b.SysDepartmentID";
                List<SqlParameter> spValues = new List<SqlParameter>();
                spValues.Add(new SqlParameter("@czs", 1));             
                var totalCount = 0;
               var list= myDemoCSDao.Selectlist<QueryResultTest>(sql, spValues, 1, 10,out totalCount);

            }
            catch (Exception ex)
            {


            }

        }

        private void SelectListPage_Click(object sender, EventArgs e)
        {
            try
            {
                int totalCount = 0;              
                string sql = "";
                myDemoCSDao.SelectList<SysUser>(1, 10, out totalCount,out sql);
                //var sql = query.ToObjectQuery().ToTraceString();

            }
            catch (Exception ex)
            {               
             
            }
        }
        #endregion

    

   

       

        /// <summary>
        /// Select One
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            try
            {
                //1
                string sql = @"select b.UserName,c.RoleName,d.DepartmentName from [dbo].[SysUserRole] a
                            join[dbo].[SysUser] b
                           on a.SysUserID = b.ID
                            join[dbo].[SysRole] c
                           on a.SysRoleID = c.ID
                            join[dbo].[SysDepartment] d
                           on d.ID = b.SysDepartmentID";
               var data= ef.SelectOne<QueryResultTest>(sql);

                //2
               var data2= ef.SelectOne<SysUser>();

                //3
                QueryInfo<SysUser> info = new QueryInfo<SysUser>();
                var query = info.query.Where(x => x.ID > 1).OrderByDescending(x => x.CreateDate);
                var data3 = query.FirstOrDefault();
            }
            catch (Exception ex)
            {

              
            }
        }

        /// <summary>
        /// SelectOneColumn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectOneColumn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select b.UserName
                            from [dbo].[SysUserRole] a
                            join[dbo].[SysUser] b
                           on a.SysUserID = b.ID
                            join[dbo].[SysRole] c
                           on a.SysRoleID = c.ID
                            join[dbo].[SysDepartment] d
                           on d.ID = b.SysDepartmentID";
                var data = ef.SelectOne<string>(sql);

               

                //QueryInfo<SysUser> info2 = new QueryInfo<SysUser>();
                //info2.Select(x => x.UserName);
                //var data3 = ef.SelectOneColumn(info2);


                QueryInfo<SysUser> info = new QueryInfo<SysUser>();
                var query= info.query.Where(x => x.UserName.Contains("czs")).OrderBy(x => x.CreateDate).Select(x=>x.UserName);
                var data2 = query.ToList();           

            }
            catch (Exception ex)
            {

             
            }
        }
    }
}
