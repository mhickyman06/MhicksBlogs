using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public class Post
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="the length should between 5 - 50",MinimumLength =5)]
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name ="ShortDescription")]
        [StringLength(150,ErrorMessage ="The length should between 20 - 150",MinimumLength =20)]
        public string ShortDescription { get; set; }
        [Required]
        [Display(Name ="Body")]
        public string Body { get; set; }
        [Required]
        [Display(Name ="Meta")]
        [StringLength(15,ErrorMessage ="The length should between 5 - 15",MinimumLength =5)]
        public string Meta { get; set; }
        [Required]
        [Display(Name ="UrlSeo")]
        public string UrlSeo { get; set; }
        
        [Display(Name ="Published")]
        public bool Published { get; set; }
        [DefaultValue(0)]
        public int BlogCount { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DateModified { get; set; }
   
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Reply>  Replies { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
        public ICollection<PostImg> PostImgs { get; set; }
        public ICollection<PostVideo> PostVideos { get; set; }
        public ICollection<PostLike> PostLikes { get; set; }
    }
    public class Category
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="UrlSeo")]
        public string UrlSeo { get; set; }
        [Required]
        [Display(Name ="Description")]
        [StringLength(20,ErrorMessage ="The length should between 5 - 20",MinimumLength =5)]
        public string Description { get; set; }
        public bool Checked { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
    } 
    public class PostCategory
    {
        [Key]
        [Column(Order =0)]
        public string Postid { get; set; }
        [Key]
        [Column(Order =1)]
        public int CategoryId { get; set; }
        public bool Checked { get; set; }
        public Post Post { get; set; }
        public Category Category { get; set; }
    }
    public class Comment
    {
       
        public string Id { get; set; }
        public string PostId { get; set; }
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        [Required]
        [StringLength(1000,ErrorMessage ="The legnth should be between 35 - 1000",MinimumLength =35)]
        public string Body { get; set; }
        [DefaultValue(0)]
        public int CommentCount { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
        public Post Post { get; set; }
        public ICollection<Reply> Replies { get; set; }
        public ICollection<Commentlikes> CommentLikes { get; set; }
    }
    public class Reply
    {
        public string Id{ get; set; }
        public string  PostID { get; set; }
        public string CommentID { get; set; }
        public string ParentReplyId { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
        [Required]
        [StringLength(1000,ErrorMessage ="The legnth shoud between 35 - 1000",MinimumLength =35)]
        public string Body { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
        public Post Post { get; set; }
        public Comment Comment { get; set; }
        public ICollection<Replylike> Replylikes { get; set; }
    }
    public class Img
    {
        public string Id { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string  Name { get; set; }
        [Required]
        [Display(Name ="UrlSeo")]
        [StringLength(30,ErrorMessage ="The legnth should between 5 - 30",MinimumLength = 5)]
        public string UrlSeo { get; set; }
        public bool Checked { get; set; }
        public ICollection<PostImg> PostImgs { get; set; }

    }

    public class PostImg
    {
        [Key]
        [Column(Order =0)]
        public string PostId { get; set; }
        [Key]
        [Column(Order =1)]
        public string TagId { get; set; }
        public bool Checked { get; set; }
        public Post Post { get; set; }
        public Img Img { get; set; }
    }
    public class PostVideo
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="VideoUrl")]
        [DataType(DataType.Url)]
        public string  VideoUrl { get; set; }
        public string PostId { get; set; }
        public string  VideoThumbNail { get; set; }
        public Post Post { get; set; }
    }
    public class PostLike
    {
        [Key]
        public string PostId { get; set; }
        public string UserName { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public Post Post  { get; set; }
    }
    public class Commentlikes
    {
        [Key]
        public string CommentId { get; set; }
        public string UserName { get; set; }
        public bool Like { get; set; }
        public bool DisLike { get; set; }
        public Comment Comment { get; set; }

    }
    public class Replylike
    {
        [Key]
        public string ReplyId { get; set; }
        public string UserName { get; set; }
        public bool Like { get; set; }
        public bool DisLike { get; set; }
        public Reply Reply { get; set; }

    }
}

