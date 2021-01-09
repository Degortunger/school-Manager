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
    public partial class AdicionarAluno : Form
    {
        
        Departamento RD;
        int t;
        string path;
        public AdicionarAluno(Departamento D, int escolha)
        {

            InitializeComponent();
            RD = D;
            t = escolha;
            path = @"..\..\Fotos\";

        }      

        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.InitialDirectory = @"C:\";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                ptb_foto.Image = Image.FromFile(@caixa.FileName);
                ptb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_generoMasculino_Click(object sender, EventArgs e)
        {

        }

        

        private void AdicionarAluno_Load_1(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_nome.Text == "")
                erro_nome.SetError(txt_nome, "Introduza um nome.");
            else
                erro_nome.SetError(txt_nome, "");

            if (txt_NIF.Text == "000000000")
                erro_contribuinte.SetError(txt_NIF, "Introduza um NIF.");
            else
                erro_contribuinte.SetError(txt_NIF, "");

            if (txt_Email.Text == "")
                erro_email.SetError(txt_Email, "Introduza um E-mail.");
            else
                erro_email.SetError(txt_Email, "");

            if (txt_Telefone.Text == "")
                erro_telefone.SetError(txt_Telefone, "Introduza um Telefone.");
            else
                erro_telefone.SetError(txt_Telefone, "");

            if (txt_Rua.Text == "")
                erro_rua.SetError(txt_Rua, "Introduza uma Rua.");
            else
                erro_rua.SetError(txt_Rua, "");

            if (txt_localidade.Text == "")
                erro_localidade.SetError(txt_localidade, "Introduza uma Localidade.");
            else
                erro_localidade.SetError(txt_localidade, "");

            if ( txt_Campo1.Text== "" && txt_Campo2.Text == "")
                erro_codpostal.SetError(txt_Campo2, "Introduza um Codigo Postal.");
            else
                erro_codpostal.SetError(txt_localidade, "");

            if (txt_Numero.Text == "")
                erro_numero.SetError(txt_Numero, "Introduza um Numero.");
            else
                erro_numero.SetError(txt_Numero, "");

            /* if (rb_Feminino=false && rb_Masculino= false)
                 erro_sexo.SetError("Selecione um Genero");
             else
                 erro_sexo.SetError("");

            /* if (rb_TDM = false && rb_EI = false)
                 erro_sexo.SetError("Selecione um Genero");
             else
                 erro_sexo.SetError(""); */


            switch (t)
            {
                case 0:
                    txt_nome.ForeColor = Color.Gray;
                    txt_nome.Font = new Font(txt_nome.Font.FontFamily, 7);
                    txt_nome.Text = "Introduza o nome do aluno...";
                    this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
                    this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);

                    txt_NIF.ForeColor = Color.Gray;
                    txt_NIF.Font = new Font(txt_nome.Font.FontFamily, 7);
                    txt_NIF.Text = "000000000";
                    this.txt_NIF.Leave += new System.EventHandler(this.txt_NIF_Leave);
                    this.txt_NIF.Enter += new System.EventHandler(this.txt_NIF_Enter);

                    txt_Email.ForeColor = Color.Gray;
                    txt_Email.Font = new Font(txt_Email.Font.FontFamily, 7);
                    txt_Email.Text = "exemplo@dominio.com";
                    this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
                    this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);

                    txt_Telefone.ForeColor = Color.Gray;
                    txt_Telefone.Font = new Font(txt_Telefone.Font.FontFamily, 7);
                    txt_Telefone.Text = "900000000";
                    this.txt_Telefone.Leave += new System.EventHandler(this.txt_Telefone_Leave);
                    this.txt_Telefone.Enter += new System.EventHandler(this.txt_Telefone_Enter);

                    txt_Rua.ForeColor = Color.Gray;
                    txt_Rua.Font = new Font(txt_Rua.Font.FontFamily, 7);
                    txt_Rua.Text = "Introduzir rua...";
                    this.txt_Rua.Leave += new System.EventHandler(this.txt_Rua_Leave);
                    this.txt_Rua.Enter += new System.EventHandler(this.txt_Rua_Enter);

                    txt_localidade.ForeColor = Color.Gray;
                    txt_localidade.Font = new Font(txt_localidade.Font.FontFamily, 7);
                    txt_localidade.Text = "Introduzir localidade...";
                    this.txt_localidade.Leave += new System.EventHandler(this.txt_localidade_Leave);
                    this.txt_localidade.Enter += new System.EventHandler(this.txt_localidade_Enter);

                    txt_Campo1.ForeColor = Color.Gray;
                    txt_Campo1.Font = new Font(txt_Campo1.Font.FontFamily, 7);
                    txt_Campo1.Text = "0000";
                    this.txt_Campo1.Leave += new System.EventHandler(this.txt_Campo1_Leave);
                    this.txt_Campo1.Enter += new System.EventHandler(this.txt_Campo1_Enter);

                    txt_Campo2.ForeColor = Color.Gray;
                    txt_Campo2.Font = new Font(txt_Campo2.Font.FontFamily, 7);
                    txt_Campo2.Text = "000";
                    this.txt_Campo2.Leave += new System.EventHandler(this.txt_Campo2_Leave);
                    this.txt_Campo2.Enter += new System.EventHandler(this.txt_Campo2_Enter);

                    txt_Numero.ForeColor = Color.Gray;
                    txt_Numero.Font = new Font(txt_Numero.Font.FontFamily, 7);
                    txt_Numero.Text = "00000";
                    this.txt_Numero.Leave += new System.EventHandler(this.txt_Numero_Leave);
                    this.txt_Numero.Enter += new System.EventHandler(this.txt_Numero_Enter);
                    cb_Nome.Visible = false;//tem uma combobox para quando se editar escolher o aluno por nome

                    break;

                case 1:

                    txt_nome.Visible = false;
                    rb_Masculino.Visible = false;
                    rb_Feminino.Visible = false;
                    txt_NIF.Enabled = false;
                    gp_DadosEscolares.Enabled = false;
                    foreach (Pessoa p in RD.GetListaPessoa())
                    {

                        if (p.QuemSouEu() == "Aluno")
                        {
                            cb_Nome.Items.Add(p.GetNome());

                        }
                    }

                    break;

                default:
                    break;

            }
           
         
        }
        private void bt_Guardar_Click_1(object sender, EventArgs e)
        {
            
            switch (t)
            {
                case 0:
                    DialogResult adicionar = MessageBox.Show("Tem a certeza que pretende adicionar?", "Adicionar aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Aluno A = new Aluno();
                    A.SetNome(txt_nome.Text);
                    A.SetDataNascimento(dtp_datanascimento.Value);
                    A.GetMoradaP().SetRua(txt_Rua.Text);
                    A.GetMoradaP().SetLocalidade(txt_localidade.Text);
                    A.GetMoradaP().GetCodPostal().SetCampo1(Convert.ToInt32(txt_Campo1.Text));
                    A.GetMoradaP().GetCodPostal().SetCampo2(Convert.ToInt32(txt_Campo2.Text));
                    A.GetContacto().SetTelefone(Convert.ToInt32(txt_Telefone.Text));
                    A.GetContacto().SetEmail(txt_Email.Text);
                    A.SetNAluno(Convert.ToInt32(txt_Numero.Text));
                    A.SetNIF(Convert.ToInt32(txt_NIF.Text));
                    if (rb_Masculino.Checked == true)
                    {
                        A.SetGenero("Masculino");
                    }
                    else
                    {
                        if (rb_Feminino.Checked == true)
                        {
                            A.SetGenero("Feminino");
                        }
                    }

                    if (rb_TDM.Checked == true)
                    {
                        A.SetCurso("Tecnologias e Design de Multimédia");
                    }
                    else
                    {
                        if (rb_EI.Checked == true)
                        {
                            A.SetCurso("Engenharia Informatica");
                        }
                    }

                    string n_imagem = path + "foto_Aluno_" + A.GetNome() + ".jpg";
                    A.SetFoto("foto_Aluno_" + A.GetNome() + ".jpg");
                    ptb_foto.Image.Save(n_imagem);


                    RD.GetListaPessoa().Add(A);
                    this.Close();
                    break;

                case 1:
                    txt_nome.Visible = false;
                    foreach (Aluno AL in RD.GetListaPessoa())
                    {
                        if (cb_Nome.Text == AL.GetNome())
                        {
                            AL.GetMoradaP().SetRua(txt_Rua.Text);
                            AL.GetMoradaP().SetLocalidade(txt_localidade.Text);
                            AL.GetMoradaP().GetCodPostal().SetCampo1(Convert.ToInt32(txt_Campo1.Text));
                            AL.GetMoradaP().GetCodPostal().SetCampo2(Convert.ToInt32(txt_Campo2.Text));
                            AL.GetContacto().SetTelefone(Convert.ToInt32(txt_Telefone.Text));
                            AL.GetContacto().SetEmail(txt_Email.Text);
                            

                            string ne_imagem = path + "foto_Aluno_" + AL.GetNome() + ".jpg";
                            AL.SetFoto("foto_Aluno_" + AL.GetNome() + ".jpg");
                            ptb_foto.Image.Save(ne_imagem);
                        }
                    }
                    DialogResult editar = MessageBox.Show("Tem a certeza que quer guardar as alteraçãoes?", "Guardar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    this.Close();
                    break;
            }
        }

        private void cb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach( Aluno ai in RD.GetListaPessoa().OfType<Aluno>())
            {

                if(cb_Nome.Text == ai.GetNome())
                {
                    txt_Email.Text = ai.GetContacto().GetEmail();
                    txt_localidade.Text = ai.GetMoradaP().GetLocalidade();
                    txt_Numero.Text = ai.GetNAluno().ToString();
                    txt_NIF.Text = ai.GetNIF().ToString();
                    txt_Rua.Text = ai.GetMoradaP().GetRua();
                    txt_Telefone.Text = (ai.GetContacto().GetTelefone()).ToString();
                    txt_nome.Text = ai.GetNome();
                    txt_Campo1.Text = ai.GetMoradaP().GetCodPostal().GetCampo1().ToString();
                    txt_Campo2.Text = ai.GetMoradaP().GetCodPostal().GetCampo2().ToString();
                }
                
            }
        }

        private void gp_DadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Inserir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.InitialDirectory = @"C:\Users\Public\Imagens\";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                ptb_foto.Image = Image.FromFile(@caixa.FileName);
                ptb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                txt_nome.Font = new Font(txt_nome.Font.FontFamily, 7);
                txt_nome.Text = "Introduza o nome do aluno...";
                txt_nome.ForeColor = Color.Gray;
            }
        }
        private void txt_nome_Enter(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Introduza o nome do aluno...")
            {
                txt_nome.Text = "";
                txt_nome.Font = new Font(txt_nome.Font.FontFamily, 8);
                txt_nome.ForeColor = Color.Black;
            }
        }
        
        private void txt_NIF_Leave(object sender, EventArgs e)
        {
            if (txt_NIF.Text == "")
            {
                txt_NIF.Font = new Font(txt_nome.Font.FontFamily, 7);
                txt_NIF.Text = "000000000";
                txt_NIF.ForeColor = Color.Gray;
            }
        }
        private void txt_NIF_Enter(object sender, EventArgs e)
        {
            if (txt_NIF.Text == "000000000")
            {
                txt_NIF.Text = "";
                txt_NIF.Font = new Font(txt_NIF.Font.FontFamily, 8);
                txt_NIF.ForeColor = Color.Black;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                txt_Email.Font = new Font(txt_Email.Font.FontFamily, 7);
                txt_Email.Text = "exemplo@dominio.com";
                txt_Email.ForeColor = Color.Gray;
            }
        }
        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "exemplo@dominio.com")
            {
                txt_Email.Text = "";
                txt_Email.Font = new Font(txt_Email.Font.FontFamily, 8);
                txt_Email.ForeColor = Color.Black;
            }
        }

        private void txt_Telefone_Leave(object sender, EventArgs e)
        {
            if (txt_Telefone.Text == "")
            {
                txt_Telefone.Font = new Font(txt_Telefone.Font.FontFamily, 7);
                txt_Telefone.Text = "900000000";
                txt_Telefone.ForeColor = Color.Gray;
            }
        }
        private void txt_Telefone_Enter(object sender, EventArgs e)
        {
            if (txt_Telefone.Text == "900000000")
            {
                txt_Telefone.Text = "";
                txt_Telefone.Font = new Font(txt_Telefone.Font.FontFamily, 8);
                txt_Telefone.ForeColor = Color.Black;
            }
        }

        private void txt_Rua_Leave(object sender, EventArgs e)
        {
            if (txt_Rua.Text == "")
            {
                txt_Rua.Font = new Font(txt_Rua.Font.FontFamily, 7);
                txt_Rua.Text = "Introduzir rua...";
                txt_Rua.ForeColor = Color.Gray;
            }
        }
        private void txt_Rua_Enter(object sender, EventArgs e)
        {
            if (txt_Rua.Text == "Introduzir rua...")
            {
                txt_Rua.Text = "";
                txt_Rua.Font = new Font(txt_Rua.Font.FontFamily, 8);
                txt_Rua.ForeColor = Color.Black;
            }
        }

        private void txt_localidade_Leave(object sender, EventArgs e)
        {
            if (txt_localidade.Text == "")
            {
                txt_localidade.Font = new Font(txt_localidade.Font.FontFamily, 7);
                txt_localidade.Text = "Introduzir localidade...";
                txt_localidade.ForeColor = Color.Gray;
            }
        }
        private void txt_localidade_Enter(object sender, EventArgs e)
        {
            if (txt_localidade.Text == "Introduzir localidade...")
            {
                txt_localidade.Text = "";
                txt_localidade.Font = new Font(txt_localidade.Font.FontFamily, 8);
                txt_localidade.ForeColor = Color.Black;
            }
        }

        private void txt_Campo1_Leave(object sender, EventArgs e)
        {
            if (txt_Campo1.Text == "")
            {
                txt_Campo1.Font = new Font(txt_Campo1.Font.FontFamily, 7);
                txt_Campo1.Text = "0000";
                txt_Campo1.ForeColor = Color.Gray;
            }
        }
        private void txt_Campo1_Enter(object sender, EventArgs e)
        {
            if (txt_Campo1.Text == "0000")
            {
                txt_Campo1.Text = "";
                txt_Campo1.Font = new Font(txt_Campo1.Font.FontFamily, 8);
                txt_Campo1.ForeColor = Color.Black;
            }
        }

        private void txt_Campo2_Leave(object sender, EventArgs e)
        {
            if (txt_Campo2.Text == "")
            {
                txt_Campo2.Font = new Font(txt_Campo2.Font.FontFamily, 7);
                txt_Campo2.Text = "000";
                txt_Campo2.ForeColor = Color.Gray;
            }
        }
        private void txt_Campo2_Enter(object sender, EventArgs e)
        {
            if (txt_Campo2.Text == "000")
            {
                txt_Campo2.Text = "";
                txt_Campo2.Font = new Font(txt_Campo2.Font.FontFamily, 8);
                txt_Campo2.ForeColor = Color.Black;
            }
        }

        private void txt_Numero_Leave(object sender, EventArgs e)
        {
            if (txt_Numero.Text == "")
            {
                txt_Numero.Font = new Font(txt_Numero.Font.FontFamily, 7);
                txt_Numero.Text = "00000";
                txt_Numero.ForeColor = Color.Gray;
            }
        }
        private void txt_Numero_Enter(object sender, EventArgs e)
        {
            if (txt_Numero.Text == "00000")
            {
                txt_Numero.Text = "";
                txt_Numero.Font = new Font(txt_Numero.Font.FontFamily, 8);
                txt_Numero.ForeColor = Color.Black;
            }
        }

    }
}
