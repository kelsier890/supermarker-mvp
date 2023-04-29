using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay mode Name")]
        public int ID { get; set; }

        [DisplayName("Pay mode Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must be betweem 3 and 50 characters")]

        public string Name { get; set; }
        [DisplayName("Observation")]
        [Required(ErrorMessage ="Pay mode observation required ")]
        [StringLength(200, MinimumLength=3,ErrorMessage ="Pay mode observation must be betweem 3 and 200 characters")]
        public string Observaion { get; set; }


    }
}
