using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepo.domine.Core.Interfaces
{
    interface ICategoriaRepository<T> : IRepository<T> where T:class
    {
        T ObtenerCategoriaPorId(int id);
    }
}
