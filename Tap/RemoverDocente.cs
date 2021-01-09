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
    public partial class RemoverDocente : Form
    {
        Departamento DE;
        Docente DO;
        public RemoverDocente(Departamento Dg)
        {
            DE = Dg;
            InitializeComponent();
        }

        private void bt_pesquisar_Click_1(object sender, EventArgs e)
        {

            foreach (Docente PE in DE.GetListaPessoa().OfType<Docente>())
            {
                if (PE.GetNDocente() == Convert.ToInt32(txt_numero.Text))
                {
                    lb_erro.Visible = false;
                    lb_nome.Text = PE.GetNome();
                }
                else
                {
                    lb_nome.Visible = false;
                }
            }//FIM FOREACH
        }//FIM BOTÃO

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (DE != null)
            {
                DialogResult resp = MessageBox.Show("Pretende eliminar funcionário?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    DE.GetListaPessoa().Remove(DO);
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

        private void RemoverDocente_Load(object sender, EventArgs e)
        {

        }//FIM BOTAO ELIMINAR

        

        private void Bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

        
    }
}
