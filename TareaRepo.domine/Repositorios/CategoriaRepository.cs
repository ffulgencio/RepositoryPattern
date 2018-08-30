using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TareaRepo.domine.Core.Interfaces;
using TareaRepo.domine.Entities;
using TareaRepo.domine.Contexto;

namespace TareaRepo.domine.Repositorios
{
    class CategoriaRepository : ICategoriaRepository<Categoria>
    {
        private readonly TareaContexto _contexto;

        public CategoriaRepository()
        {
            _contexto = new TareaContexto();
        }
        public Categoria Actualizar(Categoria entidad)
        {
            _contexto.Entry(entidad).State = EntityState.Modified;
            return entidad;
        }

        public Categoria Agregar(Categoria entidad)
        {
            var resultado = _contexto.Categorias.Add(entidad);
            return resultado;
        }

        public IEnumerable<Categoria> Buscar(Expression<Func<Categoria, bool>> predicado)
        {
            //var resultado = Todos().Where(predicado);
            return null; //borrar
        }

        public Categoria Eliminar(Categoria entidad)
        {
            throw new NotImplementedException();
        }

        public Categoria ObtenerCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> Todos()
        {
            var resultado = _contexto.Categorias;
            return resultado;
        }
    }
}
