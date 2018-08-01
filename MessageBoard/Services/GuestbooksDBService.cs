using MessageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Services
{
    public class GuestbooksDBService
    {
        demoEntities db = new demoEntities();
        public List<Guestbooks> getDataList() {
            return db.Guestbooks.ToList();
        }
    }
}