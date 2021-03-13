using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("project_backlog")]
    public class project_backlog
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("enduser",TypeName ="nvarchar")]
        [StringLength(200)]
        public string enduser { get; set; }

        [Column("requirement",TypeName ="nvarchar")]
        [StringLength(4000)]
        public string requirement { get; set; }

        [Column("requirement_description", TypeName = "nvarchar")]
        [StringLength(4000)]
        public string requirement_description { get; set; }

        [Column("priority", TypeName = "int")]
        public int priority { get; set; }

        [Column("statusID", TypeName = "int")]
        public int statusID { get; set; }

        [Column("sprint", TypeName = "int")]
        public int sprint { get; set; }

        [Column("projectID", TypeName = "int")]
        public int projectID { get; set; }

        [ForeignKey("projectID")]
        public project project { get; set; }
    
        [ForeignKey("statusID")]
        public status status { get; set; }

        public ICollection<project_task> project_tasks { get; set; }

    }
}
