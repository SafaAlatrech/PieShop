﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafaPieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Your name is required")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your name is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage ="The email address is not entered in a correct information")]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Your message is required")]
        public string  Message { get; set; } 


        public bool ContactMe { get; set; }

    }
}
