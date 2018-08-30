using System;
using System.Collections.Generic;

namespace TareaRepo.domine.Entities
{
    public class Factura
    {
        public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int Id { get; set; }
        public string NCF { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoTotal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual IEnumerable<DetalleFactura> DetalleFacturas { get; set; }
    }
}