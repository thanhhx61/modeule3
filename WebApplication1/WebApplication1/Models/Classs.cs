using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Classs
    {
        [Key]
        public int ClasssId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ClasssName { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
