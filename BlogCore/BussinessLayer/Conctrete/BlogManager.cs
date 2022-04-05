using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conctrete
{
    public class BlogManager : IBLogService

    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

       

        public List<Blog> GetBlogsWithCategory()
        {
            return _blogDal.GetBlogWithCategory();
        }

        public List<Blog> GetBlogsWithFilter(int id)
        {
            return _blogDal.GetList(x=>x.BlogID==id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

      
       
        public List<Blog> GetCategoiesBlogs(int id)
        {
            return _blogDal.GetBlogsWithCategory(id);
        }

        public List<Blog> GetTreeBlogByWriter(int id)
        {
            //Yazara ait son üç blogu getirir.
            //return _blogDal.GetList(x => x.WriterID == id);
            return _blogDal.GetTreeBlog(x => x.WriterID == id);
        }

    
        public List<Blog> GetWritersAllBlogs(int id)
        {
            //return _blogDal.GetWritersAllBlogs(id);
            return _blogDal.GetWritersAllBlogs(x => x.WriterID == id);
        }

        public List<Blog> GetLastTreeBlogForAbout()
        {
            return _blogDal.GetLastTreeBlogForAbout();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetBlogsWithCategoryLastTen()
        {
            return _blogDal.GetBlogsWithCategoryLastTen() ;
        }
    }
}
