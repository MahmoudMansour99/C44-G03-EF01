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
    [PrimaryKey(nameof(Stud_Id), nameof(Course_Id))]
    internal class StudCourse
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }
    }
}
