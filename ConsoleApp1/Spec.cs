using System.Linq.Expressions;

namespace ConsoleApp1;

public class Spec<T> where T : class
{
    /*
    private Expression<Func<T, bool>> _expression;

    public Spec(Expression<Func<T, bool>> given)
    {
        _expression = given;
    }


    public Func<T, bool> IsSatisfiedBy => _expression.Compile();
    
    public static bool operator false(Spec<T> spec) => false;

    public static bool operator true(Spec<T> spec) => false;
    

    public static Spec<T> operator &(Spec<T> spec1, Spec<T> spec2)
        => new Spec<T>(spec1._expression.And(spec2._expression));
    
    public static Spec<T> operator |(Spec<T> spec1, Spec<T> spec2)
        => new Spec<T>(spec1._expression.Or(spec2._expression));

    public static Spec<T> operator !(Spec<T> spec1, Spec<T> spec2)
        => new Spec<T>(spec1._expression.Not(spec2._expression));


    public static implicit operator Expression<Func<T, bool>>(Spec<T> spec)
        => spec._expression;
    
    public static implicit operator Func<T, bool>(Spec<T> spec)
        => spec.IsSatisfiedBy;
        */
}