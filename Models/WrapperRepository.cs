using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private BlogViewDbContext BlogViewDbContext;
        private ICommentLikesRepository CommentLikesRepository;
        private ICommentRepository CommentRepository;
        private ICtegoryReopository CtegoryReopository;
        private IImgRepository ImgRepository;
        private IPostCategoryRepository PostCategoryRepository;
        private IPostImgRepository PostImgRepository;
        private IPostLikeRepository PostLikeRepository;
        private IPostRepository postRepository;
        private IPostVideoRepository PostVideoRepository;
        private IReplyRepository replyRepository;
        private IReplyLike ReplyLikeRepository;
        
        public ICommentLikesRepository CommentLikes
        {
            get
            {
                if(CommentLikesRepository == null)
                {
                    CommentLikesRepository = new CommentLikesRepository(BlogViewDbContext);
                }
                return CommentLikesRepository;
            }
        }
        public ICommentRepository Comment
        {
            get
            {
                if (CommentRepository == null)
                {
                    CommentRepository = new CommentRepository(BlogViewDbContext);
                }
                return CommentRepository;
            }
        }
        public ICtegoryReopository Ctegory
        {
            get
            {
                if (CtegoryReopository == null)
                {
                    CtegoryReopository = new CategoryRepository(BlogViewDbContext);
                }
                return CtegoryReopository;
            }
        }
        public IImgRepository Img
        {
            get
            {
                if (ImgRepository == null)
                {
                    ImgRepository = new ImgRepository(BlogViewDbContext);
                }
                return ImgRepository;
            }
        }
        public IPostCategoryRepository PostCategory
        {
            get
            {
                if (PostCategoryRepository == null)
                {
                    PostCategoryRepository = new PostCategoryRepository(BlogViewDbContext);
                }
                return PostCategoryRepository;
            }
        }
        public IPostImgRepository PostImg
        {
            get
            {
                if (PostImgRepository == null)
                {
                    PostImgRepository = new PostImgRepository(BlogViewDbContext);
                }
                return PostImgRepository;
            }
        }
        public IPostLikeRepository PostLike
        {
            get
            {
                if (PostLikeRepository == null)
                {
                    PostLikeRepository = new PostLikeRepository(BlogViewDbContext);
                }
                return PostLikeRepository;
            }
        }
        public IPostRepository PostRepository
        {
            get
            {
                if (postRepository == null)
                {
                    postRepository = new PostRepository(BlogViewDbContext);
                }
                return postRepository;
            }
        }
        public IPostVideoRepository PostVideo
        {
            get
            {
                if (PostVideoRepository == null)
                {
                    PostVideoRepository = new PostVideoRepository(BlogViewDbContext);
                }
                return PostVideoRepository;
            }
        }
        public IReplyLike ReplyLike
        {
            get
            {
                if (ReplyLikeRepository == null)
                {
                    ReplyLikeRepository = new ReplyLikeRepository(BlogViewDbContext);
                }
                return ReplyLikeRepository;
            }
        }
        public IReplyRepository ReplyRepository
        {
            get
            {
                if (replyRepository == null)
                {
                    replyRepository = new ReplyRepository(BlogViewDbContext);
                }
                return replyRepository;
            }
        }

       
        public RepositoryWrapper(BlogViewDbContext blogViewDbContext)
        {
            BlogViewDbContext = blogViewDbContext;
        }

        public void Save()
        {
            BlogViewDbContext.SaveChanges();
        }
    }

}
