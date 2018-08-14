using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageBoard.Models
{
    [MetadataType(typeof(GuestbookMetadata))]
    public partial class Guestbooks
    {
         private class GuestbookMetadata
        {
            [DisplayName("編號:")]
            public int Id { get; set; }

            [DisplayName("名字:")]
            [Required(ErrorMessage = "請輸入名字")]
            [StringLength(20, ErrorMessage = "名字不可以超過20個字元")]
            public string Name { get; set; }

            [DisplayName("留言內容:")]
            [Required(ErrorMessage = "請輸入留言內容")]
            [StringLength(100, ErrorMessage = "留言不可以超過100個字")]
            public string Content { get; set; }
            
            [DisplayName("回覆內容:")]
            [StringLength(100, ErrorMessage = "回覆內容不可以超過100個字")]
            public string Reply { get; set; }

            [DisplayName("新增時間:")]
            public DateTime CreateTime { get; set; }

            [DisplayName("編輯時間:")]
            public DateTime LastUpdated { get; set;}

            [DisplayName("回覆時間:")]
            public DateTime ReplyTime { get; set;}


        }
    }
}