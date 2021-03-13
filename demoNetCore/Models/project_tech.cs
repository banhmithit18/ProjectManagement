using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("project_tech")]
    public class project_tech
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("project_content", TypeName = "nvarchar")]
        [StringLength(4000)]
        public string project_content { get; set; }
        
        [Column("projectID", TypeName = "int")]
        public int projectID { get; set; }

        [Column("empLead_ID", TypeName = "int")]
        public int empLead_ID { get; set; }

        [ForeignKey("projectID")]
        public project project { get; set; }

        [ForeignKey("empLead_ID")]
        public employee employee { get; set; }
    }
}
