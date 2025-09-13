using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    // PrimaryKey 
    [PrimaryKey(nameof(Ins_Id), nameof(Course_Id))]
    internal class Course_Inst
    {
        public int Ins_Id { get; set; }
        public int Course_Id { get; set; }

        [Column("Evaluate", TypeName = "varchar(20)")]
        public string? Evaluate { get; set; }
    }
}
