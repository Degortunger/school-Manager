using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tap
{
   public  class Contactos
    {
        int Telefone;
        string Email;


        public Contactos()
        {

        }

        public void SetTelefone(int t)
        {
            Telefone = t;
        }
        public int GetTelefone()
        {
            return Telefone;
        }

        public void SetEmail(string e)
        {
            Email = e;
        }
        public string GetEmail()
        {
            return Email;
        }

        public void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Telefone|{0}", Telefone);
            f.WriteLine("Email|{0}", Email);
        }

        public void LerFicheiro(StreamReader f)
        {
            string[] palavras = new string[2];
            char separador = '|';
            string linha;

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            Telefone = Convert.ToInt32(palavras[1]);

            linha = f.ReadLine();
            palavras = linha.Split(separador);
            Email = palavras[1];
        }

    }
}
