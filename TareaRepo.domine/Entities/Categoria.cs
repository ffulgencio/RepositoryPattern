﻿using System.Collections.Generic;

namespace TareaRepo.domine.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public virtual IEnumerable<Producto> Productos { get; set; }
    }
}