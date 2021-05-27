using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMC_New.Models
{
    public class ActiveJobs
    {
        public int id { get; set; }
        public string category { get; set; }
        public int categoryId { get; set; }
        public string position { get; set; }
        public string workExperience { get; set; }
        public string educationInformation { get; set; }
        public string skillsAndQualification { get; set; }
        public string kpi { get; set; }
        public string status { get; set; }
        public string code { get; set; }
        public string datePosted { get; set; }
        public string city { get; set; }
    }
}