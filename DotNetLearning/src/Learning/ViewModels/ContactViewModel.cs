using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Learning.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(255, MinimumLength =5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(1024, MinimumLength = 5)]
        [Required]
        public string Message { get; set; }

    }
}
