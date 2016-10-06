namespace XPlaneWeb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Inicializando os servidores.");

            AppXpWeb.i.inicializarServidor();

            System.Console.WriteLine("Servidores inicializados");

            System.Console.ReadKey();

        }
    }
}