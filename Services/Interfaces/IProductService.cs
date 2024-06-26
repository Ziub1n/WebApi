using System.Threading.Tasks;

public interface IProductService
{
    Task<int> CreateProductAsync(ProductDto productDto);
    Task<Product> GetProductByIdAsync(int id);
}