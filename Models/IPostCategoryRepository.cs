using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class PostCategoryRepository : BlogRepositorybase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
    public interface IPostCategoryRepository : IBlogRepostitory<PostCategory>
    {
    }
}
