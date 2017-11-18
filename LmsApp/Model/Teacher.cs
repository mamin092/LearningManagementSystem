using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

 
    public class Teacher : Entity
    {
        [Index]        [Required]        [MaxLength(50)]        public string Name { get; set; }        [Index]        [Required]        [MaxLength(50)]        public string Email { get; set; }        [Index]        [Required]        [MaxLength(20)]        public string Contact { get; set; }        [Required]        [MaxLength(100)]        public string Address { get; set; }        [Index]        [Required]        [MaxLength(100)]        public string Designation { get; set; }        [MaxLength(500)]        public string Details { get; set; }
        [Index]        [MaxLength(500)]        public string Image { get; set; }        public virtual ICollection<Course> Courses { get; set; }
    }
}