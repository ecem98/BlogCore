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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            this.newsLetterDal = newsLetterDal;
        }

        public void Insert(NewsLetter newsLetter)
        {
           newsLetterDal.Insert(newsLetter);
        }
    }
}
