using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTicketCinema.Mvc.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
