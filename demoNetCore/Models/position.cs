using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("position")]
    public class position
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("name",TypeName ="nvarchar")]
        [StringLength(300)]
        public string name { get; set; }

        [Column("active",TypeName ="bit")]
        public bool active { get; set; }

        public ICollection<project_member> project_members { get; set; }
    }
}
