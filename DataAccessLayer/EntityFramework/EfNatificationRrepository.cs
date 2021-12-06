using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfNatificationRrepository : GenericRepository<Natification>, INatificationDal
    {
        public void Delete(Natification category)
        {
            throw new NotImplementedException();
        }

        public List<Natification> GetListAll(Expression<Func<Natification, bool>> filter)
        {
            using var c = new Context();
            return c.Natifications.ToList();
        }

        public List<Natification> GetListWithCategory()
        {
            throw new NotImplementedException();
        }

        public List<Natification> GetListWithCategoryByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Natification category)
        {
            throw new NotImplementedException();
        }

        public void Update(Natification category)
        {
            throw new NotImplementedException();
        }

        Natification IGenericDal<Natification>.GetById(int Id)
        {
            throw new NotImplementedException();
        }

        List<Natification> IGenericDal<Natification>.GetListAll()
        {
            using var c = new Context();
            return c.Natifications.ToList();
        }
    }
}
