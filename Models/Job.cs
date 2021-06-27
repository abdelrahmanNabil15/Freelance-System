using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("Post Name")]
        public string JobTitle { get; set; }
        [DisplayName("Post description")]
        [AllowHtml]
        public string JobContent { get; set; }
        [DisplayName("Image ")]
        public string JobImage { get; set; }
        [DisplayName("JobBudget ")]
        public string JobBudget { get; set; }

        [DisplayName("Post Category")]
        public int CategoryId { get; set; }

        public string UserID { get; set; }
        [DisplayName("New Post")]
        public string ACtive { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}