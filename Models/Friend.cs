using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace C_Project.Models
{
    public class FriendList
    {
        [Key]
        public int FriendListId {get;set;}
        public int UserId {get;set;}
        [ForeignKey("UserId")]
        public User Users {get;set;}
        public int FriendId {get;set;}
        [ForeignKey("FriendId")]
        public User Friend {get;set;}
    }
}