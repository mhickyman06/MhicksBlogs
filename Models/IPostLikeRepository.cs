using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class PostLikeRepository : BlogRepositorybase<PostLike>, IPostLikeRepository
    {
        public PostLikeRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
    public interface IPostLikeRepository : IBlogRepostitory<PostLike>
    {
    }
}
