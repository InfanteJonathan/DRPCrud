using DRPC.DAL.DataContext;
using DRPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPC.DAL.Repositories
{
    public class UsuarioRepository : IGenRepository<Usuario>
    {
        private readonly DrpcvirtualContext _context;
        public UsuarioRepository(DrpcvirtualContext context)
        {
            _context = context;
        }
        public async Task<bool> Actualizar(Usuario modelo)
        {
            _context.Usuarios.Update(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Usuario user = _context.Usuarios.First(u=>u.UserId == id);
            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Usuario modelo)
        {
            _context.Usuarios.Add(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Usuario> Obtener(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<IQueryable<Usuario>> ObtenerTodos()
        {
            IQueryable<Usuario> querySql = _context.Usuarios;
            return querySql;
        }
    }
}