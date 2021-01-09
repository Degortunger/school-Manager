using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
   public  class Cod_Postal
    {
        int Campo1;
        int Campo2;

        public Cod_Postal()
        {

        }

        public void SetCampo1(int c1)
        {
            Campo1 = c1;

        }
        public int GetCampo1()
        {
            return Campo1;
        }
        public void SetCampo2(int c2)
        {
            Campo2 = c2;
        }
        public int GetCampo2()
        {
            return Campo2;
        }

        public void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Campo1|{0}", Campo1);
            f.WriteLine("Campo2|{0}", Campo2);
        }

        public void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            Campo1 = Convert.ToInt32(palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            Campo2 = Convert.ToInt32(palavras[1]);
        }
    }
}
