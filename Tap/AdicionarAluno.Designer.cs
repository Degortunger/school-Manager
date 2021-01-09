namespace Tap
{
    partial class AdicionarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarAluno));
            this.gp_DadosEscolares = new System.Windows.Forms.GroupBox();
            this.txt_Numero = new System.Windows.Forms.MaskedTextBox();
            this.rb_EI = new System.Windows.Forms.RadioButton();
            this.rb_TDM = new System.Windows.Forms.RadioButton();
            this.lb_Curso = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.gp_Morada = new System.Windows.Forms.GroupBox();
            this.txt_Campo2 = new System.Windows.Forms.MaskedTextBox();
            this.txt_Campo1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_localidade = new System.Windows.Forms.TextBox();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.lb_CodPostal = new System.Windows.Forms.Label();
            this.lb_Localidade = new System.Windows.Forms.Label();
            this.lb_Rua = new System.Windows.Forms.Label();
            this.gp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.txt_NIF = new System.Windows.Forms.MaskedTextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.feminino = new System.Windows.Forms.PictureBox();
            this.masculino = new System.Windows.Forms.PictureBox();
            this.rb_Feminino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.dtp_datanascimento = new System.Windows.Forms.DateTimePicker();
            this.bt_Inserir = new System.Windows.Forms.Button();
            this.lb_NIF = new System.Windows.Forms.Label();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.lb_dtaNascimento = new System.Windows.Forms.Label();
            this.lb_Genero = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cb_Nome = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.erro_nome = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_contribuinte = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_telefone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_rua = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_localidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_codpostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_numero = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_sexo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_curso = new System.Windows.Forms.ErrorProvider(this.components);
            this.gp_DadosEscolares.SuspendLayout();
            this.gp_Morada.SuspendLayout();
            this.gp_DadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feminino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masculino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_contribuinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_rua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_localidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_codpostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_sexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_DadosEscolares
            // 
            this.gp_DadosEscolares.Controls.Add(this.txt_Numero);
            this.gp_DadosEscolares.Controls.Add(this.rb_EI);
            this.gp_DadosEscolares.Controls.Add(this.rb_TDM);
            this.gp_DadosEscolares.Controls.Add(this.lb_Curso);
            this.gp_DadosEscolares.Controls.Add(this.lb_numero);
            this.gp_DadosEscolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_DadosEscolares.Location = new System.Drawing.Point(11, 403);
            this.gp_DadosEscolares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_DadosEscolares.Name = "gp_DadosEscolares";
            this.gp_DadosEscolares.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_DadosEscolares.Size = new System.Drawing.Size(231, 107);
            this.gp_DadosEscolares.TabIndex = 29;
            this.gp_DadosEscolares.TabStop = false;
            this.gp_DadosEscolares.Text = "Dados Escolares";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(86, 24);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Numero.Mask = "00000";
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(73, 21);
            this.txt_Numero.TabIndex = 13;
            // 
            // rb_EI
            // 
            this.rb_EI.AutoSize = true;
            this.rb_EI.Location = new System.Drawing.Point(140, 56);
            this.rb_EI.Name = "rb_EI";
            this.rb_EI.Size = new System.Drawing.Size(36, 19);
            this.rb_EI.TabIndex = 15;
            this.rb_EI.TabStop = true;
            this.rb_EI.Text = "EI";
            this.rb_EI.UseVisualStyleBackColor = true;
            // 
            // rb_TDM
            // 
            this.rb_TDM.AutoSize = true;
            this.rb_TDM.Location = new System.Drawing.Point(85, 56);
            this.rb_TDM.Name = "rb_TDM";
            this.rb_TDM.Size = new System.Drawing.Size(52, 19);
            this.rb_TDM.TabIndex = 14;
            this.rb_TDM.TabStop = true;
            this.rb_TDM.Text = "TDM";
            this.rb_TDM.UseVisualStyleBackColor = true;
            // 
            // lb_Curso
            // 
            this.lb_Curso.AutoSize = true;
            this.lb_Curso.Location = new System.Drawing.Point(8, 58);
            this.lb_Curso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Curso.Name = "lb_Curso";
            this.lb_Curso.Size = new System.Drawing.Size(47, 15);
            this.lb_Curso.TabIndex = 1;
            this.lb_Curso.Text = "Curso *";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(8, 27);
            this.lb_numero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(60, 15);
            this.lb_numero.TabIndex = 0;
            this.lb_numero.Text = "Numero *";
            // 
            // gp_Morada
            // 
            this.gp_Morada.Controls.Add(this.txt_Campo2);
            this.gp_Morada.Controls.Add(this.txt_Campo1);
            this.gp_Morada.Controls.Add(this.txt_localidade);
            this.gp_Morada.Controls.Add(this.txt_Rua);
            this.gp_Morada.Controls.Add(this.lb_CodPostal);
            this.gp_Morada.Controls.Add(this.lb_Localidade);
            this.gp_Morada.Controls.Add(this.lb_Rua);
            this.gp_Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_Morada.Location = new System.Drawing.Point(11, 299);
            this.gp_Morada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_Morada.Name = "gp_Morada";
            this.gp_Morada.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_Morada.Size = new System.Drawing.Size(369, 100);
            this.gp_Morada.TabIndex = 28;
            this.gp_Morada.TabStop = false;
            this.gp_Morada.Text = "Morada";
            // 
            // txt_Campo2
            // 
            this.txt_Campo2.Location = new System.Drawing.Point(126, 76);
            this.txt_Campo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Campo2.Mask = "000";
            this.txt_Campo2.Name = "txt_Campo2";
            this.txt_Campo2.Size = new System.Drawing.Size(30, 21);
            this.txt_Campo2.TabIndex = 12;
            // 
            // txt_Campo1
            // 
            this.txt_Campo1.Location = new System.Drawing.Point(85, 76);
            this.txt_Campo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Campo1.Mask = "0000";
            this.txt_Campo1.Name = "txt_Campo1";
            this.txt_Campo1.Size = new System.Drawing.Size(38, 21);
            this.txt_Campo1.TabIndex = 11;
            // 
            // txt_localidade
            // 
            this.txt_localidade.Location = new System.Drawing.Point(85, 46);
            this.txt_localidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_localidade.Name = "txt_localidade";
            this.txt_localidade.Size = new System.Drawing.Size(162, 21);
            this.txt_localidade.TabIndex = 10;
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(86, 15);
            this.txt_Rua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(266, 21);
            this.txt_Rua.TabIndex = 9;
            // 
            // lb_CodPostal
            // 
            this.lb_CodPostal.AutoSize = true;
            this.lb_CodPostal.Location = new System.Drawing.Point(8, 79);
            this.lb_CodPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CodPostal.Name = "lb_CodPostal";
            this.lb_CodPostal.Size = new System.Drawing.Size(77, 15);
            this.lb_CodPostal.TabIndex = 2;
            this.lb_CodPostal.Text = "Cod. Postal *";
            // 
            // lb_Localidade
            // 
            this.lb_Localidade.AutoSize = true;
            this.lb_Localidade.Location = new System.Drawing.Point(8, 49);
            this.lb_Localidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Localidade.Name = "lb_Localidade";
            this.lb_Localidade.Size = new System.Drawing.Size(76, 15);
            this.lb_Localidade.TabIndex = 1;
            this.lb_Localidade.Text = "Localidade *";
            // 
            // lb_Rua
            // 
            this.lb_Rua.AutoSize = true;
            this.lb_Rua.Location = new System.Drawing.Point(8, 18);
            this.lb_Rua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Rua.Name = "lb_Rua";
            this.lb_Rua.Size = new System.Drawing.Size(38, 15);
            this.lb_Rua.TabIndex = 0;
            this.lb_Rua.Text = "Rua *";
            // 
            // gp_DadosPessoais
            // 
            this.gp_DadosPessoais.Controls.Add(this.txt_NIF);
            this.gp_DadosPessoais.Controls.Add(this.txt_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.feminino);
            this.gp_DadosPessoais.Controls.Add(this.masculino);
            this.gp_DadosPessoais.Controls.Add(this.rb_Feminino);
            this.gp_DadosPessoais.Controls.Add(this.rb_Masculino);
            this.gp_DadosPessoais.Controls.Add(this.lb_Telefone);
            this.gp_DadosPessoais.Controls.Add(this.txt_Email);
            this.gp_DadosPessoais.Controls.Add(this.lb_email);
            this.gp_DadosPessoais.Controls.Add(this.dtp_datanascimento);
            this.gp_DadosPessoais.Controls.Add(this.bt_Inserir);
            this.gp_DadosPessoais.Controls.Add(this.lb_NIF);
            this.gp_DadosPessoais.Controls.Add(this.ptb_foto);
            this.gp_DadosPessoais.Controls.Add(this.lb_dtaNascimento);
            this.gp_DadosPessoais.Controls.Add(this.lb_Genero);
            this.gp_DadosPessoais.Controls.Add(this.lb_Nome);
            this.gp_DadosPessoais.Controls.Add(this.txt_nome);
            this.gp_DadosPessoais.Controls.Add(this.cb_Nome);
            this.gp_DadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_DadosPessoais.Location = new System.Drawing.Point(11, 11);
            this.gp_DadosPessoais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_DadosPessoais.Name = "gp_DadosPessoais";
            this.gp_DadosPessoais.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_DadosPessoais.Size = new System.Drawing.Size(369, 271);
            this.gp_DadosPessoais.TabIndex = 27;
            this.gp_DadosPessoais.TabStop = false;
            this.gp_DadosPessoais.Text = "Dados Pessoais";
            this.gp_DadosPessoais.Enter += new System.EventHandler(this.gp_DadosPessoais_Enter);
            // 
            // txt_NIF
            // 
            this.txt_NIF.Location = new System.Drawing.Point(86, 157);
            this.txt_NIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NIF.Mask = "000000000";
            this.txt_NIF.Name = "txt_NIF";
            this.txt_NIF.Size = new System.Drawing.Size(73, 21);
            this.txt_NIF.TabIndex = 5;
            this.txt_NIF.Text = "000000000";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(85, 217);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Telefone.Mask = "000000000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(74, 21);
            this.txt_Telefone.TabIndex = 7;
            // 
            // feminino
            // 
            this.feminino.Image = global::Tap.Properties.Resources.female_sign__3_;
            this.feminino.InitialImage = null;
            this.feminino.Location = new System.Drawing.Point(187, 60);
            this.feminino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(44, 42);
            this.feminino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.feminino.TabIndex = 30;
            this.feminino.TabStop = false;
            // 
            // masculino
            // 
            this.masculino.Image = global::Tap.Properties.Resources.male_gender_sign__5_;
            this.masculino.InitialImage = null;
            this.masculino.Location = new System.Drawing.Point(104, 60);
            this.masculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(44, 42);
            this.masculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.masculino.TabIndex = 29;
            this.masculino.TabStop = false;
            // 
            // rb_Feminino
            // 
            this.rb_Feminino.AutoSize = true;
            this.rb_Feminino.Location = new System.Drawing.Point(169, 72);
            this.rb_Feminino.Name = "rb_Feminino";
            this.rb_Feminino.Size = new System.Drawing.Size(14, 13);
            this.rb_Feminino.TabIndex = 3;
            this.rb_Feminino.TabStop = true;
            this.rb_Feminino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(85, 72);
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
            this.lb_Telefone.Location = new System.Drawing.Point(8, 219);
            this.lb_Telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(63, 15);
            this.lb_Telefone.TabIndex = 15;
            this.lb_Telefone.Text = "Telefone *";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(85, 186);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(160, 21);
            this.txt_Email.TabIndex = 6;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(8, 188);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 15);
            this.lb_email.TabIndex = 13;
            this.lb_email.Text = "E-mail *";
            // 
            // dtp_datanascimento
            // 
            this.dtp_datanascimento.Location = new System.Drawing.Point(85, 117);
            this.dtp_datanascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_datanascimento.Name = "dtp_datanascimento";
            this.dtp_datanascimento.Size = new System.Drawing.Size(147, 21);
            this.dtp_datanascimento.TabIndex = 4;
            // 
            // bt_Inserir
            // 
            this.bt_Inserir.Location = new System.Drawing.Point(266, 186);
            this.bt_Inserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Inserir.Name = "bt_Inserir";
            this.bt_Inserir.Size = new System.Drawing.Size(76, 24);
            this.bt_Inserir.TabIndex = 8;
            this.bt_Inserir.Text = "Inserir";
            this.bt_Inserir.UseVisualStyleBackColor = true;
            this.bt_Inserir.Click += new System.EventHandler(this.bt_Inserir_Click_1);
            // 
            // lb_NIF
            // 
            this.lb_NIF.AutoSize = true;
            this.lb_NIF.Location = new System.Drawing.Point(8, 157);
            this.lb_NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NIF.Name = "lb_NIF";
            this.lb_NIF.Size = new System.Drawing.Size(73, 15);
            this.lb_NIF.TabIndex = 2;
            this.lb_NIF.Text = "Nº Contrib. *";
            // 
            // ptb_foto
            // 
            this.ptb_foto.Image = global::Tap.Properties.Resources.Default2;
            this.ptb_foto.Location = new System.Drawing.Point(257, 53);
            this.ptb_foto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(93, 130);
            this.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_foto.TabIndex = 4;
            this.ptb_foto.TabStop = false;
            // 
            // lb_dtaNascimento
            // 
            this.lb_dtaNascimento.AutoSize = true;
            this.lb_dtaNascimento.Location = new System.Drawing.Point(8, 121);
            this.lb_dtaNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_dtaNascimento.Name = "lb_dtaNascimento";
            this.lb_dtaNascimento.Size = new System.Drawing.Size(68, 15);
            this.lb_dtaNascimento.TabIndex = 5;
            this.lb_dtaNascimento.Text = "Dta Nasc. *";
            // 
            // lb_Genero
            // 
            this.lb_Genero.AutoSize = true;
            this.lb_Genero.Location = new System.Drawing.Point(8, 68);
            this.lb_Genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Genero.Name = "lb_Genero";
            this.lb_Genero.Size = new System.Drawing.Size(56, 15);
            this.lb_Genero.TabIndex = 2;
            this.lb_Genero.Text = "Género *";
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(8, 24);
            this.lb_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(49, 15);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome *";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(86, 21);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(266, 21);
            this.txt_nome.TabIndex = 1;
            // 
            // cb_Nome
            // 
            this.cb_Nome.FormattingEnabled = true;
            this.cb_Nome.Location = new System.Drawing.Point(85, 21);
            this.cb_Nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Nome.Name = "cb_Nome";
            this.cb_Nome.Size = new System.Drawing.Size(266, 23);
            this.cb_Nome.TabIndex = 1;
            this.cb_Nome.SelectedIndexChanged += new System.EventHandler(this.cb_Nome_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 26;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Guardar.Image = global::Tap.Properties.Resources.save_disk__2_;
            this.bt_Guardar.Location = new System.Drawing.Point(293, 514);
            this.bt_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(81, 30);
            this.bt_Guardar.TabIndex = 16;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click_1);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.bt_Cancel.Location = new System.Drawing.Point(208, 514);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(81, 30);
            this.bt_Cancel.TabIndex = 17;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // erro_nome
            // 
            this.erro_nome.ContainerControl = this;
            // 
            // erro_contribuinte
            // 
            this.erro_contribuinte.ContainerControl = this;
            // 
            // erro_email
            // 
            this.erro_email.ContainerControl = this;
            // 
            // erro_telefone
            // 
            this.erro_telefone.ContainerControl = this;
            // 
            // erro_rua
            // 
            this.erro_rua.ContainerControl = this;
            // 
            // erro_localidade
            // 
            this.erro_localidade.ContainerControl = this;
            // 
            // erro_codpostal
            // 
            this.erro_codpostal.ContainerControl = this;
            // 
            // erro_numero
            // 
            this.erro_numero.ContainerControl = this;
            // 
            // erro_sexo
            // 
            this.erro_sexo.ContainerControl = this;
            // 
            // erro_curso
            // 
            this.erro_curso.ContainerControl = this;
            // 
            // AdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 556);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.gp_DadosEscolares);
            this.Controls.Add(this.gp_Morada);
            this.Controls.Add(this.gp_DadosPessoais);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bt_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 596);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(407, 595);
            this.Name = "AdicionarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Aluno";
            this.Load += new System.EventHandler(this.AdicionarAluno_Load_1);
            this.gp_DadosEscolares.ResumeLayout(false);
            this.gp_DadosEscolares.PerformLayout();
            this.gp_Morada.ResumeLayout(false);
            this.gp_Morada.PerformLayout();
            this.gp_DadosPessoais.ResumeLayout(false);
            this.gp_DadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feminino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masculino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_contribuinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_rua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_localidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_codpostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_sexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bt_Cancel;
        internal System.Windows.Forms.Button bt_Guardar;
        internal System.Windows.Forms.GroupBox gp_DadosEscolares;
        internal System.Windows.Forms.Label lb_Curso;
        internal System.Windows.Forms.Label lb_numero;
        internal System.Windows.Forms.GroupBox gp_Morada;
        internal System.Windows.Forms.TextBox txt_localidade;
        internal System.Windows.Forms.TextBox txt_Rua;
        internal System.Windows.Forms.Label lb_CodPostal;
        internal System.Windows.Forms.Label lb_Localidade;
        internal System.Windows.Forms.Label lb_Rua;
        internal System.Windows.Forms.GroupBox gp_DadosPessoais;
        internal System.Windows.Forms.Label lb_Telefone;
        internal System.Windows.Forms.TextBox txt_Email;
        internal System.Windows.Forms.Label lb_email;
        internal System.Windows.Forms.DateTimePicker dtp_datanascimento;
        internal System.Windows.Forms.Button bt_Inserir;
        internal System.Windows.Forms.Label lb_NIF;
        internal System.Windows.Forms.PictureBox ptb_foto;
        internal System.Windows.Forms.Label lb_dtaNascimento;
        internal System.Windows.Forms.TextBox txt_nome;
        internal System.Windows.Forms.Label lb_Genero;
        internal System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.ComboBox cb_Nome;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MaskedTextBox txt_Campo1;
        private System.Windows.Forms.MaskedTextBox txt_Campo2;
        private System.Windows.Forms.PictureBox feminino;
        private System.Windows.Forms.PictureBox masculino;
        private System.Windows.Forms.RadioButton rb_Feminino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.RadioButton rb_EI;
        private System.Windows.Forms.RadioButton rb_TDM;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox txt_NIF;
        private System.Windows.Forms.MaskedTextBox txt_Numero;
        private System.Windows.Forms.ErrorProvider erro_nome;
        private System.Windows.Forms.ErrorProvider erro_contribuinte;
        private System.Windows.Forms.ErrorProvider erro_email;
        private System.Windows.Forms.ErrorProvider erro_telefone;
        private System.Windows.Forms.ErrorProvider erro_rua;
        private System.Windows.Forms.ErrorProvider erro_localidade;
        private System.Windows.Forms.ErrorProvider erro_codpostal;
        private System.Windows.Forms.ErrorProvider erro_numero;
        private System.Windows.Forms.ErrorProvider erro_sexo;
        private System.Windows.Forms.ErrorProvider erro_curso;
    }
}