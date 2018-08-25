using Exemplo.Dominio.Constantes;
using Exemplo.Dominio.Enumeradores;
using Exemplo.Dominio.ObjetosDeValor;
using System;
using System.Collections.Generic;

namespace Exemplo.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        //protected Usuario()
        //{

        //}

        public Usuario() 
            :base()
        {

        }

        //public Usuario(string nome, DateTime dataDeNascimento, string login, string senha, string cpf, ICollection<Endereco> enderecos, ICollection<Email> emails, ICollection<Telefone> telefones, Sexo sexo)
        //    :base()
        //{
        //    DefinirNome(nome);
        //    DefinirDataDeNascimento(dataDeNascimento);
        //    DefinirLogin(login);
        //}


        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public CPF CPF { get; private set; }
        public ICollection<Endereco> Enderecos { get; private set; }
        public ICollection<Email> Emails { get; private set; }
        public ICollection<Telefone> Telefones { get; private set; }
        public Sexo Sexo { get; private set; }


        public void DefinirNome(string nome)
        {
            if(string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("Nome obrigatório");
            }

            if(nome.Length < Configuracao.TamanhoMinimoNome)
            {
                throw new ApplicationException($"Nome deve possuir no mínimo {Configuracao.TamanhoMinimoNome} caracteres");
            }

            Nome = nome;
        }

        public void DefinirDataDeNascimento(DateTime dataDeNascimento)
        {
            if(dataDeNascimento == DateTime.MinValue || dataDeNascimento == DateTime.MaxValue)
            {
                throw new ArgumentNullException("Data inválida");
            }

            var hoje = DateTime.Now;
            var anos = (hoje.Year - dataDeNascimento.Year);

            if(anos <= Configuracao.IdadeMinima && dataDeNascimento.AddYears(Configuracao.IdadeMinima) > hoje)
            {
                throw new ApplicationException($"Menor de { Configuracao.IdadeMinima } anos");
            }

            DataDeNascimento = dataDeNascimento;
        }

        public void DefinirLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentNullException("Login obrigatório");
            }

            Login = login;
        }

        public void DefinirSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha))
            {
                throw new ArgumentNullException("Senha obrigatório");
            }

            Senha = senha;
        }
    }
}
