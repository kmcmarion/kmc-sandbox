using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KMC_New.Models
{
    public class ContactFormViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [DisplayName("Joining Date")]
        public string JoiningDate { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string YourWork { get; set; }
        [Required]
        public string YourActualWork { get; set; }
        [Required]
        public string ThreeThings { get; set; }
        [Required]
        public string ILoveMyJob { get; set; }
        [Required]
        public string Merienda { get; set; }
        [Required]
        public string Relax { get; set; }
        [Required]
        public string GuiltyPleasure { get; set; }
        //public string YourPhoto { get; set; }
        [Required]
        public HttpPostedFileBase KMCPhotos1 { get; set; }
        [Required]
        public HttpPostedFileBase KMCPhotos2 { get; set; }
        [Required]
        public HttpPostedFileBase KMCPhotos3 { get; set; }
        [Required]
        public HttpPostedFileBase YourPhoto { get; set; }
    }

   
}