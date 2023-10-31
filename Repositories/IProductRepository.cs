using BusinessObject.Models;

namespace Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductsList(bool order = false);
        Product GetProduct(int productId, IEnumerable<Product> searchList = null);
        Product GetProduct(string productName, IEnumerable<Product> searchList = null);
        int GetNextProductId();
        void AddProduct(Product product);
        void Update(Product product);
        void Delete(int productId);
        IEnumerable<Product> SearchProduct(string name, IEnumerable<Product> searchList);
        IEnumerable<Product> SearchProduct(int startUnit, int endUnit, IEnumerable<Product> searchList = null);
        IEnumerable<Product> SearchProduct(decimal startPrice, decimal endPrice, IEnumerable<Product> searchList = null);
    }
}
