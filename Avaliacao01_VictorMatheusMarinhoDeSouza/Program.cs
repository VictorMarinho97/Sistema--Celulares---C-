using System;

namespace Avaliacao01_VictorMatheusMarinhoDeSouza
{
    class Program
    {
        static void Main(string[] args)
        {

            // M – Registro de tipos de Marcas de Celulares diferentes e suas respectivas características.

            Marca samsung = new Marca("Samsung", "Coreia do Sul", true);
            Console.WriteLine(samsung.ObterInformacoes());

            Console.WriteLine();
            Celular s10 = new Celular("Galaxy s10", "Samsung", "Coreia do Sul", true, "Android 9 pie", 2019, 1699.00, 500);
            s10.LigarCelular();
            Console.WriteLine();
            Console.WriteLine(s10.ToString());

            Console.WriteLine();
            Chipset qualcomms10 = new Chipset("Snapdragon 855", "Qualcomm", "EUA", true, 8, "Adreno 640");
            Console.WriteLine(qualcomms10.ToString());

            Console.WriteLine();
            Camera cameraS10 = new Camera("Galaxy s10", 12, true, "1080p");

            Console.WriteLine();
            Console.WriteLine(cameraS10);

            Console.WriteLine();
            Console.WriteLine("Deseja tirar uma foto para testar a câmera? s/n");
            char tirar = char.Parse(Console.ReadLine());
            cameraS10.TirarFoto(tirar);


            Console.WriteLine();
            Console.WriteLine($"Digite a quantidade de celulares {s10.Modelo} vendidos hoje: ");
            int venda = int.Parse(Console.ReadLine());
            s10.VenderCelular(venda);
            s10.ObterLucro(venda);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(s10.ToString());

            Console.WriteLine();
            Console.WriteLine($"Digite a quantidade de celulares {s10.Modelo} adquiridos hoje: ");
            int compra = int.Parse(Console.ReadLine());
            s10.ComprarCelular(compra);
            s10.ObterAbatimento(compra);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(s10.ToString());

            Console.WriteLine();
            s10.EntrarSite();




        }
    }
}
