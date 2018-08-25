using System;

namespace Exemplo.Dominio.Intefaces
{
    public interface IEntidade
    {
        Guid Id { get;  }
        bool Deletado { get; }
    }
}
