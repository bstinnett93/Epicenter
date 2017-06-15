using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Epicenter.Areas.Shows.Models
{
    public class LibraryViewModel
    {
        public IEnumerable<ShowViewModel> Shows { get; set; }
        public string Username { get; set; }
    }
}
