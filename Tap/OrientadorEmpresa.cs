using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class OrientadorEmpresa:Pessoa
    {
        int numOrientador;

        public OrientadorEmpresa()
        {
            numOrientador = 0;
        }

        public void SetNumOrientador(int n)
        {
            numOrientador = n;
        }
        public int GetNumOrientador()
        {
            return numOrientador;
        }
        public override string QuemSouEu()
        {
            return "Orientador";
        }
        public override void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Nome|{0}", nome);          
            f.WriteLine("Genero|{0}",genero);
            f.WriteLine("NumeroOrientador|{0}", numOrientador);
            contacto.EscreverFicheiro(f);           
        }
        
        public override void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;


            linha = f.ReadLine();
            palavras = linha.Split(separador);
            nome = (palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            genero = (palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            numOrientador = Convert.ToInt32(palavras[1]);

            contacto.LerFicheiro(f);                        
                    
        }
    }
}
