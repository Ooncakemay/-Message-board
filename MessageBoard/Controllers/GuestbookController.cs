using MessageBoard.Models;
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
            data.DataList = guestbookDBService.GetDataList();

            return View(data);
        }
        public ActionResult Create() {
            return PartialView();
        }
        [HttpPost] // 
        public ActionResult Add([Bind(Include ="Name,Content")] Guestbooks data) {
            guestbookDBService.InsertGuestbooks(data);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id) {
            /// 檢查? 
            Guestbooks Data = guestbookDBService.getDataById(Id);
            return View(Data);
        }
        [HttpPost]
        public ActionResult Edit(int Id, [Bind(Include = "Name,Content")] Guestbooks UpdateData) {
            if (guestbookDBService.CheckUpdate(Id))
            {
                UpdateData.Id = Id;
                guestbookDBService.UpdateGuestbooks(UpdateData);
                return RedirectToAction("Index"); //問google跳轉
            }
            else
            {
                return RedirectToAction("Index"); //問google跳轉
            }
        }
        public ActionResult Reply(int Id)
        {
            /// 檢查? 
            Guestbooks Data = guestbookDBService.getDataById(Id);
            return View(Data);
        }
        [HttpPost]
        public ActionResult Reply(int Id, [Bind(Include = "Reply,ReplyTime")] Guestbooks ReplyData)
        {
            if (guestbookDBService.CheckUpdate(Id))
            {
                ReplyData.Id = Id;
                guestbookDBService.ReplyGuestbooks(ReplyData);
                return RedirectToAction("Index"); //問google跳轉
            }
            else
            {
                return RedirectToAction("Index"); //問google跳轉
            }
        }
    }
}