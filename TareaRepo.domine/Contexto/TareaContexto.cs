using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaRepo.domine.Entities;

namespace TareaRepo.domine.Contexto
{
    class TareaContexto: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public Dbset<Producto> Productos { get; set; }
        public Dbset<Factura> Facturas { get; set; }
    }
}
