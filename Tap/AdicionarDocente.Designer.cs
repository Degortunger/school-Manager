namespace Tap
{
    partial class AdicionarDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarDocente));
            this.gp_DadosEscolares = new System.Windows.Forms.GroupBox();
            this.txt_Numero = new System.Windows.Forms.MaskedTextBox();
            this.txt_habilitacoes = new System.Windows.Forms.TextBox();
            this.lb_habilitacoes = new System.Windows.Forms.Label();
            this.txt_Disciplina = new System.Windows.Forms.TextBox();
            this.lb_Disciplina = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.gp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.esterisco = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.feminino = new System.Windows.Forms.PictureBox();
            this.masculino = new System.Windows.Forms.PictureBox();
            this.rb_Feminino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.bt_Inserir = new System.Windows.Forms.Button();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.lb_Genero = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cb_Nome = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.erro_nomedocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_emaildocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_telefonedocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_numerodocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_disciplinadocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_habilitacoes = new System.Windows.Forms.ErrorProvider(this.components);
            this.gp_DadosEscolares.SuspendLayout();
            this.gp_DadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feminino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masculino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nomedocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_emaildocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefonedocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_numerodocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_disciplinadocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_habilitacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_DadosEscolares
            // 
            this.gp_DadosEscolares.Controls.Add(this.txt_Numero);
            this.gp_DadosEscolares.Controls.Add(this.txt_habilitacoes);
            this.gp_DadosEscolares.Controls.Add(this.lb_habilitacoes);
            this.gp_DadosEscolares.Controls.Add(this.txt_Disciplina);
            this.gp_DadosEscolares.Controls.Add(this.lb_Disciplina);
            this.gp_DadosEscolares.Controls.Add(this.lb_numero);
            this.gp_DadosEscolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_DadosEscolares.Location = new System.Drawing.Point(11, 245);
            this.gp_DadosEscolares.Margin = new System.Windows.Forms.Padding(2);
            this.gp_DadosEscolares.Name = "gp_DadosEscolares";
            this.gp_DadosEscolares.Padding = new System.Windows.Forms.Padding(2);
            this.gp_DadosEscolares.Size = new System.Drawing.Size(381, 138);
            this.gp_DadosEscolares.TabIndex = 30;
            this.gp_DadosEscolares.TabStop = false;
            this.gp_DadosEscolares.Text = "Dados Escolares";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(97, 24);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Numero.Mask = "00000";
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(73, 21);
            this.txt_Numero.TabIndex = 7;
            // 
            // txt_habilitacoes
            // 
            this.txt_habilitacoes.Location = new System.Drawing.Point(97, 88);
            this.txt_habilitacoes.Margin = new System.Windows.Forms.Padding(2);
            this.txt_habilitacoes.Name = "txt_habilitacoes";
            this.txt_habilitacoes.Size = new System.Drawing.Size(264, 21);
            this.txt_habilitacoes.TabIndex = 9;
            // 
            // lb_habilitacoes
            // 
            this.lb_habilitacoes.AutoSize = true;
            this.lb_habilitacoes.Location = new System.Drawing.Point(18, 89);
            this.lb_habilitacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_habilitacoes.Name = "lb_habilitacoes";
            this.lb_habilitacoes.Size = new System.Drawing.Size(83, 15);
            this.lb_habilitacoes.TabIndex = 5;
            this.lb_habilitacoes.Text = "Habilitações *";
            // 
            // txt_Disciplina
            // 
            this.txt_Disciplina.Location = new System.Drawing.Point(97, 57);
            this.txt_Disciplina.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Disciplina.Name = "txt_Disciplina";
            this.txt_Disciplina.Size = new System.Drawing.Size(264, 21);
            this.txt_Disciplina.TabIndex = 8;
            // 
            // lb_Disciplina
            // 
            this.lb_Disciplina.AutoSize = true;
            this.lb_Disciplina.Location = new System.Drawing.Point(18, 57);
            this.lb_Disciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Disciplina.Name = "lb_Disciplina";
            this.lb_Disciplina.Size = new System.Drawing.Size(69, 15);
            this.lb_Disciplina.TabIndex = 3;
            this.lb_Disciplina.Text = "Disciplina *";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(18, 27);
            this.lb_numero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(60, 15);
            this.lb_numero.TabIndex = 0;
            this.lb_numero.Text = "Numero *";
            // 
            // gp_DadosPessoais
            // 
            this.gp_DadosPessoais.Controls.Add(this.esterisco);
            this.gp_DadosPessoais.Controls.Add(this.txt_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.feminino);
            this.gp_DadosPessoais.Controls.Add(this.masculino);
            this.gp_DadosPessoais.Controls.Add(this.rb_Feminino);
            this.gp_DadosPessoais.Controls.Add(this.rb_Masculino);
            this.gp_DadosPessoais.Controls.Add(this.lb_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.txt_Email);
            this.gp_DadosPessoais.Controls.Add(this.lb_email);
            this.gp_DadosPessoais.Controls.Add(this.bt_Inserir);
            this.gp_DadosPessoais.Controls.Add(this.ptb_foto);
            this.gp_DadosPessoais.Controls.Add(this.lb_Genero);
            this.gp_DadosPessoais.Controls.Add(this.lb_Nome);
            this.gp_DadosPessoais.Controls.Add(this.txt_nome);
            this.gp_DadosPessoais.Controls.Add(this.cb_Nome);
            this.gp_DadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_DadosPessoais.Location = new System.Drawing.Point(11, 11);
            this.gp_DadosPessoais.Margin = new System.Windows.Forms.Padding(2);
            this.gp_DadosPessoais.Name = "gp_DadosPessoais";
            this.gp_DadosPessoais.Padding = new System.Windows.Forms.Padding(2);
            this.gp_DadosPessoais.Size = new System.Drawing.Size(381, 230);
            this.gp_DadosPessoais.TabIndex = 29;
            this.gp_DadosPessoais.TabStop = false;
            this.gp_DadosPessoais.Text = "Dados Pessoais";
            // 
            // esterisco
            // 
            this.esterisco.AutoSize = true;
            this.esterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esterisco.Location = new System.Drawing.Point(62, 149);
            this.esterisco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.esterisco.Name = "esterisco";
            this.esterisco.Size = new System.Drawing.Size(0, 18);
            this.esterisco.TabIndex = 33;
            this.esterisco.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(97, 150);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Telefone.Mask = "000000000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(80, 21);
            this.txt_Telefone.TabIndex = 5;
            // 
            // feminino
            // 
            this.feminino.Image = global::Tap.Properties.Resources.female_sign__3_;
            this.feminino.InitialImage = null;
            this.feminino.Location = new System.Drawing.Point(193, 57);
            this.feminino.Margin = new System.Windows.Forms.Padding(2);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(44, 42);
            this.feminino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.feminino.TabIndex = 31;
            this.feminino.TabStop = false;
            // 
            // masculino
            // 
            this.masculino.Image = global::Tap.Properties.Resources.male_gender_sign__5_;
            this.masculino.InitialImage = null;
            this.masculino.Location = new System.Drawing.Point(111, 57);
            this.masculino.Margin = new System.Windows.Forms.Padding(2);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(44, 42);
            this.masculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.masculino.TabIndex = 30;
            this.masculino.TabStop = false;
            // 
            // rb_Feminino
            // 
            this.rb_Feminino.AutoSize = true;
            this.rb_Feminino.Location = new System.Drawing.Point(175, 70);
            this.rb_Feminino.Name = "rb_Feminino";
            this.rb_Feminino.Size = new System.Drawing.Size(14, 13);
            this.rb_Feminino.TabIndex = 3;
            this.rb_Feminino.TabStop = true;
            this.rb_Feminino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(93, 69);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(14, 13);
            this.rb_Masculino.TabIndex = 2;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Location = new System.Drawing.Point(18, 153);
            this.lb_Telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(66, 15);
            this.lb_Telefone.TabIndex = 11;
            this.lb_Telefone.Text = "Telefone * ";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(97, 119);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(175, 21);
            this.txt_Email.TabIndex = 4;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(18, 122);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 15);
            this.lb_email.TabIndex = 9;
            this.lb_email.Text = "E-mail *";
            // 
            // bt_Inserir
            // 
            this.bt_Inserir.Location = new System.Drawing.Point(284, 195);
            this.bt_Inserir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Inserir.Name = "bt_Inserir";
            this.bt_Inserir.Size = new System.Drawing.Size(76, 24);
            this.bt_Inserir.TabIndex = 6;
            this.bt_Inserir.Text = "Inserir";
            this.bt_Inserir.UseVisualStyleBackColor = true;
            this.bt_Inserir.Click += new System.EventHandler(this.bt_Inserir_Click);
            // 
            // ptb_foto
            // 
            this.ptb_foto.Image = global::Tap.Properties.Resources.Default;
            this.ptb_foto.Location = new System.Drawing.Point(275, 62);
            this.ptb_foto.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(93, 130);
            this.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_foto.TabIndex = 4;
            this.ptb_foto.TabStop = false;
            // 
            // lb_Genero
            // 
            this.lb_Genero.AutoSize = true;
            this.lb_Genero.Location = new System.Drawing.Point(18, 69);
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
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(97, 28);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(272, 21);
            this.txt_nome.TabIndex = 1;
            // 
            // cb_Nome
            // 
            this.cb_Nome.FormattingEnabled = true;
            this.cb_Nome.Location = new System.Drawing.Point(97, 28);
            this.cb_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Nome.Name = "cb_Nome";
            this.cb_Nome.Size = new System.Drawing.Size(272, 23);
            this.cb_Nome.TabIndex = 1;
            this.cb_Nome.SelectedIndexChanged += new System.EventHandler(this.cb_Nome_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 28;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Guardar.Image = global::Tap.Properties.Resources.save_disk__2_;
            this.bt_Guardar.Location = new System.Drawing.Point(311, 386);
            this.bt_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(81, 29);
            this.bt_Guardar.TabIndex = 10;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click_1);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.bt_Cancel.Location = new System.Drawing.Point(226, 386);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(81, 29);
            this.bt_Cancel.TabIndex = 11;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click_1);
            // 
            // erro_nomedocente
            // 
            this.erro_nomedocente.ContainerControl = this;
            // 
            // erro_emaildocente
            // 
            this.erro_emaildocente.ContainerControl = this;
            // 
            // erro_telefonedocente
            // 
            this.erro_telefonedocente.ContainerControl = this;
            // 
            // erro_numerodocente
            // 
            this.erro_numerodocente.ContainerControl = this;
            // 
            // erro_disciplinadocente
            // 
            this.erro_disciplinadocente.ContainerControl = this;
            // 
            // erro_habilitacoes
            // 
            this.erro_habilitacoes.ContainerControl = this;
            // 
            // AdicionarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 445);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.gp_DadosEscolares);
            this.Controls.Add(this.gp_DadosPessoais);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bt_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 484);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 484);
            this.Name = "AdicionarDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarDocente";
            this.Load += new System.EventHandler(this.AdicionarDocente_Load);
            this.gp_DadosEscolares.ResumeLayout(false);
            this.gp_DadosEscolares.PerformLayout();
            this.gp_DadosPessoais.ResumeLayout(false);
            this.gp_DadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feminino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masculino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nomedocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_emaildocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefonedocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_numerodocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_disciplinadocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_habilitacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bt_Cancel;
        internal System.Windows.Forms.Button bt_Guardar;
        internal System.Windows.Forms.GroupBox gp_DadosEscolares;
        internal System.Windows.Forms.TextBox txt_habilitacoes;
        internal System.Windows.Forms.Label lb_habilitacoes;
        internal System.Windows.Forms.TextBox txt_Disciplina;
        internal System.Windows.Forms.Label lb_Disciplina;
        internal System.Windows.Forms.Label lb_numero;
        internal System.Windows.Forms.GroupBox gp_DadosPessoais;
        internal System.Windows.Forms.Label lb_Telefone;
        internal System.Windows.Forms.TextBox txt_Email;
        internal System.Windows.Forms.Label lb_email;
        internal System.Windows.Forms.Button bt_Inserir;
        internal System.Windows.Forms.PictureBox ptb_foto;
        internal System.Windows.Forms.TextBox txt_nome;
        internal System.Windows.Forms.Label lb_Genero;
        internal System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.ComboBox cb_Nome;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox feminino;
        private System.Windows.Forms.PictureBox masculino;
        private System.Windows.Forms.RadioButton rb_Feminino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.Label esterisco;
        private System.Windows.Forms.MaskedTextBox txt_Numero;
        private System.Windows.Forms.ErrorProvider erro_nomedocente;
        private System.Windows.Forms.ErrorProvider erro_emaildocente;
        private System.Windows.Forms.ErrorProvider erro_telefonedocente;
        private System.Windows.Forms.ErrorProvider erro_numerodocente;
        private System.Windows.Forms.ErrorProvider erro_disciplinadocente;
        private System.Windows.Forms.ErrorProvider erro_habilitacoes;
    }
}