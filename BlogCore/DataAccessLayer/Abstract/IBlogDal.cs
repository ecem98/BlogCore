using EntityLayer.Concrete;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal :IGenericDal<Blog>
    {
        public List<Blog> GetBlogWithCategory();
        public List<Blog> GetTreeBlog(Expression<Func<Blog, bool>> filter);
        public List<Blog> GetBlogsWithCategoryLastTen();
        public List<Blog> GetWritersAllBlogs(Expression<Func<Blog, bool>> filter);
        public List<Blog> GetBlogsWithCategory(int id);
        public List<Blog> GetLastTreeBlogForAbout();
    }
}
