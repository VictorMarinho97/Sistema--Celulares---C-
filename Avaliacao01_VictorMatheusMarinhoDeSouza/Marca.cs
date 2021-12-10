using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao01_VictorMatheusMarinhoDeSouza
{
    class Marca
    {
        public string nomeMarca;
        public string paisOrigem;
        public bool atuante;


        public Marca(string nomeMarca) 
        {
            NomeMarca = nomeMarca;
        }

        public Marca(string nomeMarca, string paisOrigem, bool atuante) :this(nomeMarca) 
        {
            PaisOrigem = paisOrigem;
            Atuante = atuante;
        }

        public string NomeMarca { get => nomeMarca; set => nomeMarca = value; }
        public string PaisOrigem { get => paisOrigem; set => paisOrigem = value; }
        public bool Atuante { get => atuante; set => atuante = value; } 

        public void EntrarSite()
        {
            Console.WriteLine("Deseja entrar no site do fabricante? s/n");
            char entrar = char.Parse(Console.ReadLine());

            if (entrar == 'S' || entrar == 's')
            {
                Console.WriteLine($"\nRedirecionando você para: www.{NomeMarca.ToLower()}.com");
            }

        }

        public string ObterInformacoes()
        {
            return "Informações sobre a marca: "
                + "\nNome: " 
                + NomeMarca + ", " 
                + "\nPaís de origem: "
                + PaisOrigem + ", " 
                + "\nAtuante no mercado: " 
                + Atuante + ", ";
        }
    }

}
