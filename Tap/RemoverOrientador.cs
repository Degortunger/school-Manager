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
    public partial class RemoverOrientador : Form
    {
        Departamento DE;
        OrientadorEmpresa oe;
        public RemoverOrientador(Departamento dp)
        {
            DE = dp;
            InitializeComponent();
        }

        private void bt_pesquisar_Click_1(object sender, EventArgs e)
        {
            foreach (OrientadorEmpresa DP in DE.GetListaPessoa().OfType<OrientadorEmpresa>())
            {
                if (DP.GetNumOrientador() == Convert.ToInt32(txt_numero.Text))
                {
                    lb_erro.Visible = false;
                    lb_nome.Text = DP.GetNome();
                }
                else
                {
                    lb_nome.Visible = false;
                }
            }
        }


        private void bt_remover_Click_1(object sender, EventArgs e)
        {
            if (DE != null)
            {
                DialogResult resp = MessageBox.Show("Pretende eliminar orientador?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    DE.GetListaPessoa().Remove(oe);
                    this.Enabled = false;
                    this.Enabled = true;
                    txt_numero.Text = "";
                    lb_nome.Visible = false;
                }
                else
                {
                    resp = DialogResult.No;
                    bt_remover.Enabled = false;
                    lb_nome.Visible = false;
                }
            }
        }
        

        private void RemoverOrientador_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
