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
    public class CommentManeger : ICommentService
    {
        ICommentDal commentdal;

        public CommentManeger(ICommentDal comment)
        {
            this.commentdal = comment;
        }

        public void AddComment(Comment Comment)
        {
            commentdal.Insert(Comment);
        }

        public void DeleteComment(Comment Comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int Id)
        {
            return commentdal.GetListAll(x => x.BlogID == Id);
        }

        public void UpdateComment(Comment Comment)
        {
            throw new NotImplementedException();
        }
    }
}
