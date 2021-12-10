using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao01_VictorMatheusMarinhoDeSouza
{
    class Chipset : Marca  
    {
        public string modeloChip;
        public int memoria;
        public string gpu;

        public Chipset(string modeloChip, string nomeMarca, string paisOrigem, bool atuante, int memoria, string gpu) : base(nomeMarca, paisOrigem, atuante) 
        {
            ModeloChip = modeloChip;
            Memoria = memoria;
            Gpu = gpu;
        }

        public string ModeloChip { get => modeloChip; set => modeloChip = value; }
        public int Memoria { get => memoria; set => memoria = value; }
        public string Gpu { get => gpu; set => gpu = value; }

        public override string ToString()
        {
            return $"Info sobre chipset: \n{base.ObterInformacoes()} \nModelo do chip: {ModeloChip}, \nMemória: {Memoria}, \nGPU: {Gpu}";
        }

    }
}
