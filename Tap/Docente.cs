using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class Docente:Pessoa
    {
        private string habilitacoes;
        private int nDocente;
        private string disciplinas;
        private string tipo_docente;

        public Docente()
        {

        }
        public void SetTipoDocente(string td)
        {
            tipo_docente = td;
        }
        public string GetTipoDocente()
        {
            return tipo_docente;
        }

        public void SetHabilitacoes(string h)
        {
            habilitacoes = h;
        }
        public string GetHbilitacoes()
        {
            return habilitacoes;
        }
        public void SetNDocente(int n)
        {
            nDocente = n;
        }
        public int GetNDocente()
        {
            return nDocente;
        }
        public override string QuemSouEu()
        {
            return "Docente";
        }

        public void SetDisciplinas(string d)
        {
            disciplinas = d;
        }
        public string GetDisciplinas()
        {
            return disciplinas;
        }

        
        

        public override void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Nome|{0}", nome);
            f.WriteLine("Genero|{0}", genero);
            contacto.EscreverFicheiro(f);       
            f.WriteLine("NumDocente|{0}", nDocente);
            f.WriteLine("Disciplinas|{0}", disciplinas);
            f.WriteLine("habilitações|{0}", habilitacoes);
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

            contacto.LerFicheiro(f);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            nDocente = Convert.ToInt32(palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            disciplinas = (palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            habilitacoes = (palavras[1]);

        }
    }
}
