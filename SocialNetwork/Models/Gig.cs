﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models
{
    public class Gig
    {

    
        public int Id { get; set; }
        
        [Required]
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string venue { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}