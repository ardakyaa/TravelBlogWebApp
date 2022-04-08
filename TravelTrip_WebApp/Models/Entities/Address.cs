using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_WebApp.Models.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string AddressContent { get; set; }
        public string AddressDetail { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

    }
}