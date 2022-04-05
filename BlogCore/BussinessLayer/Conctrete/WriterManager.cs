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
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public Writer CheckLogIn(Writer writer)
        {
            return writerDal.CheckLogIn(writer);
        }

        public Writer FetchWriterByMail(string mail)
        {
            return writerDal.FetchWriterByMail(mail);
        }

        public Writer GetById(int id)
        {
            return writerDal.GetById(id);
        }

        public List<Writer> GetList()
        {
            return writerDal.GetListAll();
        }

        public List<Writer> GetWriterById(int id)
        {
            return writerDal.GetList(x=>x.WriterID==id);
        }

    

        public void TAdd(Writer t)
        {
            writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            writerDal.Delete(t);
        }

        public void TUpdate(Writer t)
        {
            writerDal.Update(t);
        }

       
    }
}
