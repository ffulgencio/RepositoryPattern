using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepo.domine.Core.Interfaces
{
    public interface IRepository<T>
    {
        T Agregar(T entidad);
        T Actualizar(T entidad);
        IEnumerable<T> Todos();
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);
        T Eliminar(T entidad);
    }
}
