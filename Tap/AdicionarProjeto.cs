using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tap
{
    public partial class AdicionarProjeto : Form
    {
        Departamento RD;
        Pessoa RP;
        Empresa RE;
        int t;
        public AdicionarProjeto(Departamento D, int escolha)
        {
            InitializeComponent();
            RD = D;
            t = escolha;

            foreach (Empresa ep in RD.GetListaEmpresa())
            {
                cb_NifEmpresa.Items.Add(ep.getNIF());
            }
            
            foreach(Pessoa p in RD.GetListaPessoa())
            {
                if (p.QuemSouEu() == "Aluno")
                {                  
                        cb_Alunos.Items.Add(p.GetNome());
                                      
                }
                else
                {
                    if (p.QuemSouEu() == "Docente")
                    {                        
                        cb_Docente.Items.Add(p.GetNome());
                    }
                }
            }

            
            
            

        }

        private void AdicionarProjeto_Load_1(object sender, EventArgs e)
        {

            if (txt_NomeProj.Text == "" || txt_NomeProj.Text == "")
                erro_nome.SetError(txt_NomeProj, "Introduza um nome.");
            else
                erro_nome.SetError(txt_NomeProj, "");

            if (txt_Objetivo.Text == "")
                erro_objetivo.SetError(txt_Objetivo, "Introduza o Objetivo.");
            else
                erro_objetivo.SetError(txt_Objetivo, "");

            if (txt_Descricao.Text == "")
                erro_descricao.SetError(txt_Descricao, "Introduza uma Descrição.");
            else
                erro_descricao.SetError(txt_Descricao, "");

            lb_notaFinal.Visible = false;
            txt_notaFinal.Visible = false;
            cb_NomeProj.Visible = false;
            foreach (Docente D in RD.GetListaPessoa().OfType<Docente>())
            {
                if (D.GetTipoDocente() == "Orientadores")
                {
                    lb_notaFinal.Enabled = true;
                    txt_notaFinal.Enabled = true;
                }

                else
                {
                    if (D.GetTipoDocente() == "Avaliadores")
                    {
                        lb_Descricao.Enabled = false;
                        Lb_aluno.Enabled = false;
                        lb_Descricao.Enabled = false;
                        lb_NIFEmpresa.Enabled = false;
                        lb_numero.Enabled = false;
                        Lb_Objetivo.Enabled = false;
                        lb_Orientador.Enabled = false;
                        //lb_TipoProjeto.Enabled = false;

                        txt_NomeProj.Enabled = false;
                        txt_Descricao.Enabled = false;
                        txt_numero.Enabled = false;
                        txt_Objetivo.Enabled = false;

                    }
                }
            }
        }

        private void bt_Guardar_Click_1(object sender, EventArgs e)
        {
            switch (t)
            {
                case 0:
                    bool aceite = false;
                    DialogResult adicionar = MessageBox.Show("Tem a certeza que pretende adicionar?", "Adicionar projecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Projeto P = new Projeto();

                    P.SetNome(txt_NomeProj.Text);
                    P.SetNumero(Convert.ToInt32(txt_numero.Text));
                    foreach (Empresa ai in RD.GetListaEmpresa())
                    {
                        if (ai.getNIF() == Convert.ToInt32(cb_NifEmpresa.Text))
                        {
                            P.SetNIF(Convert.ToInt32(cb_NifEmpresa.Text));
                            aceite = true;
                        }
                    }
                    P.SetObjetivo(txt_Objetivo.Text);
                    P.SetDescricao(txt_Descricao.Text);

                    if (aceite == true)
                    {
                        RD.GetListaProjeto().Add(P);
                        foreach (Aluno al in RD.GetListaPessoa().OfType<Aluno>())
                        {
                            if (al.GetNome() == cb_Alunos.Text)
                            {
                                P.EnviarEmailProjeto(al);
                            }
                        }



                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nao existe");
                    }



                    break;
                case 1:
                    DialogResult editar = MessageBox.Show("Tem a certeza que quer guardar as alteraçãoes?", "Guardar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    foreach (Projeto PR in RD.GetListaProjeto())
                    {
                        if (cb_NomeProj.Text == PR.GetAluno().ToString())
                        //(cb_Nome.Text == AL.GetNome())
                        {
                            PR.GetAluno().SetNome(txt_NomeProj.Text);
                            //AL.GetMoradaP().GetCodPostal().SetCampo1(Convert.ToInt32(txt_Campo1.Text));
                            //AL.GetMoradaP().GetCodPostal().SetCampo2(Convert.ToInt32(txt_campo2.Text));
                            this.Close();

                        }
                    }
                    DialogResult change = MessageBox.Show("Tem a certeza que quer guardar as alteraçãoes?", "Guardar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                default:
                    break;
            }
        }

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_NomeProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (t)
            {
                case 0:
                    cb_NomeProj.Visible = false;
                    break;
                case 1:
                    foreach (Projeto ad in RD.GetListaProjeto())
                    {
                        if(cb_NomeProj.Text== ad.GetNome())
                        {
                            txt_Descricao.Text = ad.GetDescricao();
                            txt_Objetivo.Text = ad.GetObjetivo();
                        }
                    }
                    txt_NomeProj.Visible = false;
                    txt_Descricao.Enabled = false;
                    txt_Objetivo.Enabled = false;
                    //meti a descriçao e o objetivo Disable porque nao alteram quando se edita


                    break;
                default:
                    break;
            }
        }

        

        private void txt_NomeProj_Leave(object sender, EventArgs e)
        {
            if (txt_NomeProj.Text == "")
            {
                txt_NomeProj.Font = new Font(txt_NomeProj.Font.FontFamily, 7);
                txt_NomeProj.Text = "Introduza o nome...";
                txt_NomeProj.ForeColor = Color.Gray;
            }
        }
        private void txt_NomeProj_Enter(object sender, EventArgs e)
        {
            if (txt_NomeProj.Text == "Introduza o nome do projeto...")
            {
                txt_NomeProj.Text = "";
                txt_NomeProj.Font = new Font(txt_NomeProj.Font.FontFamily, 8);
                txt_NomeProj.ForeColor = Color.Black;
            }
        }

        private void cb_Alunos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cb_NifEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            RE = RD.ProcuraEmpresa(Convert.ToInt32(cb_NifEmpresa.SelectedItem)); 

            foreach (OrientadorEmpresa OE in RE.GetListaOrientadoresEmpresa()) 
            {
                cb_Orientador.Items.Add(OE.GetNumOrientador());
            }
        }
    }
}
