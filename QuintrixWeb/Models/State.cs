using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuintrixWeb.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "State")]
        [Required(ErrorMessage = "Name of State is required")]
        [StringLength(ConstManager.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }

        [Required(ErrorMessage = "State Abriviation is required")]
        [StringLength(ConstManager.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}
