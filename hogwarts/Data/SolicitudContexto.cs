using hogwarts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogwarts.Data
{
    public class SolicitudContexto : DbContext
    {
        public SolicitudContexto(DbContextOptions<SolicitudContexto> options):base(options)
        {

        }
        // crear db set
        public DbSet<Solicitud> SolicitudItems { get; set; }
    }
}
