﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Delete(Comment category)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment category)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment category)
        {
            throw new NotImplementedException();
        }
    }
}
