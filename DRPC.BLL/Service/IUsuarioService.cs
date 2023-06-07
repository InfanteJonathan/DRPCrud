using DRPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPC.SERVICE.Service
{
    public interface IUsuarioService
    {
        Task<IQueryable<Usuario>> ObtenerTodos();
        Task<Usuario> Obtener(int id);
        Task<bool> Insertar(Usuario modelo);
        Task<bool> Actualizar(Usuario modelo);
        Task<bool> Eliminar(int id);

        Task<Usuario> ObtenerNombre(string nombre);
    }
}
