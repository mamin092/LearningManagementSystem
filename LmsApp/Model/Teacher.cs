using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Teacher : Entiry
    {
        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}