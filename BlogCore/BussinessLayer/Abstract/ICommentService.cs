using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void Insert(Comment comment);
        //void Update(Comment comment);
        //void Delete(Comment comment);
        List<Comment > GetListAll(int id);
        //Comment  GetById(int id);
    }
}
