using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        MessageManager mm = new MessageManager(new EfMessageDal());



        public ActionResult Index()
        {
            
            var contactList = cm.GetList();
            return View(contactList);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            ViewBag.ContactCount = cm.GetList().Count;
            ViewBag.ReceiverCount = mm.GetListInbox().Count;
            ViewBag.SenderCount = mm.GetListSent().Count;
            ViewBag.DraftCount = mm.GetListDraft().Count;
            ViewBag.DeleteCount = mm.GetListDeleted().Count;
            return PartialView();
        }
    }
}
