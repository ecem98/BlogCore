using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2Dal:IGenericDal<Message2>
    {
        public List<Message2> GetMessagessWithWriter(int id); //Mesajları kullanıcı adları ile getirir.
        public Message2 GetDetailWithWriter(int id);//Mesaj detayını kullanıcı adıyla getirir
    }
}
