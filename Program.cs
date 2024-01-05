using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    class Program
    {
        static void Main(string[] teste)
        {
            TesteNokia();
            TesteIphone();
        }

        static void TesteNokia()
        {
            Console.WriteLine("Iniciando teste Nokia...");
            Nokia nokia = new Nokia("123456", "Nokia Modelo X", "IMEI123", 64);

            Console.WriteLine($"Número: {nokia.Numero}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria}GB");

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("Teste do Nokia concluído");
            Console.WriteLine();
        }
        static void TesteIphone()
        {

            Console.WriteLine("Iniciando teste Iphone...");
            Iphone iphone = new Iphone("654321", "iPhone 12", "IMEI456", 128);

            Console.WriteLine($"Número: {iphone.Numero}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria}GB");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("Teste do Iphone concluído");
        }
    }
}