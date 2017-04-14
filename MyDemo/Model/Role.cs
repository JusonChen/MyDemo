using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Role")]
    [Serializable]
    public class Role
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleID { get; set; }
        [Required,MaxLength(100)]
        public string RoleName { get; set; }
        [MaxLength(50)]
        public string CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        [MaxLength(50)]
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
