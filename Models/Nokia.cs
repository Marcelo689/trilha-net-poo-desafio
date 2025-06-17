namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo, string IMEI, int Memoria) : base(numero,modelo,IMEI,Memoria)
        {
            Ligar();
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo " + nomeApp+ " no Nokia");
        }
    }
}