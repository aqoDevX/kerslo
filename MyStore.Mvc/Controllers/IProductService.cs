namespace MyStore.Mvc.Controllers
{
    internal interface IProductService
    {
        void AddProduct(Product product);
        void DeleteProduct(int id);
        string? GetAllProducts();
        string? GetProductById(int id);
        void UpdateProduct(Product product);
    }
}