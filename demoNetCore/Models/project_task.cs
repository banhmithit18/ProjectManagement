using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("project_task")]
    public class project_task
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }
        
        [Column("taskcontent",TypeName ="nvarchar")]
        [StringLength(500)]
        public string taskcontent { get; set; }

        [Column("filepath",TypeName ="varchar")]
        [StringLength(300)]
        public string filepath { get; set; }
    
        [Column("backlogID",TypeName ="int")]
        public int backlogid { get; set; }

        [Column("priority",TypeName ="int")]
        public int priority { get; set; }

        [Column("statusID",TypeName ="int")]
        public int statusID { get; set; }

        [Column("comment",TypeName ="nvarchar")]
        [StringLength(4000)]
        public string comment { get; set; }

        [Column("sprint",TypeName ="int")]
        public int sprint { get; set; }

        [Column("startDate",TypeName ="date")]
        public DateTime startDate { get; set; }

        [Column("endDate",TypeName ="date")]
        public DateTime endDate { get; set; }

        [ForeignKey("backlogID")]
        public project_backlog Project_backlog { get; set; }

        [ForeignKey("statusID")]
        public status status { get; set; }
    }
}
