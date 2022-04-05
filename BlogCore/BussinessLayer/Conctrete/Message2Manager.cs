using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conctrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            this.message2Dal = message2Dal;
        }

        public Message2 GetDetailWithWriter(int id)
        {
            return message2Dal.GetDetailWithWriter(id);
        }

        public Message2 GetById(int id)
        {
            return message2Dal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return message2Dal.GetMessagessWithWriter(id);
        }

        public List<Message2> GetList()
        {
            return message2Dal.GetListAll();
        }

       

        public void TAdd(Message2 t)
        {
            message2Dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            message2Dal.Delete(t);
        }

        public void TUpdate(Message2 t)
        {
            message2Dal.Update(t);
        }
    }
}
