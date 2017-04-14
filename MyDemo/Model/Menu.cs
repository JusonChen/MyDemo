using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Menu")]
    [Serializable]
    public class Menu
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MenuID { get; set; }
        [Required,MaxLength(70),MinLength(5)]
        public string MenuName { get; set; }

        public int Level { get; set; }

        [MaxLength(50)]
        public string CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        [MaxLength(50)]
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
