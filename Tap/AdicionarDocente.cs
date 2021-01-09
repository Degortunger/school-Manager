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
    public partial class AdicionarDocente : Form
    {
        Departamento RD;
        int i;
        string path;
        public AdicionarDocente(Departamento D, int escolha)
        {
            InitializeComponent();
            RD = D;
            i = escolha;
            path = @"..\..\Fotos\";
        }


        private void AdicionarDocente_Load(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_nome.Text == "")
                erro_nomedocente.SetError(txt_nome, "Introduza um nome.");
            else
                erro_nomedocente.SetError(txt_nome, "");

            if (txt_Email.Text == "")
                erro_emaildocente.SetError(txt_Email, "Introduza um E-mail.");
            else
                erro_emaildocente.SetError(txt_Email, "");

            if (txt_Telefone.Text == "")
                erro_telefonedocente.SetError(txt_Telefone, "Introduza um Telefone.");
            else
                erro_telefonedocente.SetError(txt_Telefone, "");

            if (txt_Numero.Text == "")
                erro_numerodocente.SetError(txt_Numero, "Introduza um Numero.");
            else
                erro_numerodocente.SetError(txt_Numero, "");

            if (txt_Disciplina.Text == "")
                erro_disciplinadocente.SetError(txt_Disciplina, "Introduza uma Disciplina.");
            else
                erro_disciplinadocente.SetError(txt_Disciplina, "");

            if (txt_habilitacoes.Text == "")
                erro_habilitacoes.SetError(txt_habilitacoes, "Introduza Habilitaçôes.");
            else
                erro_habilitacoes.SetError(txt_habilitacoes, "");


            switch (i)
            {
                case 0:
                    txt_nome.ForeColor = Color.Gray;
            txt_nome.Font = new Font(txt_nome.Font.FontFamily, 7);
            txt_nome.Text = "Introduza o nome do docente...";
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);

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

            txt_Numero.ForeColor = Color.Gray;
            txt_Numero.Font = new Font(txt_Numero.Font.FontFamily, 7);
            txt_Numero.Text = "00000";
            this.txt_Numero.Leave += new System.EventHandler(this.txt_Numero_Leave);
            this.txt_Numero.Enter += new System.EventHandler(this.txt_Numero_Enter);
            
            txt_Disciplina.ForeColor = Color.Gray;
            txt_Disciplina.Font = new Font(txt_Disciplina.Font.FontFamily, 7);
            txt_Disciplina.Text = "Introduza disciplina...";
            this.txt_Disciplina.Leave += new System.EventHandler(this.txt_Disciplina_Leave);
            this.txt_Disciplina.Enter += new System.EventHandler(this.txt_Disciplina_Enter);

            txt_Disciplina.ForeColor = Color.Gray;
            txt_Disciplina.Font = new Font(txt_Disciplina.Font.FontFamily, 7);
            txt_Disciplina.Text = "Introduza disciplina...";
            this.txt_Disciplina.Leave += new System.EventHandler(this.txt_Disciplina_Leave);
            this.txt_Disciplina.Enter += new System.EventHandler(this.txt_Disciplina_Enter);

            txt_habilitacoes.ForeColor = Color.Gray;
            txt_habilitacoes.Font = new Font(txt_Disciplina.Font.FontFamily, 7);
            txt_habilitacoes.Text = "Introduza habilitações...";
            this.txt_habilitacoes.Leave += new System.EventHandler(this.txt_habilitacoes_Leave);
            this.txt_habilitacoes.Enter += new System.EventHandler(this.txt_habilitacoes_Enter);
                    cb_Nome.Visible = false;
                    break;

                case 1:
                    foreach (Docente ad in RD.GetListaPessoa().OfType<Docente>())
                    {
                        cb_Nome.Items.Add(ad.GetNome());
                    }

                    txt_nome.Visible = false;
                    rb_Masculino.Enabled = false;
                    rb_Feminino.Enabled = false;
                    txt_Numero.Visible = false;

                    break;

                default:
                    break;

            }
           
        }



        private void bt_Guardar_Click_1(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    DialogResult adicionar = MessageBox.Show("Tem a certeza que pretende adicionar?", "Adicionar docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Docente D = new Docente();
                    D.SetNome(txt_nome.Text);
                    D.GetContacto().SetTelefone(Convert.ToInt32(txt_Telefone.Text));
                    D.GetContacto().SetEmail(txt_Email.Text);
                    D.SetHabilitacoes(txt_habilitacoes.Text);
                    D.SetDisciplinas(txt_Disciplina.Text);
                    D.SetNDocente(Convert.ToInt32(txt_Numero.Text));
                    
                    if (rb_Masculino.Checked == true)
                    {
                        D.SetGenero("Masculino");
                    }
                    else
                    {
                        if (rb_Feminino.Checked == true)
                        {
                            D.SetGenero("Feminino");
                        }
                    }

                    string n_imagem = path + "foto_Docente_" + D.GetNome() + ".jpg";
                    D.SetFoto("foto_Docente_" + D.GetNome() + ".jpg");
                    ptb_foto.Image.Save(n_imagem);
                    

                    RD.GetListaPessoa().Add(D);
                    this.Close();
                    break;

                case 1:

                    foreach (Docente DC in RD.GetListaPessoa())
                    {
                        if (cb_Nome.Text == RD.GetListaPessoa().ToString())
                        {

                            
                            DC.GetContacto().SetTelefone(Convert.ToInt32(txt_Telefone.Text));
                            DC.GetContacto().SetEmail(txt_Email.Text);
                            
                            DC.SetHabilitacoes(txt_habilitacoes.Text);
                            DC.SetDisciplinas(txt_Disciplina.Text);
                            
                            string ne_imagem = path + "foto_Docente_" + DC.GetNome() + ".jpg";
                            DC.SetFoto("foto_Docente_" + DC.GetNome() + ".ico");
                            ptb_foto.Image.Save(ne_imagem);
                            this.Close();
                        }
                    }



                    break;
            }
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                txt_nome.Font = new Font(txt_nome.Font.FontFamily, 7);
                txt_nome.Text = "Introduza o nome do docente...";
                txt_nome.ForeColor = Color.Gray;
            }
        }
        private void txt_nome_Enter(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Introduza o nome do docente...")
            {
                txt_nome.Text = "";
                txt_nome.Font = new Font(txt_nome.Font.FontFamily, 8);
                txt_nome.ForeColor = Color.Black;
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

        private void txt_Disciplina_Leave(object sender, EventArgs e)
        {
            if (txt_Disciplina.Text == "")
            {
                txt_Disciplina.Font = new Font(txt_Disciplina.Font.FontFamily, 7);
                txt_Disciplina.Text = "Introduza disciplina...";
                txt_Disciplina.ForeColor = Color.Gray;
            }
        }
        private void txt_Disciplina_Enter(object sender, EventArgs e)
        {
            if (txt_Disciplina.Text == "Introduza disciplina...")
            {
                txt_Disciplina.Text = "";
                txt_Disciplina.Font = new Font(txt_Disciplina.Font.FontFamily, 8);
                txt_Disciplina.ForeColor = Color.Black;
            }
        }

        private void txt_habilitacoes_Leave(object sender, EventArgs e)
        {
            if (txt_habilitacoes.Text == "")
            {
                txt_habilitacoes.Font = new Font(txt_habilitacoes.Font.FontFamily, 7);
                txt_habilitacoes.Text = "Introduza habilitações...";
                txt_habilitacoes.ForeColor = Color.Gray;
            }
        }
        private void txt_habilitacoes_Enter(object sender, EventArgs e)
        {
            if (txt_habilitacoes.Text == "Introduza habilitações...")
            {
                txt_habilitacoes.Text = "";
                txt_habilitacoes.Font = new Font(txt_habilitacoes.Font.FontFamily, 8);
                txt_habilitacoes.ForeColor = Color.Black;
            }
        }

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Docente ai in RD.GetListaPessoa().OfType<Docente>())
            {
                if (cb_Nome.Text == ai.GetNome())
                {
                    txt_Email.Text = ai.GetContacto().GetEmail();
                    txt_Telefone.Text = (ai.GetContacto().GetTelefone()).ToString();
                    txt_Numero.Text = Convert.ToString(ai.GetNDocente());
                    txt_habilitacoes.Text = ai.GetHbilitacoes();
                    txt_Disciplina.Text = ai.GetDisciplinas();

                }

            }
        }

        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.InitialDirectory = @"C:\Users\Public\Imagens\";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                ptb_foto.Image = Image.FromFile(@caixa.FileName);
                ptb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
