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
    public partial class RemoverAluno : Form
    {
        Departamento DE;
        Aluno A;
        public RemoverAluno(Departamento de)
        {
            InitializeComponent();
            DE = de;
        }

        private void bt_pesquisar_Click_1(object sender, EventArgs e)
        {
            foreach (Aluno al in DE.GetListaPessoa().OfType<Aluno>())
            {
                if (al.GetNAluno().ToString() == txt_contribuinte.Text)
                {
                    lb_erro.Visible = false;
                    lb_nome.Text = al.GetNome();
                }
                else
                {
                    lb_nome.Visible = false;
                }
            }
        }

       
        private void RemoverAluno_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_remover_Click_1(object sender, EventArgs e)
        {
            if (DE != null)
            {
                DialogResult resp = MessageBox.Show("Pretende eliminar aluno?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    DE.GetListaPessoa().Remove(A);
                    this.Enabled = false;
                    this.Enabled = true;
                    txt_contribuinte.Text = "";
                    lb_nome.Visible = false;
                    this.Close();
                }
                else
                {
                    resp = DialogResult.No;
                    bt_remover.Enabled = false;
                    lb_nome.Visible = false;
                }
            }
        }

        
    }
}
