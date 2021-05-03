using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PluralSight_AngularCourse.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Too Short")]
        public string Name { get; set; }
        [Required][EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Too Long")]
        public string Message { get; set; }
    }
}
