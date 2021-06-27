using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Job_Offers_Website.Models
{


    public class ContactModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [AllowHtml]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }

        public String Id { get; set; }
        public String Username { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }


     
        public virtual ICollection<RoleViewModel> Roles { get; set; }

    }
}
 