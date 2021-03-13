using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("project")]
    public class project
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("name",TypeName ="nvarchar")]
        [StringLength(200)]
        public string name { get; set; }

        [Column("description", TypeName = "nvarchar")]
        [StringLength(4000)]
        public string description { get; set; }

        [Column("filepath", TypeName = "varchar")]
        [StringLength(300)]
        public string filepath { get; set; }

        [Column("statusID", TypeName = "int")]
        public int statusID { get; set; }

        [ForeignKey("statusID")]
        public status status { get; set; }

        public ICollection<project_backlog> project_backlogs { get; set; }
        public ICollection<project_tech> project_techs { get; set; }
        public ICollection<project_member> project_members { get; set; }



    }
}
