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
    public partial class RemoverEmpresa : Form
    {
        Departamento DE;
        Empresa E;

        public RemoverEmpresa(Departamento dp)
        {
            InitializeComponent();
            DE = dp;
        }

        private void bt_pesquisar_Click_1(object sender, EventArgs e)
        {
            foreach (Empresa E in DE.GetListaEmpresa())
            {
                if (E.getNIF().ToString() == txt_contribuinte.Text)
                {
                    lb_erro.Visible = false;
                    lb_nome.Text = E.GetNome();
                }
                else
                {
                    lb_nome.Visible = false;
                }
            }

        }
        

        private void RemoverEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void bt_remover_Click_1(object sender, EventArgs e)
        {
            if (DE != null)
            {
                DialogResult resp = MessageBox.Show("Pretende eliminar empresa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    DE.GetListaEmpresa().Remove(E);
                    this.Enabled = false;
                    this.Enabled = true;
                    txt_contribuinte.Text = "";
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
        

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
