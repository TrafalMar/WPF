using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
namespace Web.Classes
{
    [Serializable]
    public class SiteInfo  
    {
        public string url { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string time { get; set; }

        public SiteInfo() { }

        public SiteInfo(string title, string url, string date,string time) {
            this.url = url;
            this.title = title;
            this.date = date;
            this.time = time;
        }
    }
}
