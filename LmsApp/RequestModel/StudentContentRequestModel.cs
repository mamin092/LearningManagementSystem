using System;
using System.Linq.Expressions;
using Model;

using System.Data.Entity;
using System.Linq;

namespace RequestModel
{
    public class StudentContentRequestModel : BaseRequestModel<StudentContent>
    {
        public override Expression<Func<StudentContent, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword)) 
            {

                this.ExpressionObject = x => x.Student.Name.Contains(Keyword) || x.Content.Title.Contains(Keyword);
            }
            this.ExpressionObject = this.ExpressionObject.And(this.GenerateBaseExpression());
            return this.ExpressionObject;
        }

        public override IQueryable<StudentContent> IncludeParents(IQueryable<StudentContent> queryable)
        {
            return queryable.Include(x => x.Student).Include(x => x.Content);
        }

    }
}
