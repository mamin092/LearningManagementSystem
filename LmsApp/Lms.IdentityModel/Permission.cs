using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lms.IdentityModel
{
  public  class Permission : Entity
    {
        [Index]
        [MaxLength(128)]
        public string RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual ApplicationRole ApplicationRole { get; set; }

        [Index]
        [MaxLength(128)]
        public string ResourceId { get; set; }

        [ForeignKey("ResourceId")]
        public virtual Resource Resource { get; set; }

        public bool IsAllowed { get; set; }

        public bool IsDisabled { get; set; }
    }
}
