namespace ExamFinal.Advance;

public class ProductBuilder
{
    private Product pruduct;
    
    
    public ProductBuilder()
    {
        pruduct = new Product();
    }
    
    public ProductBuilder setName(string name)
    {
        pruduct.Name = name;
        return this;
    }
    public ProductBuilder setPrice(double price)
    {
        pruduct.Price = price;
        return this;
    }
    
    public Product Build()
    {
        return pruduct;
    }
}