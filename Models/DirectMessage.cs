using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace C_Project.Models
{
    public class DirectMessage
    {
        public int DirectMessageId {get;set;}
        public int UserMessagingId {get;set;}
        [ForeignKey("UserMessagingId")]
        public User UserMessaging {get;set;}
        public int UserMessagedId {get;set;}
        [ForeignKey("UserMessagedId")]
        public User UserMessaged {get;set;}
    }
}