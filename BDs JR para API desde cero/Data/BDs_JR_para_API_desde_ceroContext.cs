using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDs_JR_para_API_desde_cero.Models;

namespace BDs_JR_para_API_desde_cero.Data
{
    public class BDs_JR_para_API_desde_ceroContext : DbContext
    {
        public BDs_JR_para_API_desde_ceroContext (DbContextOptions<BDs_JR_para_API_desde_ceroContext> options)
            : base(options)
        {
        }

        public DbSet<BDs_JR_para_API_desde_cero.Models.Burger> Burger { get; set; } = default!;
        public DbSet<BDs_JR_para_API_desde_cero.Models.Promo> Promo { get; set; } = default!;
    }
}
