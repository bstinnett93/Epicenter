using System;

namespace Epicenter.Models
{
    public class ShowViewModel
    {
        public int ShowId { get; set; }
        public string ShowName { get; set; }
        public double AverageRating { get; set; }
        public string ImageURL { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
