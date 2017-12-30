﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RequestModel
{
    using System.Data.Entity;
    public class CourseRequestModel : BaseRequestModel<Course>
    {
        public override Expression<Func<Course, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Title.Contains(Keyword) || x.Tags.Contains(Keyword)||
                    x.Teacher.Name.Contains(Keyword);
            }

            this.ExpressionObject = this.ExpressionObject.And(this.GenerateBaseExpression());
            return this.ExpressionObject;
        }

        public override IQueryable<Course> IncludeParents(IQueryable<Course> queryable)
        {
            return queryable.Include(x => x.Teacher);

        }
    }
}
