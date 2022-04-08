using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip_WebApp.Models.Entities
{
    public class Blog
    {
        public Blog()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public string BlogContent { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}