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
            db.Guestbooks.Add(newData);
            db.SaveChanges();
        }
    }
}