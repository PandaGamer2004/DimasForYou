using System.Linq.Expressions;

namespace ConsoleApp1;


public class ParametrRebinder : ExpressionVisitor
{
    private Dictionary<ParameterExpression, ParameterExpression>
        _parameterMappings;


    public ParametrRebinder(Dictionary<ParameterExpression, ParameterExpression> parameterMappings)
    {
        _parameterMappings = parameterMappings;
    }
    
    public Expression ReplaceParams(Expression expressionBody)
    {
        var resultExpression = this.Visit(expressionBody);
        return resultExpression;
    }
    protected override Expression VisitParameter(ParameterExpression node)
    {
        if (_parameterMappings.TryGetValue(node, out var mapped))
        {
            node =  mapped;
        }

        return base.VisitParameter(node);
    }

    
}