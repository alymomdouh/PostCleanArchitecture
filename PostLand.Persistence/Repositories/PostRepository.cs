using Microsoft.EntityFrameworkCore;
using PostCleanArchitecture.Application.Repositories;
using PostCleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostLand.Persistence.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(PostDbContext postDbContext) : base(postDbContext)
        {

        }
        public async Task<IReadOnlyList<Post>> GetAllPostsAsync(string includeProperties)
        {
            IQueryable<Post> query = _dbContext.Set<Post>();
            query = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            var result = await query.ToListAsync();
            return result;
        }

        public async Task<Post> GetPostByIdAsync(Guid id, string includeProperties)
        {
            IQueryable<Post> query = _dbContext.Set<Post>();
            query = query.Where(c => c.Id == id);
            query = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            var result = await query.FirstOrDefaultAsync();
            return result;
        }
    }
}
