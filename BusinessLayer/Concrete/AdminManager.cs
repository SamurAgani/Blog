﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDAl;

        public AdminManager(IAdminDal adminDAl)
        {
            _adminDAl = adminDAl;
        }

        public void Add(Admin t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Admin t)
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
