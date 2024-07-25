using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        
        // IReadOnlyList možemo samo  čitati listu, ne možemo brisati i uređivati
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetAllProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetAllProductTypesAsync();
    }
}