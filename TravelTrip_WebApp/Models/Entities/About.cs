using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_WebApp.Models.Entities
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
    }
}