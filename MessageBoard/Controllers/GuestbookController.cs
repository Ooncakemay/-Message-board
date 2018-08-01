using MessageBoard.Services;
using MessageBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageBoard.Controllers
{
    public class GuestbookController : Controller
    {
        GuestbooksDBService guestbookDBService = new GuestbooksDBService();
        // GET: Guestbook
        public ActionResult Index()
        {
            GuestbookView data = new GuestbookView();
            data.DataList = guestbookDBService.getDataList();
            
            return View(data);
        }
    }
}