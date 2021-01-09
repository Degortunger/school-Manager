using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Tap
{
    public class Projeto
    {
        protected string nome;
        protected Empresa E;
        protected string objetivo;
        protected Aluno aluno;
        protected int NIF;
        protected int numero;
        protected string descricao;
        protected List<OrientadorEmpresa> ListaOrientadorEmpresa;
        protected List<Docente> ListaOrientadorEscola;



        public Projeto()
        {
            nome = "";
            E = null;
            objetivo = "";
            aluno = null;
            descricao = "";

            ListaOrientadorEmpresa = new List<OrientadorEmpresa>();
            ListaOrientadorEscola = new List<Docente>();
        }

        public void SetNome(string n)
        {
            nome = n;
        }
        public string GetNome()
        {
            return nome;
        }

        public Empresa GetEmpresa()
        {
            return E;
        }

        public Aluno GetAluno()
        {
            return aluno;
        }
        public void SetNIF(int n)
        {
            NIF = n;
        }
        public int GetNIF()
        {
            return NIF;
        }

        public void SetObjetivo(string o)
        {
            objetivo = o;
        }
        public string GetObjetivo()
        {
            return objetivo;
        }
        public void SetNumero(int n)
        {
            numero = n;
        }
        public int GetNumero()
        {
            return numero;
        }
        public void SetDescricao(string d)
        {
            descricao = d;
        }
        public string GetDescricao()
        {
            return descricao;
        }

        public List<OrientadorEmpresa> GetOrientadorEmpresa()
        {
            return ListaOrientadorEmpresa;
        }

        public List<Docente> GetDocente()
        {
            return ListaOrientadorEscola;
        }

        public virtual void EscreverFicheiro(StreamWriter f)
        {
            f.WriteLine("Nome|{0}", nome);
            f.WriteLine("Objetivo|{0}", objetivo);
            E.escreverFicheiro(f);
            aluno.EscreverFicheiro(f);
            f.WriteLine("Descrição|{0}", descricao);
            
        }

        public void LerFicheiro(StreamReader f)
        {
            {
                string[] palavras = new string[2];
                char separador = '|';
                string linha;

                linha = f.ReadLine();
                palavras = linha.Split(separador);
                nome = palavras[1];

                linha = f.ReadLine();
                palavras = linha.Split(separador);
                descricao = palavras[1];

                aluno.LerFicheiro(f);

                E.LerFicheiro(f);
            }
        }

        public void EnviarEmailProjeto(Aluno ca)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com"); //ver credenciais do gmail

                mail.From = new MailAddress("projetotapiu@outlook.pt");
                mail.To.Add(ca.GetContacto().GetEmail());
                mail.Subject = "Projeto atribuído";
                mail.Body = "Olá \n Você foi adicionado num novo projeto";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("projetotapiu@outlook.pt", "tapiu2017"); //criar email e pass do mail
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email enviado");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
