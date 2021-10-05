using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjetoSiscola.Data;

namespace ProjetoSiscola.Data
{
    class Banco :DbContext
    {
        public Banco() : base("name=db_siscola")
        {
            Database.SetInitializer<Banco>(null);
        }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
