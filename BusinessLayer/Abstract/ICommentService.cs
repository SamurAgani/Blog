using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {

        void AddComment(Comment Comment);
        void DeleteComment(Comment Comment);
        void UpdateComment(Comment Comment);
        List<Comment> GetList(int Id);
        Comment GetById(int Id);
    }
}
