using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class Aluno : Pessoa
    {
        private string curso;
        private int ano;
        private int nAluno;

        public Aluno()
        {
        }

        public void SetCurso(string c)
        {
            curso = c;
        }
        public string GetCurso()
        {
            return curso;
        }

        public void SetAno(int a)
        {
            ano = a;
        }
        public int GetAno()
        {
            return ano;
        }
        public void SetNAluno(int n)
        {
            nAluno = n;
        }
        public int GetNAluno()
        {
            return nAluno;
        }

        public override string QuemSouEu()
        {
            return "Aluno";
        }

        public override void EscreverFicheiro(StreamWriter f)
        {
            
            base.EscreverFicheiro(f);

            f.WriteLine("curso|{0}", curso);            
            f.WriteLine("Ano|{0}", ano);
            f.WriteLine("Nº Aluno|{0}", nAluno);
            
            
        }

        public override void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;
            
            base.LerFicheiro(f);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            curso = palavras[1];

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            ano = Convert.ToInt32(palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            nAluno = Convert.ToInt32(palavras[1]);
            
            
        }

    }
}
