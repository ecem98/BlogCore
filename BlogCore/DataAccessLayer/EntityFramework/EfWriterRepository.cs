using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository:GenericRepository<Writer>,IWriterDal
    {
        public Writer CheckLogIn(Writer writer)
        {
            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword==writer.WriterPassword);
            return dataValue;

        }

        public Writer FetchWriterByMail(string mail)
        {
            Context c = new Context();
            var userInfo = c.Writers.FirstOrDefault(x=>x.WriterMail==mail);
            return userInfo;
        }
    }
}
