using System.Collections.Generic;

namespace TareaRepo.domine.Entities
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
        public int Cantidad{ get; set; }
        public int ProductoId { get; set; }

        public virtual IEnumerable<Producto> Productos { get; set; }
        public double SubTotal { get; set; }
    }
}