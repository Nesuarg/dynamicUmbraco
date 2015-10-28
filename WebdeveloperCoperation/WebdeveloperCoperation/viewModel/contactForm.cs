using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebdeveloperCoperation.viewModel
{
    public class contactForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage="this it not a valid emailadress")]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }

    }
}