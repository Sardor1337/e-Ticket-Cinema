using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTicketCinema.Mvc.Models
{
    public class ApplicationUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
