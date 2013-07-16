using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoMVCBackofficePages.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First name:")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last name:")]
        [Required]
        public string LastName { get; set; }

    }
}