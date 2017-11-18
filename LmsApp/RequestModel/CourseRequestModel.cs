using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace RequestModel
{
    public class CourseRequestModel : BaseRequestModel<Course>
    {
        public override Expression<Func<Course, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x => x.Title.Contains(Keyword) || x.Tags.Contains(Keyword);

            }

            //Expression<Func<Course, bool>> baseExpression = this.GenerateBaseExpression();
            //ExpressionObject = ExpressionObject.And(baseExpression);
            this.ExpressionObject = this.ExpressionObject.And(this.GenerateBaseExpression());
            return this.ExpressionObject;

        }
    }
}
