using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class ReplyLikeRepository : BlogRepositorybase<Replylike>, IReplyLike
    {
        public ReplyLikeRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
    public interface IReplyLike : IBlogRepostitory<Replylike>
    {
    }
}
