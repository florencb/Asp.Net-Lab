using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.ViewModels
{
    public class TripViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter at least 5 characters for name")]
        [StringLength(255, MinimumLength = 5, ErrorMessage ="Invalid")]
        public string name { get; set; }
        public DateTime date = DateTime.Now;
        public IEnumerable<StopViewModel> stops { get; set; }
    }
}
