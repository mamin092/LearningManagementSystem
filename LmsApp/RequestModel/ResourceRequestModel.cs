using Lms.IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RequestModel
{
    public class ResourceRequestModel : BaseRequestModel<Resource>
    {
        public override Expression<Func<Resource, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = r => r.Name.Contains(Keyword) || r.Type.Contains(Keyword);
            }

            return this.ExpressionObject;
        }
    }
}
