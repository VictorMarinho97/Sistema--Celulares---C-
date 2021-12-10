using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao01_VictorMatheusMarinhoDeSouza
{
    class Camera
    {
        public string modeloCelRespectivo;
        public double resolucaoFoto;
        public bool hdr;
        public string resolucaoVideo;

        public Camera() 
        {
            Console.WriteLine("Mostrando câmera...");
        }

        public Camera(string modeloCelRespectivo, double resolucaoFoto, bool hdr, string resolucaoVideo) : this()
        {
            ModeloCelRespectivo = modeloCelRespectivo;
            ResolucaoFoto = resolucaoFoto;
            Hdr = hdr;
            ResolucaoVideo = resolucaoVideo;
        }

        public string ModeloCelRespectivo { get => modeloCelRespectivo; set => modeloCelRespectivo = value; }
        public double ResolucaoFoto { get => resolucaoFoto; set => resolucaoFoto = value; }
        public bool Hdr { get => hdr; set => hdr = value; }
        public string ResolucaoVideo { get => resolucaoVideo; set => resolucaoVideo = value; }

        public void TirarFoto(char tirar) 
        {
            
            if(tirar == 's' || tirar == 'S') 
            {
                Console.WriteLine("\nClick! Foto tirada!");
            }
            else 
            {
                Console.WriteLine("\nOk, vamos prosseguir");
            }

            }
      

        public override string ToString()
        {
            return $"Dados da câmera: \nCelular ligado à ela: {ModeloCelRespectivo}, \nResolução de foto: {ResolucaoFoto.ToString("F2", CultureInfo.InvariantCulture)}, \nHDR: {Hdr}, \nresolução de vídeo: {ResolucaoVideo}";
        }
    }

}
