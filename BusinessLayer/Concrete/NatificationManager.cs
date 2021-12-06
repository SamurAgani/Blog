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
    public class NatificationManager : INotificationService
    {
        INatificationDal natificationDal;
        public NatificationManager(INatificationDal _natificationDal)
        {
            natificationDal = _natificationDal;
        }
        public void Add(Natification t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Natification t)
        {
            throw new NotImplementedException();
        }

        public Natification GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Natification> GetList()
        {
            return natificationDal.GetListAll();
        }

        public void Update(Natification t)
        {
            throw new NotImplementedException();
        }
    }
}
