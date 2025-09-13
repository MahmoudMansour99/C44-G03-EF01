using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public int Duration { get; set; }

        [Required]
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column("Description", TypeName = "varchar(100)")]
        public string? Description { get; set; }
        public int Top_Id { get; set; }
    }
}
