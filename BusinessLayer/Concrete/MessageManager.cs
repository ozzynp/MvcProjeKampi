using BusinessLayer.Abstarct;

using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com" );
        }

        public List<Message> GetListSent()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com" && x.IsSent == true);
        }
        public List<Message> GetListDraft()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com" && x.IsSent == false);
        }
        public List<Message> GetListDeleted()
        {
            return _messageDal.List(x => x.IsDeleted == true && x.IsSent == true);
        }


        public void MessageAdd(Message message)
        {
           
            _messageDal.Insert(message);
        }

        public void DraftMessageAdd(Message message)
        {
            message.IsSent = false;
            _messageDal.Insert(message);
        }
        public Message GetByID(int id)
        {
           return  _messageDal.Get(x=>x.MessageID== id);
        }

        public void MessageDelete(Message message)
        {
            _messageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageDal.Update(message);
        }

        
    }
}
