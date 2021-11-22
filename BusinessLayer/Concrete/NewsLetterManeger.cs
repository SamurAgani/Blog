using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManeger : INewsletterService
    {
        INewsLetterDal NewsLetterDal;

        public NewsLetterManeger(INewsLetterDal newsLetterDal)
        {
            NewsLetterDal = newsLetterDal;
        }

        public void AddNewsletter(NewsLetter newsLetter)
        {
            NewsLetterDal.Insert(newsLetter);
        }
    }
}
