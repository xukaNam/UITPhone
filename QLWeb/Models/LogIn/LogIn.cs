using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLWeb.Models.LogIn
{
    public class LogIn
    {
        [Required]
        public string UserName { get; set; }
        public string PassWord { get; set; }
        //public bool RememberMe { get; set; }
        public LogIn()
        {

        }
        public LogIn(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
        }
    }
}