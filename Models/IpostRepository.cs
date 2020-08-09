using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class PostRepository : BlogRepositorybase<Post>, IPostRepository
    {
        public PostRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
  public  interface IPostRepository : IBlogRepostitory<Post>
    {
    }
}
