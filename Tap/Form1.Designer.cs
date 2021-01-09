namespace Tap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.orientadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDadosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TTSL_LB_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.projetoToolStripMenuItem,
            this.ficheiroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem4,
            this.editarToolStripMenuItem1,
            this.removerToolStripMenuItem});
            this.alunoToolStripMenuItem.Image = global::Tap.Properties.Resources.graduate_student_with_graduation_cap_toga_and_tie__1_;
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // adicionarToolStripMenuItem4
            // 
            this.adicionarToolStripMenuItem4.Image = global::Tap.Properties.Resources.plus;
            this.adicionarToolStripMenuItem4.Name = "adicionarToolStripMenuItem4";
            this.adicionarToolStripMenuItem4.Size = new System.Drawing.Size(235, 36);
            this.adicionarToolStripMenuItem4.Text = "Adicionar";
            this.adicionarToolStripMenuItem4.Click += new System.EventHandler(this.adicionarToolStripMenuItem4_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = global::Tap.Properties.Resources.pencil_edit_button__1_;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(235, 36);
            this.editarToolStripMenuItem1.Text = "Editar dados";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem5,
            this.editarToolStripMenuItem2,
            this.removerToolStripMenuItem1});
            this.docenteToolStripMenuItem.Image = global::Tap.Properties.Resources.business_person_silhouette_wearing_tie__1_;
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // adicionarToolStripMenuItem5
            // 
            this.adicionarToolStripMenuItem5.Image = global::Tap.Properties.Resources.plus;
            this.adicionarToolStripMenuItem5.Name = "adicionarToolStripMenuItem5";
            this.adicionarToolStripMenuItem5.Size = new System.Drawing.Size(235, 36);
            this.adicionarToolStripMenuItem5.Text = "Adicionar";
            this.adicionarToolStripMenuItem5.Click += new System.EventHandler(this.adicionarToolStripMenuItem5_Click);
            // 
            // editarToolStripMenuItem2
            // 
            this.editarToolStripMenuItem2.Image = global::Tap.Properties.Resources.pencil_edit_button__1_;
            this.editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            this.editarToolStripMenuItem2.Size = new System.Drawing.Size(235, 36);
            this.editarToolStripMenuItem2.Text = "Editar dados";
            this.editarToolStripMenuItem2.Click += new System.EventHandler(this.editarToolStripMenuItem2_Click);
            // 
            // removerToolStripMenuItem1
            // 
            this.removerToolStripMenuItem1.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            this.removerToolStripMenuItem1.Size = new System.Drawing.Size(235, 36);
            this.removerToolStripMenuItem1.Text = "Remover";
            this.removerToolStripMenuItem1.Click += new System.EventHandler(this.removerToolStripMenuItem1_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem6,
            this.editarDadosToolStripMenuItem3,
            this.removerToolStripMenuItem2});
            this.empresaToolStripMenuItem.Image = global::Tap.Properties.Resources.multiple_users_silhouette__1_;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // adicionarToolStripMenuItem6
            // 
            this.adicionarToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orientadorToolStripMenuItem1,
            this.empresToolStripMenuItem});
            this.adicionarToolStripMenuItem6.Image = global::Tap.Properties.Resources.plus;
            this.adicionarToolStripMenuItem6.Name = "adicionarToolStripMenuItem6";
            this.adicionarToolStripMenuItem6.Size = new System.Drawing.Size(235, 36);
            this.adicionarToolStripMenuItem6.Text = "Adicionar";
            // 
            // orientadorToolStripMenuItem1
            // 
            this.orientadorToolStripMenuItem1.Image = global::Tap.Properties.Resources.multiple_users_silhouette__1_;
            this.orientadorToolStripMenuItem1.Name = "orientadorToolStripMenuItem1";
            this.orientadorToolStripMenuItem1.Size = new System.Drawing.Size(219, 36);
            this.orientadorToolStripMenuItem1.Text = "Empresa";
            this.orientadorToolStripMenuItem1.Click += new System.EventHandler(this.orientadorToolStripMenuItem1_Click);
            // 
            // empresToolStripMenuItem
            // 
            this.empresToolStripMenuItem.Image = global::Tap.Properties.Resources.business_person_silhouette_wearing_tie__1_;
            this.empresToolStripMenuItem.Name = "empresToolStripMenuItem";
            this.empresToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.empresToolStripMenuItem.Text = "Orientador";
            this.empresToolStripMenuItem.Click += new System.EventHandler(this.empresToolStripMenuItem_Click);
            // 
            // editarDadosToolStripMenuItem3
            // 
            this.editarDadosToolStripMenuItem3.Image = global::Tap.Properties.Resources.pencil_edit_button__1_;
            this.editarDadosToolStripMenuItem3.Name = "editarDadosToolStripMenuItem3";
            this.editarDadosToolStripMenuItem3.Size = new System.Drawing.Size(235, 36);
            this.editarDadosToolStripMenuItem3.Text = "Editar dados";
            this.editarDadosToolStripMenuItem3.Click += new System.EventHandler(this.editarDadosToolStripMenuItem3_Click);
            // 
            // removerToolStripMenuItem2
            // 
            this.removerToolStripMenuItem2.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.removerToolStripMenuItem2.Name = "removerToolStripMenuItem2";
            this.removerToolStripMenuItem2.Size = new System.Drawing.Size(235, 36);
            this.removerToolStripMenuItem2.Text = "Remover";
            this.removerToolStripMenuItem2.Click += new System.EventHandler(this.removerToolStripMenuItem2_Click);
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem7,
            this.editarToolStripMenuItem3,
            this.removerToolStripMenuItem3});
            this.projetoToolStripMenuItem.Image = global::Tap.Properties.Resources.edit1;
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.projetoToolStripMenuItem.Text = "Projeto";
            // 
            // adicionarToolStripMenuItem7
            // 
            this.adicionarToolStripMenuItem7.Image = global::Tap.Properties.Resources.plus;
            this.adicionarToolStripMenuItem7.Name = "adicionarToolStripMenuItem7";
            this.adicionarToolStripMenuItem7.Size = new System.Drawing.Size(204, 36);
            this.adicionarToolStripMenuItem7.Text = "Adicionar";
            this.adicionarToolStripMenuItem7.Click += new System.EventHandler(this.adicionarToolStripMenuItem7_Click);
            // 
            // editarToolStripMenuItem3
            // 
            this.editarToolStripMenuItem3.Image = global::Tap.Properties.Resources.pencil_edit_button__1_;
            this.editarToolStripMenuItem3.Name = "editarToolStripMenuItem3";
            this.editarToolStripMenuItem3.Size = new System.Drawing.Size(204, 36);
            this.editarToolStripMenuItem3.Text = "Editar";
            this.editarToolStripMenuItem3.Click += new System.EventHandler(this.editarToolStripMenuItem3_Click);
            // 
            // removerToolStripMenuItem3
            // 
            this.removerToolStripMenuItem3.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.removerToolStripMenuItem3.Name = "removerToolStripMenuItem3";
            this.removerToolStripMenuItem3.Size = new System.Drawing.Size(204, 36);
            this.removerToolStripMenuItem3.Text = "Remover";
            this.removerToolStripMenuItem3.Click += new System.EventHandler(this.removerToolStripMenuItem3_Click);
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.lerToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Image = global::Tap.Properties.Resources.folder;
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Tap.Properties.Resources.save_disk;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // lerToolStripMenuItem
            // 
            this.lerToolStripMenuItem.Image = global::Tap.Properties.Resources.open_book;
            this.lerToolStripMenuItem.Name = "lerToolStripMenuItem";
            this.lerToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.lerToolStripMenuItem.Text = "Ler";
            this.lerToolStripMenuItem.Click += new System.EventHandler(this.lerToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Tap.Properties.Resources.bleach_sign;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTSL_LB_User});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TTSL_LB_User
            // 
            this.TTSL_LB_User.Name = "TTSL_LB_User";
            this.TTSL_LB_User.Size = new System.Drawing.Size(45, 17);
            this.TTSL_LB_User.Text = "Default";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 276);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem orientadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDadosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TTSL_LB_User;
    }
}

