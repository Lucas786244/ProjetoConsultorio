using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoConsultorio.Models;

namespace ProjetoConsultorio.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoConsultorio.Models.Consulta> Consulta { get; set; } = default!;
    }
}
