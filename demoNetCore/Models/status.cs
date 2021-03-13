using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("status")]
    public class status
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("name",TypeName ="nvarchar")]
        [StringLength(200)]
        public string name { get; set; }

        [Column("active",TypeName ="bit")]
        public bool active { get; set; }

        [Column("groupID",TypeName ="int")]
        public int groupID { get; set; }

        [Column("priority", TypeName = "int")]
        public int priority { get; set; }

        public ICollection<project> projects { get; set; }
        public ICollection<project_backlog> project_backlogs { get; set; }
        public ICollection<project_task> project_tasks { get; set; }
        [ForeignKey("groupID")]
        public group group { get; set; }



    }
}
