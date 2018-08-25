using Exemplo.Dominio.Intefaces;
using System;

namespace Exemplo.Dominio.Entidades
{
    public class EntidadeBase : IEntidade
    {
        public EntidadeBase()
        {
            Id = new Guid();
            Deletado = false;
        }

        public Guid Id { get; private set; }
        public bool Deletado { get; private set; }


        public void Excluir()
        {
            Deletado = true;
        }
    }
}
