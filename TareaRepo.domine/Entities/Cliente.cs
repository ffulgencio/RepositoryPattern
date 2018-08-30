using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepo.domine.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Rnc { get; set; }

        public virtual IEnumerable<Factura> Facturas { get; set; }
    }
}
