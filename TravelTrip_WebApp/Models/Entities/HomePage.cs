using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_WebApp.Models.Entities
{
    public class HomePage
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Statement  { get; set; }
    }
}