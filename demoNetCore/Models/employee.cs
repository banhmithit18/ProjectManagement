using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("employee")]
    public class employee
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("name", TypeName = "nvarchar")]
        [StringLength(100)]
        public string name { get; set; }
        
        [Column("nickname", TypeName = "nvarchar")]
        [StringLength(50)]
        public string nickname { get; set; }

        [Column("skill", TypeName = "nvarchar")]
        [StringLength(100)]
        public string skill { get; set; }

        [Column("username", TypeName = "varchar")]
        [StringLength(200)]
        public string username { get; set; }

        [Column("password", TypeName = "varchar")]
        [StringLength(200)]
        public string password { get; set; }

        public ICollection<project_member> project_members { get; set; }
        public ICollection<project_tech> project_techs { get; set; }

    }

}
