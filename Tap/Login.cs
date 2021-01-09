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
    public partial class Login : Form
    {
        //Bloqueia o botão de fechar do formulário
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        Departamento RD;
        public Login(Departamento d)
        {
            InitializeComponent();
            RD = d;
        }

        

        

        private void bt_cancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (cb_tipoUtilizador.Text)
            {
                case "Aluno":
                    foreach (Aluno A in RD.GetListaPessoa().OfType<Aluno>())
                    {
                        if (A.GetUser() == txt_username.Text && A.GetPass() == txt_Password.Text)
                        {
                            RD.SetLogin(A.GetNome());
                            this.DialogResult = DialogResult.Yes;
                        }
                    }
                    break;

                case "Docente":
                    foreach (Docente D in RD.GetListaPessoa().OfType<Docente>())
                    {
                        if (D.GetUser() == txt_username.Text && D.GetPass() == txt_Password.Text)
                        {
                            RD.SetLogin(D.GetNome());
                            this.DialogResult = DialogResult.Yes;
                        }
                    }
                    break;

                case "Orientador":
                    foreach (OrientadorEmpresa OE in RD.GetListaPessoa().OfType<OrientadorEmpresa>())
                    {
                        if (OE.GetUser() == txt_username.Text && OE.GetPass() == txt_Password.Text)
                        {
                            RD.SetLogin(OE.GetNome());
                            this.DialogResult = DialogResult.Yes;

                        }
                    }
                    break;

                case "Empresa":
                    foreach (Empresa EM in RD.GetListaEmpresa())
                    {
                        if (EM.GetUser() == txt_username.Text && EM.GetPass() == txt_Password.Text)
                        {
                            RD.SetLogin(EM.GetNome());
                            this.DialogResult = DialogResult.Yes;
                        }
                    }
                    break;

            }
        }
    }
}
