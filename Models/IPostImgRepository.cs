using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class PostImgRepository : BlogRepositorybase<PostImg>, IPostImgRepository
    {
        public PostImgRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
   public interface IPostImgRepository: IBlogRepostitory<PostImg>
    {
    }
}
