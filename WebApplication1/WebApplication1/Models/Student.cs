using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(40)]
        public string StudentName { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Classs classs { get; set; }
    }
}
