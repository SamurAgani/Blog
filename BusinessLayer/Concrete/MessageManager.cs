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
    public class MessageManager : IMessageService
    {
        IMessageDal messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            this.messageDal = messageDal;
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int Id)
        {
            throw new NotImplementedException();
        }



        public List<Message> GetList()
        {
            return messageDal.GetListAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return messageDal.GetListAll(x=>x.Receiver == p);
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
