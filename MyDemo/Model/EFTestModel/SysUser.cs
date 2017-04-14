using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("SysUser")]
    public class SysUser
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "用户名")]        
        [StringLength(50, MinimumLength = 1, ErrorMessage = "名字在1和10个字之间")]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }

        public int? SysDepartmentID { get; set; }

        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
       
        public virtual SysDepartment SysDepartment { get; set; }
    }
}
