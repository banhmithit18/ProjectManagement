using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    [Table("group")]
    public class group
    {
        [Key]
        [Column("id",TypeName ="int")]
        public int id { get; set; }

        [Column("name",TypeName ="nvarchar")]
        [StringLength(200)]
        public string name { get; set; }

        [Column("active",TypeName ="bit")]
        public bool active { get; set; }

        public ICollection<status> status { get; set; }
    }
}
