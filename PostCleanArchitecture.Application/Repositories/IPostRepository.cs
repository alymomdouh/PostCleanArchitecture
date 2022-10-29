using PostCleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostCleanArchitecture.Application.Repositories
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync(string includeProperties = "");
        Task<Post> GetPostByIdAsync(Guid id, string includeProperties = "");
    }
}
