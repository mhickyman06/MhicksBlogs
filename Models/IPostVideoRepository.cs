using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class PostVideoRepository : BlogRepositorybase<PostVideo>, IPostVideoRepository
    {
        public PostVideoRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
    public interface IPostVideoRepository : IBlogRepostitory<PostVideo>
    {
    }
}
