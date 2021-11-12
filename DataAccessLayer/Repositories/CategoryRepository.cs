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
    public class CategoryRepository : ICategoryDal
    {
        public Context Context { get; set; }

        public CategoryRepository()
        {
            Context = new Context();
        }

        public void AddCategory(Category category)
        {
            Context.Add(category);
            Context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            Context.Remove(category);
            Context.SaveChanges();
        }

        public Category GetById(int Id)
        {
            return Context.Categories.Find(Id);
        }

        public List<Category> ListAllCategory()
        {
            return Context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            Context.Update(category);
            Context.SaveChanges();
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
