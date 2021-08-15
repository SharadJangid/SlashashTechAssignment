using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForSummerNote.Models
{
    public class fileupload
    {
       
        public string Title { get; set; }     
        [AllowHtml]
        public string Content { get; set; }
        public string ContentType { get; set; }
        public string size { get; set; }
    }
}