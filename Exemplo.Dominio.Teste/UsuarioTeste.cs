using Exemplo.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exemplo.Dominio.Teste
{
    [TestClass]
    public class UsuarioTeste
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Criando_Usuario_Com_Nome_Vazio_1()
        {
            var usuario = new Usuario();
            usuario.DefinirNome(string.Empty);
        }

        [TestMethod]
        public void Criando_Usuario_Com_Nome_Vazio_2()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var usuario = new Usuario();
                usuario.DefinirNome(string.Empty);
            });
        }

        [TestMethod]
        public void Criando_Usuario_Verificando_Tamanho()
        {
            Assert.ThrowsException<ApplicationException>(() =>
            {
                var usuario = new Usuario();
                usuario.DefinirNome("Kris");
            });
        }

        [TestMethod]
        public void Criando_Usuario_Com_Nome()
        {
            var nome = "João Paulo";

            var usuario = new Usuario();
            usuario.DefinirNome(nome);

            Assert.AreEqual(usuario.Nome, nome);
        }

        [TestMethod]
        public void Criando_Usuario_Menor_De_Idade()
        {
            Assert.ThrowsException<ApplicationException>(() =>
            {
                var usuario = new Usuario();
                usuario.DefinirDataDeNascimento(DateTime.Now);
            });
        }

        [TestMethod]
        public void Criando_Usuario_Fazendo_18_anos_Hoje()
        {
            var dt = DateTime.Now.AddYears(-18);
            var usuario = new Usuario();
            usuario.DefinirDataDeNascimento(dt);

            Assert.AreEqual(usuario.DataDeNascimento.ToString("dd/MM/yyyy"), dt.ToString("dd/MM/yyyy"));
        }

        [TestMethod]
        public void Criando_Usuario_Fazendo_18_anos_Daqui_A_2_Dias()
        {
            Assert.ThrowsException<ApplicationException>(() =>
            {
                var dt = DateTime.Now.AddYears(-18).AddDays(2);
                var usuario = new Usuario();
                usuario.DefinirDataDeNascimento(dt);
            });
        }


        [TestMethod]
        public void Criando_Usuario_Fazendo_Maior_De_Idade()
        {
            var dt = new DateTime(1981, 11, 20);
            var usuario = new Usuario();
            usuario.DefinirDataDeNascimento(dt);

            Assert.AreEqual(usuario.DataDeNascimento.ToString("dd/MM/yyyy"), dt.ToString("dd/MM/yyyy"));
        }


        [TestMethod]
        public void Criando_Usuario_Passando_Data_Minima()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var dt = DateTime.MinValue;
                var usuario = new Usuario();
                usuario.DefinirDataDeNascimento(dt);
            });
        }


        [TestMethod]
        public void Criando_Usuario_Passando_Data_Maxima()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var dt = DateTime.MaxValue;
                var usuario = new Usuario();
                usuario.DefinirDataDeNascimento(dt);
            });
        }
    }
}
