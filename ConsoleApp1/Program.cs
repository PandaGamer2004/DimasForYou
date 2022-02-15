

using System.Linq.Expressions;
using ConsoleApp1;


Expression<Func<int, bool>> firsExpr1 = num => num > 2;
Expression<Func<int, bool>> secondExpr = num => num > 3;

var resultExpression = firsExpr1.Compose(secondExpr, Expression.AndAlso);

var compiledPredicate = resultExpression.Compile();

var res = compiledPredicate(2);

Console.WriteLine(res);