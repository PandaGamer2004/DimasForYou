using System.Linq.Expressions;

namespace ConsoleApp1;

public class ReplaceConstantVisitor : ExpressionVisitor
{
    private readonly Int32 constant;
    
    public ReplaceConstantVisitor(int constant)
    {
        this.constant = constant;
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
        if (node.Value is Int32 val )
        {
            return Expression.Constant(val * constant);
        }
        return base.VisitConstant(node);
    }
}