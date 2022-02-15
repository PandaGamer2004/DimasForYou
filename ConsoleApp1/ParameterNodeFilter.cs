using System.Linq.Expressions;

namespace ConsoleApp1;

public class ParameterNodeFilter : ExpressionVisitor
{
    public override Expression? Visit(Expression? node)
    {
        if (node.NodeType is ExpressionType.Parameter)
        {
            Console.WriteLine(node);
        }
        return base.Visit(node);
    }
}