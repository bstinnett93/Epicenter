using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Epicenter.Areas.Episodes.Models
{
    public class EpisodeViewModel
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string ImageURL { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
