using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class Empresa
    {
        string nome;
        int nif;
        string actividade;
        Contactos contacto;
        int FAX;
        string pass;
        string username;
        List<OrientadorEmpresa> listaOrientador;



        public Empresa()
        {

            contacto = new Contactos();
            listaOrientador = new List<OrientadorEmpresa>();

        }
        public void SetUser(string u)
        {
            username = u;
        }

        public string GetUser()
        {
            return username;
        }

        public void SetPass(string p)
        {
            pass = p;
        }

        public string GetPass()
        {
            return pass;
        }
        public void SetNome(string n)
        {
            nome = n;
        }
        public string GetNome()
        {
            return nome;
        }

        public void Setnif(int N)
        {
            nif = N;
        }
        public int getNIF()
        {
            return nif;
        }

        public void SetActividade(string a)
        {
            actividade = a;
        }
        public string GetActividade()
        {
            return actividade;
        }


        public Contactos GetContacto()
        {
            return contacto;
        }

        public void SetFAX(int F)
        {
            FAX = F; ;
        }
        public int GetFAX()
        {
            return FAX;
        }

        public List<OrientadorEmpresa> GetListaOrientadoresEmpresa()
        {
            return listaOrientador;
        }
        
        public OrientadorEmpresa ProcuraOrientador(int no)
        {
            foreach (OrientadorEmpresa O in listaOrientador)
            {
                if (O.GetNumOrientador() == no)
                    return O;
            }
            return null;
        }


        public  void escreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Nome|{0}", nome);
            f.WriteLine("NIF|{0}", nif);
            f.WriteLine("Atividade|{0}", actividade);
            contacto.EscreverFicheiro(f);
            f.WriteLine("FAX|{0}", FAX);

        }

        public void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            nome = (palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            nif = Convert.ToInt32(palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            actividade = (palavras[1]);

            contacto.LerFicheiro(f);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            FAX = Convert.ToInt32(palavras[1]);

        }
    }
}
