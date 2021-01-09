namespace Tap
{
    partial class AdicionarProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProjeto));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_notaFinal = new System.Windows.Forms.TextBox();
            this.lb_notaFinal = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.cb_NifEmpresa = new System.Windows.Forms.ComboBox();
            this.lb_NomeProj = new System.Windows.Forms.Label();
            this.lb_NIFEmpresa = new System.Windows.Forms.Label();
            this.Lb_Objetivo = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.lb_Descricao = new System.Windows.Forms.Label();
            this.txt_Objetivo = new System.Windows.Forms.TextBox();
            this.txt_NomeProj = new System.Windows.Forms.TextBox();
            this.cb_NomeProj = new System.Windows.Forms.ComboBox();
            this.gb_intervenientes = new System.Windows.Forms.GroupBox();
            this.cb_Orientador = new System.Windows.Forms.ComboBox();
            this.lb_Orientador = new System.Windows.Forms.Label();
            this.cb_Docente = new System.Windows.Forms.ComboBox();
            this.cb_Alunos = new System.Windows.Forms.ComboBox();
            this.Lb_Docente = new System.Windows.Forms.Label();
            this.Lb_aluno = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.erro_nome = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_objetivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_descricao = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            this.gb_intervenientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_objetivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_descricao)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txt_notaFinal);
            this.GroupBox1.Controls.Add(this.lb_notaFinal);
            this.GroupBox1.Controls.Add(this.txt_numero);
            this.GroupBox1.Controls.Add(this.lb_numero);
            this.GroupBox1.Controls.Add(this.cb_NifEmpresa);
            this.GroupBox1.Controls.Add(this.lb_NomeProj);
            this.GroupBox1.Controls.Add(this.lb_NIFEmpresa);
            this.GroupBox1.Controls.Add(this.Lb_Objetivo);
            this.GroupBox1.Controls.Add(this.txt_Descricao);
            this.GroupBox1.Controls.Add(this.lb_Descricao);
            this.GroupBox1.Controls.Add(this.txt_Objetivo);
            this.GroupBox1.Controls.Add(this.txt_NomeProj);
            this.GroupBox1.Controls.Add(this.cb_NomeProj);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 11);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(344, 307);
            this.GroupBox1.TabIndex = 29;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Dados Projecto";
            // 
            // txt_notaFinal
            // 
            this.txt_notaFinal.Location = new System.Drawing.Point(100, 273);
            this.txt_notaFinal.Name = "txt_notaFinal";
            this.txt_notaFinal.Size = new System.Drawing.Size(125, 21);
            this.txt_notaFinal.TabIndex = 17;
            // 
            // lb_notaFinal
            // 
            this.lb_notaFinal.AutoSize = true;
            this.lb_notaFinal.Location = new System.Drawing.Point(18, 273);
            this.lb_notaFinal.Name = "lb_notaFinal";
            this.lb_notaFinal.Size = new System.Drawing.Size(63, 15);
            this.lb_notaFinal.TabIndex = 16;
            this.lb_notaFinal.Text = "Nota Final";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(101, 57);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(2);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(160, 21);
            this.txt_numero.TabIndex = 15;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(16, 57);
            this.lb_numero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(60, 15);
            this.lb_numero.TabIndex = 14;
            this.lb_numero.Text = "Numero *";
            // 
            // cb_NifEmpresa
            // 
            this.cb_NifEmpresa.FormattingEnabled = true;
            this.cb_NifEmpresa.Location = new System.Drawing.Point(100, 84);
            this.cb_NifEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.cb_NifEmpresa.Name = "cb_NifEmpresa";
            this.cb_NifEmpresa.Size = new System.Drawing.Size(125, 23);
            this.cb_NifEmpresa.TabIndex = 3;
            this.cb_NifEmpresa.SelectedIndexChanged += new System.EventHandler(this.cb_NifEmpresa_SelectedIndexChanged);
            // 
            // lb_NomeProj
            // 
            this.lb_NomeProj.AutoSize = true;
            this.lb_NomeProj.Location = new System.Drawing.Point(11, 24);
            this.lb_NomeProj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NomeProj.Name = "lb_NomeProj";
            this.lb_NomeProj.Size = new System.Drawing.Size(77, 15);
            this.lb_NomeProj.TabIndex = 0;
            this.lb_NomeProj.Text = "Nome Proj. *";
            // 
            // lb_NIFEmpresa
            // 
            this.lb_NIFEmpresa.AutoSize = true;
            this.lb_NIFEmpresa.Location = new System.Drawing.Point(11, 86);
            this.lb_NIFEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NIFEmpresa.Name = "lb_NIFEmpresa";
            this.lb_NIFEmpresa.Size = new System.Drawing.Size(87, 15);
            this.lb_NIFEmpresa.TabIndex = 1;
            this.lb_NIFEmpresa.Text = "NIF Empresa *";
            // 
            // Lb_Objetivo
            // 
            this.Lb_Objetivo.AutoSize = true;
            this.Lb_Objetivo.Location = new System.Drawing.Point(11, 110);
            this.Lb_Objetivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Objetivo.Name = "Lb_Objetivo";
            this.Lb_Objetivo.Size = new System.Drawing.Size(65, 15);
            this.Lb_Objetivo.TabIndex = 2;
            this.Lb_Objetivo.Text = "Objectivo *";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(100, 193);
            this.txt_Descricao.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(224, 71);
            this.txt_Descricao.TabIndex = 5;
            // 
            // lb_Descricao
            // 
            this.lb_Descricao.AutoSize = true;
            this.lb_Descricao.Location = new System.Drawing.Point(11, 188);
            this.lb_Descricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Descricao.Name = "lb_Descricao";
            this.lb_Descricao.Size = new System.Drawing.Size(70, 15);
            this.lb_Descricao.TabIndex = 3;
            this.lb_Descricao.Text = "Descrição *";
            // 
            // txt_Objetivo
            // 
            this.txt_Objetivo.Location = new System.Drawing.Point(100, 114);
            this.txt_Objetivo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Objetivo.Multiline = true;
            this.txt_Objetivo.Name = "txt_Objetivo";
            this.txt_Objetivo.Size = new System.Drawing.Size(224, 69);
            this.txt_Objetivo.TabIndex = 4;
            // 
            // txt_NomeProj
            // 
            this.txt_NomeProj.Location = new System.Drawing.Point(100, 28);
            this.txt_NomeProj.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NomeProj.Name = "txt_NomeProj";
            this.txt_NomeProj.Size = new System.Drawing.Size(224, 21);
            this.txt_NomeProj.TabIndex = 1;
            // 
            // cb_NomeProj
            // 
            this.cb_NomeProj.FormattingEnabled = true;
            this.cb_NomeProj.Location = new System.Drawing.Point(100, 28);
            this.cb_NomeProj.Margin = new System.Windows.Forms.Padding(2);
            this.cb_NomeProj.Name = "cb_NomeProj";
            this.cb_NomeProj.Size = new System.Drawing.Size(224, 23);
            this.cb_NomeProj.TabIndex = 1;
            this.cb_NomeProj.SelectedIndexChanged += new System.EventHandler(this.cb_NomeProj_SelectedIndexChanged);
            // 
            // gb_intervenientes
            // 
            this.gb_intervenientes.Controls.Add(this.cb_Orientador);
            this.gb_intervenientes.Controls.Add(this.lb_Orientador);
            this.gb_intervenientes.Controls.Add(this.cb_Docente);
            this.gb_intervenientes.Controls.Add(this.cb_Alunos);
            this.gb_intervenientes.Controls.Add(this.Lb_Docente);
            this.gb_intervenientes.Controls.Add(this.Lb_aluno);
            this.gb_intervenientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_intervenientes.Location = new System.Drawing.Point(11, 322);
            this.gb_intervenientes.Margin = new System.Windows.Forms.Padding(2);
            this.gb_intervenientes.Name = "gb_intervenientes";
            this.gb_intervenientes.Padding = new System.Windows.Forms.Padding(2);
            this.gb_intervenientes.Size = new System.Drawing.Size(344, 115);
            this.gb_intervenientes.TabIndex = 28;
            this.gb_intervenientes.TabStop = false;
            this.gb_intervenientes.Text = "Intervenientes";
            // 
            // cb_Orientador
            // 
            this.cb_Orientador.FormattingEnabled = true;
            this.cb_Orientador.Location = new System.Drawing.Point(100, 83);
            this.cb_Orientador.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Orientador.Name = "cb_Orientador";
            this.cb_Orientador.Size = new System.Drawing.Size(223, 23);
            this.cb_Orientador.TabIndex = 8;
            // 
            // lb_Orientador
            // 
            this.lb_Orientador.AutoSize = true;
            this.lb_Orientador.Location = new System.Drawing.Point(17, 84);
            this.lb_Orientador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Orientador.Name = "lb_Orientador";
            this.lb_Orientador.Size = new System.Drawing.Size(73, 15);
            this.lb_Orientador.TabIndex = 8;
            this.lb_Orientador.Text = "Orientador *";
            // 
            // cb_Docente
            // 
            this.cb_Docente.FormattingEnabled = true;
            this.cb_Docente.Location = new System.Drawing.Point(100, 54);
            this.cb_Docente.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Docente.Name = "cb_Docente";
            this.cb_Docente.Size = new System.Drawing.Size(223, 23);
            this.cb_Docente.TabIndex = 7;
            // 
            // cb_Alunos
            // 
            this.cb_Alunos.FormattingEnabled = true;
            this.cb_Alunos.Location = new System.Drawing.Point(100, 25);
            this.cb_Alunos.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Alunos.Name = "cb_Alunos";
            this.cb_Alunos.Size = new System.Drawing.Size(223, 23);
            this.cb_Alunos.TabIndex = 6;
            this.cb_Alunos.SelectedIndexChanged += new System.EventHandler(this.cb_Alunos_SelectedIndexChanged_1);
            // 
            // Lb_Docente
            // 
            this.Lb_Docente.AutoSize = true;
            this.Lb_Docente.Location = new System.Drawing.Point(18, 55);
            this.Lb_Docente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Docente.Name = "Lb_Docente";
            this.Lb_Docente.Size = new System.Drawing.Size(61, 15);
            this.Lb_Docente.TabIndex = 5;
            this.Lb_Docente.Text = "Docente *";
            // 
            // Lb_aluno
            // 
            this.Lb_aluno.AutoSize = true;
            this.Lb_aluno.Location = new System.Drawing.Point(17, 28);
            this.Lb_aluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_aluno.Name = "Lb_aluno";
            this.Lb_aluno.Size = new System.Drawing.Size(46, 15);
            this.Lb_aluno.TabIndex = 4;
            this.Lb_aluno.Text = "Aluno *";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.bt_Cancel.Location = new System.Drawing.Point(190, 440);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(81, 32);
            this.bt_Cancel.TabIndex = 10;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click_1);
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Guardar.Image = global::Tap.Properties.Resources.save_disk__2_;
            this.bt_Guardar.Location = new System.Drawing.Point(275, 440);
            this.bt_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(81, 32);
            this.bt_Guardar.TabIndex = 9;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click_1);
            // 
            // erro_nome
            // 
            this.erro_nome.ContainerControl = this;
            // 
            // erro_objetivo
            // 
            this.erro_objetivo.ContainerControl = this;
            // 
            // erro_descricao
            // 
            this.erro_descricao.ContainerControl = this;
            // 
            // AdicionarProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 493);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gb_intervenientes);
            this.Controls.Add(this.bt_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 532);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 532);
            this.Name = "AdicionarProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarProjeto";
            this.Load += new System.EventHandler(this.AdicionarProjeto_Load_1);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gb_intervenientes.ResumeLayout(false);
            this.gb_intervenientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro_nome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_objetivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_descricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button bt_Cancel;
        internal System.Windows.Forms.Button bt_Guardar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lb_NomeProj;
        internal System.Windows.Forms.Label lb_NIFEmpresa;
        internal System.Windows.Forms.Label Lb_Objetivo;
        internal System.Windows.Forms.TextBox txt_Descricao;
        internal System.Windows.Forms.Label lb_Descricao;
        internal System.Windows.Forms.TextBox txt_Objetivo;
        internal System.Windows.Forms.TextBox txt_NomeProj;
        private System.Windows.Forms.ComboBox cb_NomeProj;
        internal System.Windows.Forms.GroupBox gb_intervenientes;
        internal System.Windows.Forms.ComboBox cb_Orientador;
        internal System.Windows.Forms.Label lb_Orientador;
        internal System.Windows.Forms.ComboBox cb_Docente;
        internal System.Windows.Forms.ComboBox cb_Alunos;
        internal System.Windows.Forms.Label Lb_Docente;
        internal System.Windows.Forms.Label Lb_aluno;
        internal System.Windows.Forms.ComboBox cb_NifEmpresa;
        private System.Windows.Forms.ErrorProvider erro_nome;
        private System.Windows.Forms.ErrorProvider erro_objetivo;
        private System.Windows.Forms.ErrorProvider erro_descricao;
        private System.Windows.Forms.TextBox txt_notaFinal;
        private System.Windows.Forms.Label lb_notaFinal;
        internal System.Windows.Forms.TextBox txt_numero;
        internal System.Windows.Forms.Label lb_numero;
    }
}