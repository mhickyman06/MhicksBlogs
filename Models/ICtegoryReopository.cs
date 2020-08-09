using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class CategoryRepository : BlogRepositorybase<Category>, ICtegoryReopository
    {
        public CategoryRepository(BlogViewDbContext repository) : base(repository)
        {
        }
    }

    public interface ICtegoryReopository : IBlogRepostitory<Category>
    {

    }
}
