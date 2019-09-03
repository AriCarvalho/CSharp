using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteUtilizandoAspNetMvc4.Models
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int AuthorId { get; set; }
    }
}