using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestModel
{
    public class BaseRequestModel
    {
        public BaseRequestModel()
        {
            PerPageCount = 10;
            Page = 1;
        }
        public int Page { get; set; }
        public int PerPageCount { get; set; }
        public string OrderBy { get; set; }
        public bool IsAscending { get; set; }
    }
}
