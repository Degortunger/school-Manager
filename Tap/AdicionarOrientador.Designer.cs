namespace Tap
{
    partial class AdicionarOrientador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarOrientador));
            this.gp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_NumeroOrientador = new System.Windows.Forms.MaskedTextBox();
            this.lb_Empresa = new System.Windows.Forms.Label();
            this.CB_Empresa = new System.Windows.Forms.ComboBox();
            this.feminino = new System.Windows.Forms.PictureBox();
            this.masculino = new System.Windows.Forms.PictureBox();
            this.rb_Feminino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.lb_NumeroOrientador = new System.Windows.Forms.Label();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.bt_Inserir = new System.Windows.Forms.Button();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_Genero = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.erro_nome = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_numero = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_telefone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_empresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.gp_DadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feminino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masculino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_DadosPessoais
            // 
            this.gp_DadosPessoais.Controls.Add(this.txt_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.txt_NumeroOrientador);
            this.gp_DadosPessoais.Controls.Add(this.lb_Empresa);
            this.gp_DadosPessoais.Controls.Add(this.CB_Empresa);
            this.gp_DadosPessoais.Controls.Add(this.feminino);
            this.gp_DadosPessoais.Controls.Add(this.masculino);
            this.gp_DadosPessoais.Controls.Add(this.rb_Feminino);
            this.gp_DadosPessoais.Controls.Add(this.rb_Masculino);
            this.gp_DadosPessoais.Controls.Add(this.lb_NumeroOrientador);
            this.gp_DadosPessoais.Controls.Add(this.lb_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.txt_Email);
            this.gp_DadosPessoais.Controls.Add(this.lb_email);
            this.gp_DadosPessoais.Controls.Add(this.bt_Inserir);
            this.gp_DadosPessoais.Controls.Add(this.ptb_foto);
            this.gp_DadosPessoais.Controls.Add(this.txt_nome);
            this.gp_DadosPessoais.Controls.Add(this.lb_Genero);
            this.gp_DadosPessoais.Controls.Add(this.lb_Nome);
            this.gp_DadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_DadosPessoais.Location = new System.Drawing.Point(11, 11);
            this.gp_DadosPessoais.Margin = new System.Windows.Forms.Padding(2);
            this.gp_DadosPessoais.Name = "gp_DadosPessoais";
            this.gp_DadosPessoais.Padding = new System.Windows.Forms.Padding(2);
            this.gp_DadosPessoais.Size = new System.Drawing.Size(383, 259);
            this.gp_DadosPessoais.TabIndex = 34;
            this.gp_DadosPessoais.TabStop = false;
            this.gp_DadosPessoais.Text = "Dados Pessoais";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(79, 174);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Telefone.Mask = "000000000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(92, 21);
            this.txt_Telefone.TabIndex = 6;
            // 
            // txt_NumeroOrientador
            // 
            this.txt_NumeroOrientador.Location = new System.Drawing.Point(79, 107);
            this.txt_NumeroOrientador.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumeroOrientador.Mask = "00000";
            this.txt_NumeroOrientador.Name = "txt_NumeroOrientador";
            this.txt_NumeroOrientador.Size = new System.Drawing.Size(92, 21);
            this.txt_NumeroOrientador.TabIndex = 4;
            // 
            // lb_Empresa
            // 
            this.lb_Empresa.AutoSize = true;
            this.lb_Empresa.Location = new System.Drawing.Point(18, 210);
            this.lb_Empresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Empresa.Name = "lb_Empresa";
            this.lb_Empresa.Size = new System.Drawing.Size(65, 15);
            this.lb_Empresa.TabIndex = 27;
            this.lb_Empresa.Text = "Empresa *";
            // 
            // CB_Empresa
            // 
            this.CB_Empresa.FormattingEnabled = true;
            this.CB_Empresa.Location = new System.Drawing.Point(79, 210);
            this.CB_Empresa.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Empresa.Name = "CB_Empresa";
            this.CB_Empresa.Size = new System.Drawing.Size(176, 23);
            this.CB_Empresa.TabIndex = 7;
            this.CB_Empresa.SelectedIndexChanged += new System.EventHandler(this.CB_Empresa_SelectedIndexChanged_1);
            // 
            // feminino
            // 
            this.feminino.Image = global::Tap.Properties.Resources.female_sign__3_;
            this.feminino.InitialImage = null;
            this.feminino.Location = new System.Drawing.Point(175, 57);
            this.feminino.Margin = new System.Windows.Forms.Padding(2);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(44, 42);
            this.feminino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.feminino.TabIndex = 25;
            this.feminino.TabStop = false;
            // 
            // masculino
            // 
            this.masculino.Image = global::Tap.Properties.Resources.male_gender_sign__5_;
            this.masculino.InitialImage = null;
            this.masculino.Location = new System.Drawing.Point(97, 57);
            this.masculino.Margin = new System.Windows.Forms.Padding(2);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(44, 42);
            this.masculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.masculino.TabIndex = 24;
            this.masculino.TabStop = false;
            // 
            // rb_Feminino
            // 
            this.rb_Feminino.AutoSize = true;
            this.rb_Feminino.Location = new System.Drawing.Point(157, 69);
            this.rb_Feminino.Name = "rb_Feminino";
            this.rb_Feminino.Size = new System.Drawing.Size(14, 13);
            this.rb_Feminino.TabIndex = 3;
            this.rb_Feminino.TabStop = true;
            this.rb_Feminino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(79, 69);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(14, 13);
            this.rb_Masculino.TabIndex = 2;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // lb_NumeroOrientador
            // 
            this.lb_NumeroOrientador.AutoSize = true;
            this.lb_NumeroOrientador.Location = new System.Drawing.Point(18, 110);
            this.lb_NumeroOrientador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NumeroOrientador.Name = "lb_NumeroOrientador";
            this.lb_NumeroOrientador.Size = new System.Drawing.Size(60, 15);
            this.lb_NumeroOrientador.TabIndex = 13;
            this.lb_NumeroOrientador.Text = "Numero *";
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Location = new System.Drawing.Point(18, 176);
            this.lb_Telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(63, 15);
            this.lb_Telefone.TabIndex = 11;
            this.lb_Telefone.Text = "Telefone *";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(79, 143);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 21);
            this.txt_Email.TabIndex = 5;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(18, 145);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 15);
            this.lb_email.TabIndex = 9;
            this.lb_email.Text = "E-mail *";
            // 
            // bt_Inserir
            // 
            this.bt_Inserir.Location = new System.Drawing.Point(275, 190);
            this.bt_Inserir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Inserir.Name = "bt_Inserir";
            this.bt_Inserir.Size = new System.Drawing.Size(76, 24);
            this.bt_Inserir.TabIndex = 8;
            this.bt_Inserir.Text = "Inserir";
            this.bt_Inserir.UseVisualStyleBackColor = true;
            // 
            // ptb_foto
            // 
            this.ptb_foto.Image = global::Tap.Properties.Resources.Default;
            this.ptb_foto.InitialImage = null;
            this.ptb_foto.Location = new System.Drawing.Point(266, 57);
            this.ptb_foto.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(93, 130);
            this.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_foto.TabIndex = 4;
            this.ptb_foto.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(79, 28);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(282, 21);
            this.txt_nome.TabIndex = 1;
            // 
            // lb_Genero
            // 
            this.lb_Genero.AutoSize = true;
            this.lb_Genero.Location = new System.Drawing.Point(18, 67);
            this.lb_Genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Genero.Name = "lb_Genero";
            this.lb_Genero.Size = new System.Drawing.Size(56, 15);
            this.lb_Genero.TabIndex = 2;
            this.lb_Genero.Text = "Género *";
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(18, 28);
            this.lb_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(49, 15);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome *";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(59, 3);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 33;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Guardar.Image = global::Tap.Properties.Resources.save_disk__2_;
            this.bt_Guardar.Location = new System.Drawing.Point(304, 275);
            this.bt_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(81, 33);
            this.bt_Guardar.TabIndex = 9;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click_1);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.bt_Cancel.Location = new System.Drawing.Point(218, 275);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(81, 33);
            this.bt_Cancel.TabIndex = 10;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click_1);
            // 
            // erro_nome
            // 
            this.erro_nome.ContainerControl = this;
            // 
            // erro_numero
            // 
            this.erro_numero.ContainerControl = this;
            // 
            // erro_email
            // 
            this.erro_email.ContainerControl = this;
            // 
            // erro_telefone
            // 
            this.erro_telefone.ContainerControl = this;
            // 
            // erro_empresa
            // 
            this.erro_empresa.ContainerControl = this;
            // 
            // AdicionarOrientador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 329);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.gp_DadosPessoais);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bt_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 368);
            this.Name = "AdicionarOrientador";
            this.Text = "AdicionarOrientador";
            this.Load += new System.EventHandler(this.AdicionarOrientador_Load);
            this.gp_DadosPessoais.ResumeLayout(false);
            this.gp_DadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feminino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masculino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bt_Cancel;
        internal System.Windows.Forms.Button bt_Guardar;
        internal System.Windows.Forms.GroupBox gp_DadosPessoais;
        internal System.Windows.Forms.Label lb_NumeroOrientador;
        internal System.Windows.Forms.Label lb_Telefone;
        internal System.Windows.Forms.TextBox txt_Email;
        internal System.Windows.Forms.Label lb_email;
        internal System.Windows.Forms.Button bt_Inserir;
        internal System.Windows.Forms.PictureBox ptb_foto;
        internal System.Windows.Forms.TextBox txt_nome;
        internal System.Windows.Forms.Label lb_Genero;
        internal System.Windows.Forms.Label lb_Nome;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RadioButton rb_Feminino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.PictureBox feminino;
        private System.Windows.Forms.PictureBox masculino;
        private System.Windows.Forms.ComboBox CB_Empresa;
        internal System.Windows.Forms.Label lb_Empresa;
        private System.Windows.Forms.MaskedTextBox txt_NumeroOrientador;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.ErrorProvider erro_nome;
        private System.Windows.Forms.ErrorProvider erro_numero;
        private System.Windows.Forms.ErrorProvider erro_email;
        private System.Windows.Forms.ErrorProvider erro_telefone;
        private System.Windows.Forms.ErrorProvider erro_empresa;
    }
}