using System.Linq.Expressions;

namespace ConsoleApp1;

public class OrderingMethodFInder : ExpressionVisitor
{
    public bool OrderingMethodFound { get; set; }
    

    protected override Expression VisitMethodCall(MethodCallExpression node)
    {
        var name = node.Method.Name;

        if (node.Method.DeclaringType == typeof(Queryable) &&
            (name.StartsWith("OrderBy", StringComparison.Ordinal)
             || name.StartsWith("ThenBy", StringComparison.Ordinal)))
        {
            OrderingMethodFound = true;
        }


        return base.VisitMethodCall(node);
    }
}