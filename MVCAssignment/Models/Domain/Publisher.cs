﻿using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        public string PublisherName { get; set; }
    }
}

