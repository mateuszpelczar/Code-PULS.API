using CodePuls.API.Models.Domain;

namespace CodePuls.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
