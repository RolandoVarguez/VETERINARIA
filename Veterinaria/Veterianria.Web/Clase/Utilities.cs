using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterianria.Web.Models;

namespace Veterianria.Web.Clase
{
    public class Utilities
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();






        public void Dispose()
        {

            db.Dispose();
        }

    }
}