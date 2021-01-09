using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
    public class Pessoa
    {

        protected string nome;
        protected string genero;
        protected int NIF;
        protected Morada morada;
        protected string foto;
        protected DateTime datanascimento;
        protected Contactos contacto;
        protected string username;
        protected string pass;

        public Pessoa()
        {

            morada = new Morada();
            contacto = new Contactos();
            datanascimento = DateTime.Now;
        }

        public void SetNome(string n)
        {
            nome = n;
        }

        public string GetNome()
        {
            return nome;
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
        public void SetNIF(int nif)
        {
            NIF = nif;
        }

        public int GetNIF()
        {
            return NIF;
        }
        public void SetGenero(string g)
        {
            genero = g; 
        }

        public string GetGenero()
        {
            return genero;
        }
        public void SetFoto(string n)
        {
            foto = n;
        }

        public string GetFoto()
        {
            return foto;
        }

        public Morada GetMoradaP()
        {
            return morada;
        }

        public DateTime GetDataNascimento()
        {
            return datanascimento;
        }

        public void SetDataNascimento(DateTime d)
        {
            datanascimento = d;
        }

        public Contactos GetContacto()
        {
            return contacto;
        }
        public virtual string QuemSouEu()
        {
            return "Pessoa";
        }

        public virtual void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Nome|{0}", nome);
            f.WriteLine("Genero|{0}", genero);
            f.WriteLine("Foto|{0}", foto);
            f.WriteLine("NIF|{0}",NIF);
            morada.EscreverFicheiro(f);
            f.WriteLine("Data|{0}", datanascimento.ToShortDateString());
            contacto.EscreverFicheiro(f);
        }
        public virtual void LerFicheiro(StreamReader f)
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
            foto = (palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            NIF = Convert.ToInt32(palavras[1]);

            morada.LerFicheiro(f);
        


            linha = f.ReadLine();
            palavras = linha.Split(separador);
            datanascimento = Convert.ToDateTime(palavras[1]);

            contacto.LerFicheiro(f);
        }


    }

}
