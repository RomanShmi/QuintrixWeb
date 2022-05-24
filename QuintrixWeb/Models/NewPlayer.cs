using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintrixWeb.Models
{
    public class NewPlayer
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(ConstManager.MAX_FIRST_NAME_LENGTH)]
        public string Name { get; set; }

        [Display(Name = "Level")]
        [Required(ErrorMessage = "number from 1 to 88")]
        
        public int Level { get; set; }



        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is required")]
        [StringLength(ConstManager.MAX_EMAIL_LENGTH)]
        [EmailAddress(ErrorMessage = "Invalid email Address")]

        public string Email { get; set; }


        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required")]
        public int StateId { get; set; }

        public virtual State State { get; set; }

       



    }
}
