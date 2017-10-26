using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Entiry
    {
        public string Id { get; set; }

        [Index]
        [Required]
        public DateTime Created { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Index]
        [Required]
        public DateTime Modified { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string ModifiedBy { get; set; }

    }
}