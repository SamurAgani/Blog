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
    public class BlogManeger : IBlogService
    {
        IBlogDal blogDal;

        public BlogManeger(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }

        public Blog GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return blogDal.GetListAll();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
