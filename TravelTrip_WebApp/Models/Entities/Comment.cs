using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_WebApp.Models.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserComment { get; set; }
        public virtual Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}