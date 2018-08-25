using Exemplo.Dominio.Entidades;
using System;
using System.Linq;

namespace Exemplo.Dominio.Intefaces
{
    public interface IRepositorioDeUsuario : IRepositorio<Usuario>
    {
        IQueryable<Usuario> ObterUsuariosDoSexoFeminino();
        IQueryable<Usuario> ObterUsuariosDoSexoMasculino();
        IQueryable<Usuario> ObterUsuariosPorEstado(string estado);
    }
}
