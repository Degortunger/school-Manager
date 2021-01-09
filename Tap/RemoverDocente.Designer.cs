namespace Tap
{
    partial class RemoverDocente
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
            this.lb_erro = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.gb_EliminarDocente = new System.Windows.Forms.GroupBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.bt_remover = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.gb_EliminarDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_erro
            // 
            this.lb_erro.AutoSize = true;
            this.lb_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_erro.Location = new System.Drawing.Point(54, 47);
            this.lb_erro.Name = "lb_erro";
            this.lb_erro.Size = new System.Drawing.Size(126, 13);
            this.lb_erro.TabIndex = 57;
            this.lb_erro.Text = "Docente não existente....";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_nome.Location = new System.Drawing.Point(54, 47);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(82, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome Completo";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(9, 26);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(44, 13);
            this.lb_numero.TabIndex = 2;
            this.lb_numero.Text = "Número";
            // 
            // gb_EliminarDocente
            // 
            this.gb_EliminarDocente.Controls.Add(this.bt_pesquisar);
            this.gb_EliminarDocente.Controls.Add(this.lb_erro);
            this.gb_EliminarDocente.Controls.Add(this.txt_numero);
            this.gb_EliminarDocente.Controls.Add(this.lb_nome);
            this.gb_EliminarDocente.Controls.Add(this.lb_numero);
            this.gb_EliminarDocente.Location = new System.Drawing.Point(10, 11);
            this.gb_EliminarDocente.Name = "gb_EliminarDocente";
            this.gb_EliminarDocente.Size = new System.Drawing.Size(215, 68);
            this.gb_EliminarDocente.TabIndex = 56;
            this.gb_EliminarDocente.TabStop = false;
            this.gb_EliminarDocente.Text = "Eliminar Docente";
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Image = global::Tap.Properties.Resources.magnifier_tool__1_;
            this.bt_pesquisar.Location = new System.Drawing.Point(186, 23);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(23, 23);
            this.bt_pesquisar.TabIndex = 58;
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click_1);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(59, 23);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(121, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // bt_remover
            // 
            this.bt_remover.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.bt_remover.Location = new System.Drawing.Point(138, 85);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(87, 31);
            this.bt_remover.TabIndex = 58;
            this.bt_remover.Text = "Remover";
            this.bt_remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.Bt_Cancel.Location = new System.Drawing.Point(50, 85);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(82, 31);
            this.Bt_Cancel.TabIndex = 57;
            this.Bt_Cancel.Text = "Cancelar";
            this.Bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click_1);
            // 
            // RemoverDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 124);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.gb_EliminarDocente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(258, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 163);
            this.Name = "RemoverDocente";
            this.Text = "RemoverDocente";
            this.gb_EliminarDocente.ResumeLayout(false);
            this.gb_EliminarDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_erro;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.GroupBox gb_EliminarDocente;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Button bt_pesquisar;
    }
}