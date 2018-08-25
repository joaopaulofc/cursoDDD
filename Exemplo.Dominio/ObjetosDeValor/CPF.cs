namespace Exemplo.Dominio.ObjetosDeValor
{
    public class CPF
    {
        private readonly string numero;

        public CPF(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get
            {
                return numero;
            }
        }
    }
}
