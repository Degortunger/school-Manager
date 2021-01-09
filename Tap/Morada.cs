using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class Morada
    {

        string Rua;
        string Localidade;
        Cod_Postal CodPostal;

        public Morada()
        {
            CodPostal = new Cod_Postal();
        }

        public void SetRua(string r)
        {
            Rua = r;
        }
        public string GetRua()
        {
            return Rua;
        }

        public void SetLocalidade(string l)
        {
            Localidade = l;
        }
        public string GetLocalidade()
        {
            return Localidade;
        }


        public Cod_Postal GetCodPostal()
        {
            return CodPostal;
        }

        public void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Rua|{0}", Rua);
            f.WriteLine("Localidade|{0}", Localidade);
            CodPostal.EscreverFicheiro(f);

        }

        public void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            Rua = (palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            Localidade = palavras[1];

            CodPostal.LerFicheiro(f);

        }
    }
}

