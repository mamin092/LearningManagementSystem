using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : Entiry
    {

        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [Index]
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Index]
        [MaxLength(50)]
        public string Email { get; set; }

    }
}
