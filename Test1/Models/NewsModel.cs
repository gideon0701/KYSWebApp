using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class NewsModel
    {
        public string CompanyName { get; set; }
        public List<string> Links { get; set; }
        public List<string> LinkSentiments { get; set; }
        public int? RiskScore { get; set; }
    }
}