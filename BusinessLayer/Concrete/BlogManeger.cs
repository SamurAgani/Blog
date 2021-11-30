using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManeger : IBlogService
    {
        IBlogDal blogDal;

        public BlogManeger(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }


        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return blogDal.GetListWithCategoryByWriter(id);
        }
        public Blog GetById(int Id)
        {
            return blogDal.GetById(Id);
        }

        public List<Blog> GetBlogById(int Id)
        {
            return blogDal.GetListAll(x => x.BlogID == Id);
        }
        public List<Blog> GetList()
        {
            return blogDal.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            return blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int Id)
        {
            return blogDal.GetListAll(x => x.WriterID == Id);
        }

        public void Add(Blog t)
        {
            blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            blogDal.Delete(t);
        }

        public void Update(Blog t)
        {
            blogDal.Update(t);
        }
    }
}
