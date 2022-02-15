using System.Linq.Expressions;

namespace ConsoleApp1;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public int InStock { get; set; }
    public bool IsForSale { get; set; }

    public static readonly Expression<Func<Product, bool>> IsAvailableExp = x => x.IsForSale && x.InStock > 0;
    public bool IsAvailable => IsAvailableExp.Compile()(this);
}