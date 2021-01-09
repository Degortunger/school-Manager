using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class Departamento
    {
        List<Pessoa> listapessoa;
        List<Empresa> ListaEmpresa;
        List<Projeto> ListaProjetos;
        protected string nome_login;

        public Departamento()
        {
            listapessoa = new List<Pessoa>();
            ListaEmpresa = new List<Empresa>();
            ListaProjetos = new List<Projeto>();
        }
        public string GetLogin()
        {
            return nome_login;
        }

        public void SetLogin(string l)
        {
            nome_login = l;
        }

        public List<Pessoa> GetListaPessoa()
        {
            return listapessoa;
        }

        public List<Empresa> GetListaEmpresa()
        {
            return ListaEmpresa;
        }

        public List<Projeto> GetListaProjeto()
        {
            return ListaProjetos;
        }

        public Aluno ProcuraAluno(int a)
        {
            foreach (Pessoa P in listapessoa)
            {
                if (P.QuemSouEu() == "Aluno")
                {
                    Aluno A = (Aluno)P;
                    if (A.GetNAluno() == a)
                    {
                        return A;
                    }
                }


            }
            return null;
        }

        public Docente ProcuraDocente(int d)
        {
            foreach (Pessoa P in listapessoa)
            {
                if (P.QuemSouEu() == "Docente")
                {
                    Docente D = (Docente)P;
                    if (D.GetNDocente() == d)
                    {
                        return D;
                    }
                }


            }
            return null;
        }

        public Empresa ProcuraEmpresa(int e)
        {
            foreach (Empresa ep in ListaEmpresa)
            {
                Empresa EE = (Empresa)ep;
                    if (EE.getNIF() == e)

                    {
                        return EE;
                    }
                


            }
            return null;
        }

        public void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("NumerodePessoas|{0}", listapessoa.Count);



            foreach (Pessoa D in listapessoa)
            {
                f.WriteLine("TipoDePessoa|{0}", D.QuemSouEu());

                D.EscreverFicheiro(f);

            }

            f.WriteLine("Empresa|{0}", ListaEmpresa.Count);
            foreach (Empresa E in ListaEmpresa)
            {
                E.escreverFicheiro(f);
            }

            f.WriteLine("Projeto|{0}", ListaProjetos.Count);
            foreach (Projeto P in ListaProjetos)
            {
                P.EscreverFicheiro(f);
            }

           
        }

        public void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            int np = Convert.ToInt32(palavras[1]);

            Pessoa P = null;
            for (int i = 0; i < np; i++)
            {
                linha = f.ReadLine();
                palavras = linha.Split(separador);
                string tipo = palavras[1];

                switch (tipo)
                {
                    case "Aluno":
                        P = new Aluno();
                        break;
                    case "Docente":
                        P = new Docente();
                        break;

                }
                if (P != null)
                {
                    P.LerFicheiro(f);
                    listapessoa.Add(P);
                }
            }

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            int ne = Convert.ToInt32(palavras[1]);

            for (int i = 0; i < ne; i++)
            {
                Empresa EM = new Empresa();
                EM.LerFicheiro(f);
                ListaEmpresa.Add(EM);
            }

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            int npr = Convert.ToInt32(palavras[1]);



            for (int i = 0; i < npr; i++)
            {
                Projeto PR = new Projeto();
                PR.GetEmpresa().LerFicheiro(f);
                ListaProjetos.Add(PR);
            }

          
        }

    }
}
