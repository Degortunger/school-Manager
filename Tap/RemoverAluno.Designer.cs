namespace Tap
{
    partial class RemoverAluno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.lb_erro = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.txt_contribuinte = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.bt_remover = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_pesquisar);
            this.groupBox1.Controls.Add(this.lb_erro);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Controls.Add(this.txt_contribuinte);
            this.groupBox1.Controls.Add(this.lb_numero);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 81);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Aluno";
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Image = global::Tap.Properties.Resources.magnifier_tool__1_;
            this.bt_pesquisar.Location = new System.Drawing.Point(189, 18);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(23, 23);
            this.bt_pesquisar.TabIndex = 56;
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click_1);
            // 
            // lb_erro
            // 
            this.lb_erro.AutoSize = true;
            this.lb_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_erro.Location = new System.Drawing.Point(65, 53);
            this.lb_erro.Name = "lb_erro";
            this.lb_erro.Size = new System.Drawing.Size(112, 13);
            this.lb_erro.TabIndex = 54;
            this.lb_erro.Text = "Aluno não existente....";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_nome.Location = new System.Drawing.Point(65, 53);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(65, 13);
            this.lb_nome.TabIndex = 55;
            this.lb_nome.Text = "Nome Aluno";
            // 
            // txt_contribuinte
            // 
            this.txt_contribuinte.Location = new System.Drawing.Point(55, 20);
            this.txt_contribuinte.Name = "txt_contribuinte";
            this.txt_contribuinte.Size = new System.Drawing.Size(129, 20);
            this.txt_contribuinte.TabIndex = 30;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(5, 23);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(44, 13);
            this.lb_numero.TabIndex = 19;
            this.lb_numero.Text = "Numero";
            // 
            // bt_remover
            // 
            this.bt_remover.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.bt_remover.Location = new System.Drawing.Point(186, 98);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(75, 31);
            this.bt_remover.TabIndex = 32;
            this.bt_remover.Text = "Remover";
            this.bt_remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click_1);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.Bt_Cancel.Location = new System.Drawing.Point(105, 98);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(75, 31);
            this.Bt_Cancel.TabIndex = 31;
            this.Bt_Cancel.Text = "Cancelar";
            this.Bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // RemoverAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 150);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 189);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(288, 189);
            this.Name = "RemoverAluno";
            this.Text = "RemoverAluno";
            this.Load += new System.EventHandler(this.RemoverAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Label lb_erro;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_contribuinte;
        private System.Windows.Forms.Label lb_numero;
    }
}