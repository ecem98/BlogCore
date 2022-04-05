using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
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
    public class EfMessage2Repository : GenericRepository<Message2>,IMessage2Dal
    {
        public List<Message2> GetMessagessWithWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages2.Include(x=>x.SenderUser).Where(x=>x.ReciverID==id).ToList();
            }
        }


        public Message2 GetDetailWithWriter(int id)
        {
            Context c = new Context();
            var details = c.Messages2.Include(x => x.SenderUser).FirstOrDefault(x => x.MessageID == id);
            return details;

        }
    }
}
