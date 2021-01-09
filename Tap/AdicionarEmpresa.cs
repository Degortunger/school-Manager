using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Tap
{
    public partial class AdicionarEmpresa : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaseleccionada = 0;
        double LatInicial = 40.6438418;
        double longInicial = -7.92013139;

        Departamento DE;
        int t;
        public AdicionarEmpresa(Departamento E, int escolha)
        {
            InitializeComponent();
            DE = E;
            t = escolha;
        }
        private void AdicionarEmpresa_Load(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new GMap.NET.PointLatLng(LatInicial, longInicial);
            gmap.MinZoom = 0;
            gmap.MaxZoom = 24;
            gmap.Zoom = 9;
            gmap.AutoScroll = true;

            if (txt_Nome.Text == "" || txt_Nome.Text == "")
                erro_nomeempresa.SetError(txt_Nome, "Introduza um nome.");
            else
                erro_nomeempresa.SetError(txt_Nome, "");

            if (txt_nif.Text == "")
                erro_NifEmpresa.SetError(txt_nif, "Introduza um NIF.");
            else
                erro_NifEmpresa.SetError(txt_nif, "");

            if (txt_Actividade.Text == "")
                erro_atividadeEmpresa.SetError(txt_Actividade, "Introduza uma Atividade.");
            else
                erro_atividadeEmpresa.SetError(txt_Actividade, "");

            if (txt_telefone.Text == "")
                erro_telefoneempresa.SetError(txt_telefone, "Introduza um Telefone.");
            else
                erro_telefoneempresa.SetError(txt_telefone, "");

            if (txt_FAX.Text == "")
                erro_faxempresa.SetError(txt_FAX, "Introduza um FAX.");
            else
                erro_faxempresa.SetError(txt_FAX, "");

            if (txt_Email.Text == "")
                erro_emailempresa.SetError(txt_Email, "Introduza um E-mail.");
            else
                erro_emailempresa.SetError(txt_Email, "");

            txt_Nome.ForeColor = Color.Gray;
            txt_Nome.Font = new Font(txt_Nome.Font.FontFamily, 7);
            txt_Nome.Text = "Introduza o nome da empresa...";
            this.txt_Nome.Leave += new System.EventHandler(this.txt_Nome_Leave);
            this.txt_Nome.Enter += new System.EventHandler(this.txt_Nome_Enter);
            
            txt_nif.ForeColor = Color.Gray;
            txt_nif.Font = new Font(txt_nif.Font.FontFamily, 7);
            txt_nif.Text = "000000000";
            this.txt_nif.Leave += new System.EventHandler(this.txt_nif_Leave);
            this.txt_nif.Enter += new System.EventHandler(this.txt_nif_Enter);

            txt_Actividade.ForeColor = Color.Gray;
            txt_Actividade.Font = new Font(txt_Actividade.Font.FontFamily, 7);
            txt_Actividade.Text = "Escrever atividade...";
            this.txt_Actividade.Leave += new System.EventHandler(this.txt_Actividade_Leave);
            this.txt_Actividade.Enter += new System.EventHandler(this.txt_Actividade_Enter);

            txt_telefone.ForeColor = Color.Gray;
            txt_telefone.Font = new Font(txt_telefone.Font.FontFamily, 7);
            txt_telefone.Text = "900000000";
            this.txt_telefone.Leave += new System.EventHandler(this.txt_telefone_Leave);
            this.txt_telefone.Enter += new System.EventHandler(this.txt_telefone_Enter);

            txt_FAX.ForeColor = Color.Gray;
            txt_FAX.Font = new Font(txt_FAX.Font.FontFamily, 7);
            txt_FAX.Text = "900000000";
            this.txt_FAX.Leave += new System.EventHandler(this.txt_FAX_Leave);
            this.txt_FAX.Enter += new System.EventHandler(this.txt_FAX_Enter);

            txt_Email.ForeColor = Color.Gray;
            txt_Email.Font = new Font(txt_Email.Font.FontFamily, 7);
            txt_Email.Text = "exemplo@dominio.com";
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);

            switch (t)
            {
                case 0:
                    cb_NomeEmpresa.Visible = false;
                    break;

                case 1:

                    txt_Nome.Visible = false;
                    txt_nif.Enabled = false;
                    break;
            }
        }
        

        

        private void bt_Guardar_Click_1(object sender, EventArgs e)
        {
            switch (t)
            {
                case 0:
                    DialogResult adicionar = MessageBox.Show("Tem a certeza que pretende adicionar?", "Adicionar empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Empresa EM = new Empresa();
                    EM.SetNome(txt_Nome.Text);
                    EM.Setnif(Convert.ToInt32(txt_nif.Text));
                    EM.SetActividade(txt_Actividade.Text);
                    EM.GetContacto().SetTelefone(Convert.ToInt32(txt_telefone.Text));
                    EM.GetContacto().SetEmail(txt_Email.Text);
                    EM.SetFAX(Convert.ToInt32(txt_FAX.Text));

                    DE.GetListaEmpresa().Add(EM);
                    this.Close();
                    break;

                case 1:
                    foreach (Empresa EMP in DE.GetListaEmpresa())
                    {
                        if (cb_NomeEmpresa.Text == EMP.GetNome())
                        {
                            DialogResult editar = MessageBox.Show("Tem a certeza que quer guardar as alteraçãoes?", "Guardar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            
                            
                            EMP.SetActividade(txt_Actividade.Text);
                            EMP.GetContacto().SetTelefone(Convert.ToInt32(txt_telefone.Text));
                            EMP.GetContacto().SetEmail(txt_Email.Text);
                            EMP.SetFAX(Convert.ToInt32(txt_FAX.Text));

                        }
                    }

                    this.Close();                    
                    break;
            }
        }

        private void txt_Nome_Leave(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "")
            {
                txt_Nome.Font = new Font(txt_Nome.Font.FontFamily, 7);
                txt_Nome.Text = "Introduza o nome da empresa...";
                txt_Nome.ForeColor = Color.Gray;
            }
        }
        private void txt_Nome_Enter(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "Introduza o nome do aluno...")
            {
                txt_Nome.Text = "";
                txt_Nome.Font = new Font(txt_Nome.Font.FontFamily, 8);
                txt_Nome.ForeColor = Color.Black;
            }
        }

        private void txt_nif_Leave(object sender, EventArgs e)
        {
            if (txt_nif.Text == "")
            {
                txt_nif.Font = new Font(txt_nif.Font.FontFamily, 7);
                txt_nif.Text = "000000000";
                txt_nif.ForeColor = Color.Gray;
            }
        }
        private void txt_nif_Enter(object sender, EventArgs e)
        {
            if (txt_nif.Text == "000000000")
            {
                txt_nif.Text = "";
                txt_nif.Font = new Font(txt_nif.Font.FontFamily, 8);
                txt_nif.ForeColor = Color.Black;
            }
        }

        private void txt_Actividade_Leave(object sender, EventArgs e)
        {
            if (txt_Actividade.Text == "")
            {
                txt_Actividade.Font = new Font(txt_Actividade.Font.FontFamily, 7);
                txt_Actividade.Text = "Escrever atividade...";
                txt_Actividade.ForeColor = Color.Gray;
            }
        }
        private void txt_Actividade_Enter(object sender, EventArgs e)
        {
            if (txt_Actividade.Text == "Escrever atividade...")
            {
                txt_Actividade.Text = "";
                txt_Actividade.Font = new Font(txt_Actividade.Font.FontFamily, 8);
                txt_Actividade.ForeColor = Color.Black;
            }
        }

        private void txt_telefone_Leave(object sender, EventArgs e)
        {
            if (txt_telefone.Text == "")
            {
                txt_telefone.Font = new Font(txt_telefone.Font.FontFamily, 7);
                txt_telefone.Text = "900000000";
                txt_telefone.ForeColor = Color.Gray;
            }
        }
        private void txt_telefone_Enter(object sender, EventArgs e)
        {
            if (txt_telefone.Text == "900000000")
            {
                txt_telefone.Text = "";
                txt_telefone.Font = new Font(txt_telefone.Font.FontFamily, 8);
                txt_telefone.ForeColor = Color.Black;
            }
        }

        private void txt_FAX_Leave(object sender, EventArgs e)
        {
            if (txt_FAX.Text == "")
            {
                txt_FAX.Font = new Font(txt_FAX.Font.FontFamily, 7);
                txt_FAX.Text = "900000000";
                txt_FAX.ForeColor = Color.Gray;
            }
        }
        private void txt_FAX_Enter(object sender, EventArgs e)
        {
            if (txt_FAX.Text == "900000000")
            {
                txt_FAX.Text = "";
                txt_FAX.Font = new Font(txt_FAX.Font.FontFamily, 8);
                txt_FAX.ForeColor = Color.Black;
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

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_NomeEmpresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Empresa E = DE.GetListaEmpresa()[cb_NomeEmpresa.SelectedIndex];
            txt_Email.Text = E.GetContacto().GetEmail();
            txt_Actividade.Text = E.GetActividade();
            txt_FAX.Text = E.GetFAX().ToString();
            txt_nif.Text = E.getNIF().ToString();
            txt_Nome.Text = E.GetNome();
            txt_telefone.Text = E.GetContacto().GetTelefone().ToString();
        }

        
    }
}
