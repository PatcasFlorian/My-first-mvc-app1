using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcAppWeb.Models
{
    public class ContactListEntry
    {
        [Required]
        public int Id { get; set;}
        [Display(Name ="Contact Type")]
        [Required]
        public ContactType ContactType { get; set; }
        [Required]
        [Display(Name="Name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Phone")]
        [StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
