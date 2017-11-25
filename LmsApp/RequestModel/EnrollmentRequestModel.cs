using Model;
using System;
using System.Linq.Expressions;
using System.Linq;
using System.Data.Entity;

namespace RequestModel
{
    public class EnrollmentRequestModel : BaseRequestModel<Enrollment>
    {
        public override Expression<Func<Enrollment, bool>> GetExpression()
        {

            if (!string.IsNullOrWhiteSpace(Keyword))
            {

                this.ExpressionObject = x => x.Student.Name.Contains(Keyword) || x.Course.Title.Contains(Keyword);
            }

            this.ExpressionObject = this.ExpressionObject.And(this.GenerateBaseExpression());
            return this.ExpressionObject;
        }

        public override IQueryable<Enrollment> IncludeParents(IQueryable<Enrollment> queryable)
        {
            return queryable.Include(x => x.Student).Include(x=>x.Course) ;
        }
    }
}
