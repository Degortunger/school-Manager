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
    public partial class AdicionarOrientador : Form
    {
        Departamento DE;
        Empresa RE;
        string path;
        int op;
        public AdicionarOrientador(Departamento D,int a, Empresa E)
        {
            InitializeComponent();
            DE = D;
            op = a;
            RE = E;
        }

        private void AdicionarOrientador_Load(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_nome.Text == "")
                erro_nome.SetError(txt_nome, "Introduza um nome.");
            else
                erro_nome.SetError(txt_nome, "");

            if (txt_Email.Text == "")
                erro_email.SetError(txt_Email, "Introduza um E-mail.");
            else
                erro_email.SetError(txt_Email, "");

            if (txt_Telefone.Text == "")
                erro_telefone.SetError(txt_Telefone, "Introduza um Telefone.");
            else
                erro_telefone.SetError(txt_Telefone, "");

            if (txt_NumeroOrientador.Text == "")
                erro_numero.SetError(txt_NumeroOrientador, "Introduza um Numero.");
            else
                erro_numero.SetError(txt_NumeroOrientador, "");

            /*if (CB_Empresa = null)

                erro_numero.SetError(txt_NumeroOrientador, "Introduza um Numero.");
            
            else
                erro_numero.SetError(txt_NumeroOrientador, "");*/

            txt_nome.ForeColor = Color.Gray;
            txt_nome.Font = new Font(txt_nome.Font.FontFamily, 7);
            txt_nome.Text = "Introduza o nome...";
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);

            txt_NumeroOrientador.ForeColor = Color.Gray;
            txt_NumeroOrientador.Font = new Font(txt_NumeroOrientador.Font.FontFamily, 7);
            txt_NumeroOrientador.Text = "00000";
            this.txt_NumeroOrientador.Leave += new System.EventHandler(this.txt_NumeroOrientador_Leave);
            this.txt_NumeroOrientador.Enter += new System.EventHandler(this.txt_NumeroOrientador_Enter);

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

            CB_Empresa.ForeColor = Color.Gray;
            CB_Empresa.Font = new Font(CB_Empresa.Font.FontFamily, 7);
            CB_Empresa.Text = "Escolher empresa...";
            this.CB_Empresa.Leave += new System.EventHandler(this.CB_Empresa_Leave);
            this.CB_Empresa.Enter += new System.EventHandler(this.CB_Empresa_Enter);

            foreach (Empresa emp in DE.GetListaEmpresa())
            {
                CB_Empresa.Items.Add(emp.GetNome());
            }
        }

                
                     
        private void bt_Guardar_Click_1(object sender, EventArgs e)
        {
            DialogResult adicionar = MessageBox.Show("Tem a certeza que pretende adicionar?", "Adicionar Orientador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            OrientadorEmpresa OE = new OrientadorEmpresa();
            OE.SetNome(txt_nome.Text);
            OE.SetNumOrientador(Convert.ToInt32(txt_NumeroOrientador.Text));
            OE.GetContacto().SetTelefone(Convert.ToInt32(txt_Telefone.Text));
            OE.GetContacto().SetEmail(txt_Email.Text);
            if (rb_Masculino.Checked == true)
            {
                OE.SetGenero("Masculino");
            }
            else
            {
                if (rb_Feminino.Checked == true)
                {
                    OE.SetGenero("Feminino");
                }
            }
            string n_imagem = path + "foto_OrientadorEmpresa_" + OE.GetNome() + ".jpg";
            OE.SetFoto("foto_OrientadorEmpresa_" + OE.GetNome() + ".jpg");
            ptb_foto.Image.Save(n_imagem);

            RE.GetListaOrientadoresEmpresa().Add(OE);

            this.Close();
        }
        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                txt_nome.Font = new Font(txt_nome.Font.FontFamily, 7);
                txt_nome.Text = "Introduza o nome...";
                txt_nome.ForeColor = Color.Gray;
            }
        }
        private void txt_nome_Enter(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Introduza o nome...")
            {
                txt_nome.Text = "";
                txt_nome.Font = new Font(txt_nome.Font.FontFamily, 8);
                txt_nome.ForeColor = Color.Black;
            }
        }        

        private void txt_NumeroOrientador_Leave(object sender, EventArgs e)
        {
            if (txt_NumeroOrientador.Text == "")
            {
                txt_NumeroOrientador.Font = new Font(txt_NumeroOrientador.Font.FontFamily, 7);
                txt_NumeroOrientador.Text = "00000";
                txt_NumeroOrientador.ForeColor = Color.Gray;
            }
        }
        private void txt_NumeroOrientador_Enter(object sender, EventArgs e)
        {
            if (txt_NumeroOrientador.Text == "00000")
            {
                txt_NumeroOrientador.Text = "";
                txt_NumeroOrientador.Font = new Font(txt_NumeroOrientador.Font.FontFamily, 8);
                txt_NumeroOrientador.ForeColor = Color.Black;
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

        private void CB_Empresa_Leave(object sender, EventArgs e)
        {
            if (CB_Empresa.Text == "")
            {
                CB_Empresa.Font = new Font(txt_Telefone.Font.FontFamily, 7);
                CB_Empresa.Text = "Escolher empresa...";
                txt_Telefone.ForeColor = Color.Gray;
            }
        }
        private void CB_Empresa_Enter(object sender, EventArgs e)
        {
            if (CB_Empresa.Text == "Escolher empresa...")
            {
                CB_Empresa.Text = "";
                CB_Empresa.Font = new Font(CB_Empresa.Font.FontFamily, 8);
                CB_Empresa.ForeColor = Color.Black;
            }
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

        private void CB_Empresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
