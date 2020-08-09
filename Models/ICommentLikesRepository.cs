using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class CommentLikesRepository : BlogRepositorybase<Commentlikes>, ICommentLikesRepository
    {
        public CommentLikesRepository(BlogViewDbContext repository) : base(repository)
        {

        }

        public void SpecialUpdate(Commentlikes commentlikes)
        {
            throw new NotImplementedException();
        }
    }
    public interface ICommentLikesRepository : IBlogRepostitory<Commentlikes>
    {
        void SpecialUpdate(Commentlikes commentlikes);
    }
}
