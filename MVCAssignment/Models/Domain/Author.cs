﻿using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string AuthorName { get; set; }

      


    }
}
