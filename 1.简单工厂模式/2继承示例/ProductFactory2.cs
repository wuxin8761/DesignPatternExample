namespace 简单工厂模式._2继承;

public class ProductFactory2
{
    public Product CreateProduct(string type)
    {
        switch (type.ToLower())
        {
            case "c":
                return new ProductC();
            case "d":
                return new ProductD();
            default:
                throw new ArgumentException("Invalid product type.");
        }
    }
}