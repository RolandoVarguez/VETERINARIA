using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterianria.Web.Models
{
    public class Owner
    {
        public int id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}