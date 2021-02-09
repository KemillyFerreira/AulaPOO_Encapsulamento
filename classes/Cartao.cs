namespace Encapsulamento.classes
{

    public class Cartao
    {
        //declaração dos atributos
        private string numero;
        private string bandeira = "MasterCard";

        public string Bandeira
        {
            get{return bandeira;}
            set{bandeira = value;}
        }
        protected string token = "qwertyui";

        public string Token
        {
            get{return token;}
        }
        private string cvv;
        protected float limite = 5000;

        //declação dos métodos
        public string RegistrarCompra(bool validado)
        {
            return "";
        }

        private bool ValidarCompra(float saldo)
        {
            return true;
        }
        protected string ValidarToken(string token)
        {
            return "";
        }
    }
}
