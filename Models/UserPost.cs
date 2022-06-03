using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace C_Project.Models
{
    public class UserPost
    {
        [Key]
        public int UserPostId {get;set;}
        public int UserId {get;set;}
        [Required]
        public string PostContent {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public User PostedBY {get;set;}
    }
}