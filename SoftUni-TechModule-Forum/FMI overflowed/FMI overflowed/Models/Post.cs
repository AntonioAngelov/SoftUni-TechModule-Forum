﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMI_overflowed.Models
{
    public class Post
    {
        public Post()

        {
            this.Date = DateTime.Now;
        }
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Section { get; set; }

        public ApplicationUser Author { get; set; }
        
        
    }
}
    
