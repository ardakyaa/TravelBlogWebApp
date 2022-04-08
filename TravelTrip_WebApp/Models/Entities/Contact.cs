using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_WebApp.Models.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string NameAndSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}