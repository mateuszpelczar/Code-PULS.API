using CodePuls.API.Models.Domain;

namespace CodePuls.API.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);

        Task<IEnumerable<BlogPost>>GetAllAsync();
    }
}
