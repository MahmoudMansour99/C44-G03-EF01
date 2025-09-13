using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column("Bonus", TypeName = "decimal(12, 2)")]
        public decimal Bonus { get; set; }

        [Column("Salary", TypeName = "decimal(12, 2)")]
        public decimal Salary { get; set; }

        [Column("Address", TypeName = "varchar(50)")]
        public string? Address { get; set; }

        [Column("HourRate", TypeName = "decimal(12, 2)")]
        public decimal HourRate { get; set; }
        public int Dept_Id { get; set; }
    }
}
