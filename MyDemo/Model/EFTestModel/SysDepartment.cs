using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Model
{
    [Table("SysDepartment")]
    public class SysDepartment
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDesc { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}