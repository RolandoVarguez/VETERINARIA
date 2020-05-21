using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterianria.Web.Models
{
    public class Veterinary
    {
        public int Id { get; set; }
        [Display(Name="Descripcion")]
        public string Description { get; set; }
        public ICollection<Consult> Consults { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}