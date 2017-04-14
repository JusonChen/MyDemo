using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DBContext:DbContext
    {
        public DBContext() 
            : base("EFTest")
        {

        }

        public DbSet<SysUser> SysUsers { get; set; }

        public DbSet<SysRole> SysRoles { get; set; }

        public DbSet<SysUserRole> SysUserRoles { get; set; }

        public DbSet<SysDepartment> SysDepartments { get; set; }

        public DataTable SelectDataTable(string commonText, params object[] parameters)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = this.Database.Connection.ConnectionString;
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
    }
}
