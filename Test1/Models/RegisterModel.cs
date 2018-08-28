using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class RegisterModel
    {
        public int ID { get; set; }

        public string companyName { get; set; }
        //if private = 0 or other sector = 1
        public int category { get; set; }
        public IEnumerable<HttpPostedFileBase> documentsPriv { get; set; }
        public IEnumerable<HttpPostedFileBase> documentsOther { get; set; }

    }
}