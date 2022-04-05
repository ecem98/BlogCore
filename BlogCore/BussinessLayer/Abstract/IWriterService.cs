using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService: IGenericService<Writer>
    {
       
        public Writer FetchWriterByMail(String mail);//Giriş yapan kullanıcı bilgilerini getirir
        public Writer CheckLogIn(Writer writer);
        public List<Writer> GetWriterById(int id);
        

    }
}
