using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Model
{
    [Table("SysUserRole")]
    public class SysUserRole
    {
        public int ID { get; set; }
        public int SysUserID { get; set; }
        public int SysRoleID { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}