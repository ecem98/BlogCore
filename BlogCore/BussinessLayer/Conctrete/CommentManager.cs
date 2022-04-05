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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            this._commentDal = commentDal;
        }

        public List<Comment> GetListAll(int id)
        {
            return _commentDal.GetList(x=>x.BlogID==id);
        }

        public void Insert(Comment comment)
        {
            _commentDal.Insert(comment);
        }


        

    }
}
