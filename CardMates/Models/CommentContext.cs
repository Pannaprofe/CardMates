using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CardMates.Models
{
    public class CommentContext
    {
        [Key]
        public int comment_ID { get; set; }
        public DateTime comment_date { get; set; }
        public string author { get; set; }
        public string body { get; set; }
        public int news_id { get; set; }
    }
}