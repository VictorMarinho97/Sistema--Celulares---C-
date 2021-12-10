using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao01_VictorMatheusMarinhoDeSouza
{
    class Celular : Marca
    {
        public string modelo;
        public string sistemaOp;
        public int anoLancamento;
        public double preco;
        public int quantidade;


        public Celular(string modelo, string nomeMarca, string paisOrigem, bool atuante, string sistemaOp, int anoLancamento, double preco, int quantidade) : base(nomeMarca, paisOrigem, atuante)
        {
            Modelo = modelo;
            SistemaOp = sistemaOp;
            AnoLancamento = anoLancamento;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string SistemaOp { get => sistemaOp; set => sistemaOp = value; }
        public int AnoLancamento { get => anoLancamento; set => anoLancamento = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public void LigarCelular(char power)
        {
            Console.WriteLine("Vamos ligar o celular registrado");
            if(power == 's' || power == 'S') 
            {
                Console.WriteLine("Celular ligado!");
            }
        }

        public void LigarCelular() 
        {
            LigarCelular('s');
        }

        public void VenderCelular(int vender) 
        {
            Quantidade -= vender;
        }

        public double ObterLucro(double venda)
        {
            double lucros = venda * Preco;

            Console.WriteLine($"\nLucro obtido com a venda:{lucros}");

            return lucros;

        }

        public void ComprarCelular(int comprar)
        {
            Quantidade += comprar;
        }

        public double ObterAbatimento(double compra)
        {
            double investir = compra * Preco;

            Console.WriteLine($"\nO valor investido com a compra de celulares foi de:{investir}");

            return investir;

        }

        public override string ToString()
        {
            return $"Info sobre celular: \n{base.ObterInformacoes()}, \nModelo: {Modelo}, \nSistema operacional: {SistemaOp}, \nAno de lançamento: {AnoLancamento}, \nPreço: {Preco}, \nQuantidade: {Quantidade}";
        }


    }
}
