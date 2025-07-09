namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        /*Implementado*/
        public string Numero;
        protected readonly string _modelo;
        protected readonly string _IMEI;
        protected readonly int _memoria;

        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _IMEI = IMEI;
            _memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            /*Implementado*/

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}