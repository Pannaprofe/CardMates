using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CardMates.Models
{
    public class NewsContext : DbContext
    {
        public DbSet<NewOne> News { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<CommentContext> Comments { get; set; }
    }
}