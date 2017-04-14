using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("User")]
    [Serializable]
    public class User
    {
        //如果主键是int类型，EF为默认设置为增长。但如果是GUID类型，则要显示的设置自增长(DatabaseGenerated(DatabaseGeneratedOption.Identity))。   
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserID { get; set; }
        //Required非空：如果是int,long,boolean等不可为空的类型，默认是不为空的，string可空，不指定Required非空，默认可为空
        [Required,MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        [MaxLength(50)]
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
