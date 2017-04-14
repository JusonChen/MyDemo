using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("UserRoleMenu")]
    [Serializable]
    public class UserRoleMenu
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserRoleMenuID { get; set; }

        public Guid UserID { get; set; }

        public Guid RoleID { get; set; }

        public Guid MenuID { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        [MaxLength(50)]
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
