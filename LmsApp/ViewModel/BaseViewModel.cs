using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class BaseViewModel <T> where T: Entity
    {

        public BaseViewModel(Entity entiry)
        {
            Id = entiry.Id;
            Created = entiry.Created;
            CreatedBy = entiry.CreatedBy;
            Modified = entiry.Modified;
            ModifiedBy = entiry.ModifiedBy;
        }
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
