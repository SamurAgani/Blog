using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public Context Context { get; set; }

        public BlogRepository()
        {
            Context = new Context();
        }

        public void AddBlog(Blog Blog)
        {
            Context.Add(Blog);
            Context.SaveChanges();
        }

        public void DeleteBlog(Blog Blog)
        {
            Context.Remove(Blog);
            Context.SaveChanges();
        }

        public Blog GetById(int Id)
        {
            return Context.Blogs.Find(Id);
        }

        public List<Blog> ListAllCategory()
        {
            return Context.Blogs.ToList();
        }

        public void UpdateBlog(Blog Blog)
        {
            Context.Update(Blog);
            Context.SaveChanges();
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog category)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog category)
        {
            throw new NotImplementedException();
        }
    }
}
