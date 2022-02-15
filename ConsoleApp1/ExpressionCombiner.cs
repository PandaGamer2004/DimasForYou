using System.Linq.Expressions;

namespace ConsoleApp1;

public static class ExpressionCombiner
{
    public static Expression<T> Compose<T>(this Expression<T> firstExpression, Expression<T> secondExpression,
        Func<Expression, Expression, Expression> merge)
    {
        var map = firstExpression.Parameters
            .Select((f, i) => new {firstExprParam = f, secondExprParam = secondExpression.Parameters[i]})
            .ToDictionary(pair => pair.secondExprParam, pair => pair.firstExprParam);

        var secondBody = new ParametrRebinder(map).ReplaceParams(secondExpression.Body);

        return Expression.Lambda<T>(merge(firstExpression.Body, secondBody), firstExpression.Parameters);
    }
}