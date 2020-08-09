using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MhicksBlog.Models;

namespace MhicksBlog.Models
{
    public class BlogViewDbContext : DbContext
    {
        public BlogViewDbContext(DbContextOptions<BlogViewDbContext>Options) :base(Options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<   Post>()
                .HasKey(c => new { c.Id });
            modelBuilder.Entity<   PostCategory>()
               .HasKey(c => new { c.Postid, c.CategoryId });
            modelBuilder.Entity<   Category>()
             .HasKey(c => new { c.Id });
            modelBuilder.Entity<   PostImg>()
            .HasKey(c => new { c.PostId, c.TagId });
            modelBuilder.Entity<   PostLike>()
            .HasKey(c => new { c.PostId });
            modelBuilder.Entity<   Commentlikes>()
            .HasKey(c => new { c.CommentId });
            modelBuilder.Entity<   Replylike>()
            .HasKey(c => new { c.ReplyId });
           
            //modelBuilder.Entity<BlogViewModel>().HasNoKey();
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Img> Imgs { get; set; }
        public DbSet<PostImg> PostImgs { get; set; }
        public DbSet<PostVideo> PostVideos { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<Commentlikes> Commentlikes { get; set; }
        public DbSet<Replylike> Replylikes { get; set; }





    }
}
