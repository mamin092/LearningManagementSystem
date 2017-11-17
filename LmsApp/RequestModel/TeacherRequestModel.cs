using Model;
using System;
using System.Linq.Expressions;

namespace RequestModel
{
    public class TeacherRequestModel : BaseRequestModel<Teacher>
    {
       
        public override Expression<Func<Teacher,bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {

                this.ExpressionObject = x => x.Name.Contains(this.Keyword);

            }
            return this.ExpressionObject;
        }
    

    }
}   