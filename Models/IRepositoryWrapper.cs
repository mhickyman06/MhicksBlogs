using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{

   public interface IRepositoryWrapper
    {
        ICommentLikesRepository CommentLikes {get;}
        ICommentRepository Comment{get;}
        ICtegoryReopository Ctegory{get;}
        IImgRepository Img{get;}
        IPostCategoryRepository PostCategory{get;}
        IPostImgRepository PostImg{get;}
        IPostLikeRepository PostLike{get;}
        IPostRepository PostRepository{get;}
        IPostVideoRepository PostVideo{get;}
        IReplyRepository ReplyRepository{get;}
        IReplyLike ReplyLike{get;}
        void Save();




    }
}
