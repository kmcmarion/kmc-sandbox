using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace KMC_New.Models
{
    public class ApplicationModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Contact No.")]
        [Required(ErrorMessage = "Contact No. is required")]
        public string MobileNo { get; set; }

        [Required]
        public int ApprovedJobOpeningId { get; set; }

        [Display(Name = "Browse File")]
        [ScriptIgnore]
        public HttpPostedFileBase Upload { get; set; }

        [Display(Name = "Resume/CV")]
        [Required(ErrorMessage = "Resume is required")]
        public List<ApplicantFile> Files { get; set; }
    }

    public class ApplicantFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FileType { get; set; }
    }
}