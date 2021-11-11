using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public Context Context { get; set; }

        public GenericRepository()
        {
            Context = new Context();
        }

        public void Delete(T t)
        {
            Context.Remove(t);
            Context.SaveChanges();
        }

        public T GetById(int Id)
        {
            return Context.Set<T>().Find(Id);
        }

        public List<T> GetListAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            Context.Add(t);
            Context.SaveChanges();
        }

        public void Update(T t)
        {
            Context.Update(t);
            Context.SaveChanges();
        }
    }
}
