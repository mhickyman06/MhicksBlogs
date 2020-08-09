using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class CommentRepository : BlogRepositorybase<Comment>,ICommentRepository
    {
        public CommentRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }

    public interface ICommentRepository : IBlogRepostitory<Comment>
    {

    }
}
