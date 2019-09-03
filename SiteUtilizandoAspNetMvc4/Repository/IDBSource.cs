using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiteUtilizandoAspNetMvc4.Models;

namespace SiteUtilizandoAspNetMvc4.Repository
{
    public interface IDBSource
    {
        IQueryable<Author> Author { get; }
    }
}
