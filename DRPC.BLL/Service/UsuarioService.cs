using DRPC.DAL.Repositories;
using DRPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPC.SERVICE.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenRepository<Usuario> _userRepo;
        public UsuarioService(IGenRepository<Usuario> UserRepo)
        {
            _userRepo = UserRepo;
        }
        public async Task<bool> Actualizar(Usuario modelo)
        {
            return await _userRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _userRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Usuario modelo)
        {
            return await _userRepo.Insertar(modelo);
        }

        public async Task<Usuario> Obtener(int id)
        {
            return await _userRepo.Obtener(id);
        }

        public async Task<IQueryable<Usuario>> ObtenerTodos()
        {
            return await _userRepo.ObtenerTodos();
        }

        public async Task<Usuario> ObtenerNombre(string nombre)
        {
            IQueryable<Usuario> queryUserSQL = await _userRepo.ObtenerTodos();
            Usuario us = queryUserSQL.Where(u=>u.Nombre==nombre).FirstOrDefault();
            return us;

        }
    }
}
