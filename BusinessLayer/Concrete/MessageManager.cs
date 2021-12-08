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
        IMessageDal MessageDal;

        public MessageManager(IMessageDal MessageDal)
        {
            this.MessageDal = MessageDal;
        }

        public void Add(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetList()
        {
            return MessageDal.GetListAll();
        }

        public List<Message2> GetInboxListByWriter(int p)
        {
            return MessageDal.GetListAll(x=>x.ReceiverId == p);
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
