using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RequestModel
{
    public class TeacherRequestModel : BaseRequestModel<Teacher>
    {

        public override Expression<Func<Teacher, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {
                this.ExpressionObject = x => x.Name.Contains(this.Keyword) || x.Email.Contains(this.Keyword);
            }
            this.ExpressionObject = ExpressionObject.And(this.GenerateBaseExpression());

            return this.ExpressionObject;
        }
    }
}
