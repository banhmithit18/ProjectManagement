using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("project_member")]
    public class project_member
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }
        
        [Column("projectID",TypeName ="int")]
        public int projectID { get; set; }

        [Column("empID",TypeName ="int")]
        public int empID { get; set; }
    
        [Column("positionID",TypeName ="int")]
        public int positionID { get; set; }

        [ForeignKey("projectID")]
        public project project { get; set; }

        [ForeignKey("empID")]
        public employee employee { get; set; }

        [ForeignKey("positionID")]
        public position position { get; set; }

    }
}
