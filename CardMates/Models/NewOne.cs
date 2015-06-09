using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CardMates.Models
{
    
    public class NewOne
    {
        [Key]
        public int news_ID { get; set; }
        public string news_name { get; set; }
        public string news_start { get; set; }
        public string news_full { get; set; }
        public DateTime news_date { get; set; }
        public string img_src { get; set; }

        
    }
}