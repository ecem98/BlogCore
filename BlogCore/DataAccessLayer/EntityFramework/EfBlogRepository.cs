using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Linq.Expressions;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetBlogWithCategory()
        {
            using(var c=new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> GetTreeBlog(Expression<Func<Blog, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.Blogs.Where(filter).OrderByDescending(x => x.BlogID).Take(3).ToList(); 
            }
        }

        public List<Blog> GetWritersAllBlogs(Expression<Func<Blog, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(filter).ToList();
            }
        }

        public List<Blog> GetBlogsWithCategory(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.CategoryID== id).ToList();
            }
        }


        public List<Blog> GetLastTreeBlogForAbout()
        {
            using (var c = new Context())
            {
                return c.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            }
        }

        public List<Blog> GetBlogsWithCategoryLastTen()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).OrderByDescending(x=>x.BlogID).Take(10).ToList();
            }
        }

    }
}
