using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace C_Project.Models
{
    public class Photo
    {
        //trying to store profile pic in database
        [Required]
        [UrlCheck]
        public string ProfilePic {get;set;}= "https://th.bing.com/th/id/R.c806589295b732b4d13a5b68bbb560a0?rik=iqhl0u4nOvsjkA&riu=http%3a%2f%2fcdn.onlinewebfonts.com%2fsvg%2fimg_184513.png&ehk=SewvAmum19vsY7YXrHHH2ZPm%2bboA4S2ENK7Gypz6c3A%3d&risl=&pid=ImgRaw&r=0";
    }
    
    //custom validation to check and see if the url given was a .jpg or .png and if it wasnt give an error
    public class UrlCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> Extensions = new List<string>(){".jpg", ".png"};
            if((string)value == null)
            {
                return new ValidationResult("Can't be empty");
            }
            bool found = false;
            foreach(string row in Extensions)
            {
                if (((string)value).ToLower().Contains(row))
                    found = true;
                
            }
            if(found)
            {
                return ValidationResult.Success;
            } else {
                return new ValidationResult("The file must be either .jpg or .png");
            }
        }

    } 
}