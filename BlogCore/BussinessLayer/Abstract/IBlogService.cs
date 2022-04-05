using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBLogService: IGenericService<Blog>
    {

        List<Blog> GetBlogsWithCategory(); //Blogları kategori alanlarını da kapsayacak şekilde getirir.
        List<Blog> GetBlogsWithCategoryLastTen();//Son 10 blogu kategori alanlarını da kapsayacak şekilde getirir.
        List<Blog> GetBlogsWithFilter(int id);
        List<Blog> GetCategoiesBlogs(int id);//Blogları kategoisine göre getirir.

        List<Blog> GetTreeBlogByWriter (int id);//Yazarın son üç blogunu getirir.

        List<Blog> GetWritersAllBlogs(int id);//Yazara göre blog listesi ama kategori alanları ile.

        List<Blog> GetLastTreeBlogForAbout();//Son eklenen üç blogu getirir.
    }
}
