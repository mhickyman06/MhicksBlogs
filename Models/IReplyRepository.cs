using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class ReplyRepository : BlogRepositorybase<Reply>, IReplyRepository
    {
        public ReplyRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }
    public interface IReplyRepository : IBlogRepostitory<Reply>
    {
    }
}
