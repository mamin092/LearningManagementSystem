using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

using System.Data.Entity;
namespace RequestModel
{
    public class ContentRequestModel : BaseRequestModel<Content>
    {
        public override Expression<Func<Content, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {

                this.ExpressionObject = x => x.Title.Contains(Keyword) || x.Tags.Contains(Keyword) || x.Course.Id.Equals(Keyword);
            }

            this.ExpressionObject = this.ExpressionObject.And(this.GenerateBaseExpression());

            return this.ExpressionObject;
        }

        public override IQueryable<Content> IncludeParents(IQueryable<Content> queryable)
        {
            return queryable.Include(x=>x.Course);
        }
    }
}
