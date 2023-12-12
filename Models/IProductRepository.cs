namespace DapperRepositoryPattern.Models
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(string productId);
    }
}
