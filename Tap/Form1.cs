using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tap
{
    public partial class Form1 : Form
    {
        Departamento RD = new Departamento();
        Empresa RE = new Empresa();
        public Form1()
        {
            
            InitializeComponent();
             Docente dc = new Docente();
            dc.SetUser("admin");
            dc.SetPass("1234");

            dc.SetNome("Administrador");
            RD.GetListaPessoa().Add(dc);

            Aluno al = new Aluno();
            al.SetUser("aluno");
            al.SetPass("aluno");

            al.SetNome("Aluno");
            RD.GetListaPessoa().Add(al);

            OrientadorEmpresa oe = new OrientadorEmpresa();
            oe.SetUser("orientador");
            oe.SetPass("orientador");

            oe.SetNome("Orientador");
            RD.GetListaPessoa().Add(oe);

            Empresa e = new Empresa();
            e.SetUser("empresa");
            e.SetPass("empresa");

            e.SetNome("Empresa");
            RD.GetListaEmpresa().Add(e);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Quem mesmo fechar a aplicação?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sair== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adicionarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AdicionarAluno adal = new AdicionarAluno(RD, 0);
            adal.ShowDialog();
            
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdicionarAluno adal = new AdicionarAluno(RD, 1);
            adal.ShowDialog();
        }

        private void adicionarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AdicionarDocente adc = new AdicionarDocente(RD, 0);
            adc.ShowDialog();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdicionarDocente adc = new AdicionarDocente(RD, 1);
            adc.ShowDialog();

        }

        private void orientadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdicionarEmpresa ademp = new AdicionarEmpresa(RD, 0);
            ademp.ShowDialog();
        }

        private void editarDadosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdicionarEmpresa ademp = new AdicionarEmpresa(RD, 1);
            ademp.ShowDialog();
        }

        private void empresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarOrientador ado = new AdicionarOrientador(RD, 0, RE);
            ado.ShowDialog();
        }

        private void adicionarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AdicionarProjeto adp = new AdicionarProjeto(RD, 0);
            adp.ShowDialog();
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdicionarProjeto adp = new AdicionarProjeto(RD, 1);
            adp.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream ass = new FileStream(@"dados.txt",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter f = new StreamWriter(ass);


            if (f != null)
            {
                RD.EscreverFicheiro(f);
                f.Close();
                ass.Close();
                MessageBox.Show("Ficheiro guardado!", "Já está!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader s = new StreamReader("Dados.txt");
            if (s!= null)
            {
                RD.LerFicheiro(s);
                s.Close();
            }

            MessageBox.Show("Ficheiro Carregado", "Está feito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            Login FL = new Login(RD);
            DialogResult asd = FL.ShowDialog();
            if (asd == DialogResult.Yes)
            {
                TTSL_LB_User.Text = RD.GetLogin();
            }

            if (RD.GetLogin() == "admin")
            {
                menuStrip1.Enabled = true;
            }

            if (RD.GetLogin() == "Empresa")
            {
                docenteToolStripMenuItem.Enabled = false;
                alunoToolStripMenuItem.Enabled = false;
            }

            if (RD.GetLogin() == "Orientador")
            {
                docenteToolStripMenuItem.Enabled = false;
                alunoToolStripMenuItem.Enabled = false;
            }

            if (RD.GetLogin() == "Aluno")
            {
                docenteToolStripMenuItem.Enabled = false;
                empresaToolStripMenuItem.Enabled = false;
                projetoToolStripMenuItem.Enabled = false;
                ficheiroToolStripMenuItem.Enabled = false;
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverAluno FRA = new RemoverAluno(RD);
            FRA.ShowDialog();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoverDocente FRC = new RemoverDocente(RD);
            FRC.ShowDialog(); 
        }

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RemoverEmpresa FRE = new RemoverEmpresa(RD);
            FRE.ShowDialog();
        }

        private void removerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RemoverOrientador FRO = new RemoverOrientador(RD);
            FRO.ShowDialog();
        }
    }
}
