using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
      //  List<Message> GetListInbox();
        List<Message> GetListSent();
       
        List<Message> GetListDraft();

  
        void DraftMessageAdd(Message message);
        void MessageAdd(Message message);
        Message GetByID(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
