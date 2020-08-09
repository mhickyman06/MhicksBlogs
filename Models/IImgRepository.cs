using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class ImgRepository : BlogRepositorybase<Img>, IImgRepository
    {
        public ImgRepository(BlogViewDbContext repository) : base(repository)
        {

        }
    }

    public interface IImgRepository : IBlogRepostitory<Img>
    {
    }
}
