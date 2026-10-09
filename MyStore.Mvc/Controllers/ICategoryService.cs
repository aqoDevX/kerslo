namespace MyStore.Mvc.Controllers
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        string? GetAllCategories();
        string? GetCategoryById(int id);
        void UpdateCategory(Category category);
    }
}