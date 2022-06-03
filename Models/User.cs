using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace C_Project.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage ="The first name should be at least 2 charactors long")]
        public string Name { get; set; } 
        //trying to store profile pic in database
        public string Photo {get;set;}= "https://th.bing.com/th/id/R.c806589295b732b4d13a5b68bbb560a0?rik=iqhl0u4nOvsjkA&riu=http%3a%2f%2fcdn.onlinewebfonts.com%2fsvg%2fimg_184513.png&ehk=SewvAmum19vsY7YXrHHH2ZPm%2bboA4S2ENK7Gypz6c3A%3d&risl=&pid=ImgRaw&r=0";
        [Required]
        [EmailAddress(ErrorMessage = "please Enter a valid email address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="The password should be at least 8 characters long.")]
        public string Password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The Password and Confirm Paswword must match.")]
        public string ConfirmPassword {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // one to many for User to UserPost
        public List<UserPost> Posts {get;set;} 
        //Many to Many for User to User ( friends List )
        [InverseProperty("Users")]
        public List<FriendList> Friend {get;set;}
        [InverseProperty("Friend")]
        public List<FriendList> Users {get;set;}
        //Many to Many for User to User (Direct Messeges)
        [InverseProperty("UserMessaged")]
        public List<DirectMessage> UserMesseging {get;set;}
        [InverseProperty("UserMessaging")]
        public List<DirectMessage> UserMessaged {get;set;}
    }
    public class UserLogin
    {
        
        [Required]
        [EmailAddress(ErrorMessage = "please Enter a valid email address")]
        public string LoginEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="The password should be at least 8 characters long.")]
        public string LoginPassword { get; set; }
        
    }

    
}