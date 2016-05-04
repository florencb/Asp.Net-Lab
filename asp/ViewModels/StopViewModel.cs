using System;
using System.ComponentModel.DataAnnotations;

namespace asp.ViewModels
{
    public class StopViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Stop name is required")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Enter at least 5 characters for name")]
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [Required(ErrorMessage = "Arrival date is required")]
        public DateTime ArrivalDate { get; set; }
    }
}