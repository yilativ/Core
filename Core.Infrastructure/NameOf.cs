#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
#endregion Using Directives

namespace Core.Infrastructure
{
    public class NameOf<T>
    {
        public static string Property<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            var body = expression.Body as MemberExpression;
            return body.Member.Name;
        }
    }
}
