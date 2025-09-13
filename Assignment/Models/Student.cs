using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("FName", TypeName = "varchar(50)")]
        public string FName { get; set; }

        [Column("LName", TypeName = "varchar(50)")]
        public string? LName { get; set; }

        [Column("Address", TypeName = "varchar(100)")]
        public string Address { get; set; }

        [Range(5, 25)]
        public int Age { get; set; }
        public int Dept_Id { get; set; }

    }
}
