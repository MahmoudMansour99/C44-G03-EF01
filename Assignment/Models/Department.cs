using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }
        public int Ins_Id { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
