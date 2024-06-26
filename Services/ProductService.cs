using System.Threading.Tasks;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> CreateProductAsync(ProductDto productDto)
    {
        var product = new Product
        {
            Name = productDto.ProductName,
            Weight = productDto.ProductWeight,
            Width = productDto.ProductWidth,
            Height = productDto.ProductHeight,
            Depth = productDto.ProductDepth,
        };

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        foreach (var categoryId in productDto.ProductCategories)
        {
            var productCategory = new ProductCategory
            {
                ProductId = product.ProductId,
                CategoryId = categoryId
            };
            _context.ProductCategories.Add(productCategory);
        }

        await _context.SaveChangesAsync();

        return product.ProductId;
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }
}