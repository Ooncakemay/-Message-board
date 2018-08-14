using MessageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Services
{
    public class GuestbooksDBService
    {
        MyGuestbookEntities db = new MyGuestbookEntities();
        public List<Guestbooks> GetDataList() {
            return db.Guestbooks.ToList();
        }
        public void InsertGuestbooks(Guestbooks newData) {
            newData.CreateTime = DateTime.Now;
            newData.LastUpdated = DateTime.Now;
            db.Guestbooks.Add(newData);
            db.SaveChanges();
        }
        public Guestbooks getDataById(int Id) {
            return db.Guestbooks.Find(Id);
        }
        public void UpdateGuestbooks(Guestbooks UpdateData) {
            //取得修改資料的實體
            Guestbooks oldDate = db.Guestbooks.Find(UpdateData.Id);
            // 增加驗證嗎?????
            oldDate.Name = UpdateData.Name;
            oldDate.Content = UpdateData.Content;
            oldDate.LastUpdated = DateTime.Now;
            db.SaveChanges();
        }
        public void ReplyGuestbooks(Guestbooks ReplayData){
            Guestbooks oldDate = db.Guestbooks.Find(ReplayData.Id);
            // 增加驗證嗎?????
            oldDate.Reply = ReplayData.Reply;
            oldDate.ReplyTime = DateTime.Now;
            db.SaveChanges();
        }
        public bool CheckUpdate(int Id) {
            Guestbooks Data = db.Guestbooks.Find(Id);
            return (Data != null & Data.ReplyTime == null);
        }
    }


    
}