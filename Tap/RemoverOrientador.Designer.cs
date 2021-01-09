namespace Tap
{
    partial class RemoverOrientador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.bt_remover = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_erro
            // 
            this.lb_erro.AutoSize = true;
            this.lb_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_erro.Location = new System.Drawing.Point(65, 41);
            this.lb_erro.Name = "lb_erro";
            this.lb_erro.Size = new System.Drawing.Size(134, 13);
            this.lb_erro.TabIndex = 59;
            this.lb_erro.Text = "Orientador não existente....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_pesquisar);
            this.groupBox1.Controls.Add(this.lb_erro);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.lb_numero);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 73);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Orientador";
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Image = global::Tap.Properties.Resources.magnifier_tool__1_;
            this.bt_pesquisar.Location = new System.Drawing.Point(206, 17);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(23, 23);
            this.bt_pesquisar.TabIndex = 61;
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click_1);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(59, 20);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(142, 20);
            this.txt_numero.TabIndex = 57;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(10, 22);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(44, 13);
            this.lb_numero.TabIndex = 56;
            this.lb_numero.Text = "Numero";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_nome.Location = new System.Drawing.Point(68, 41);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(91, 17);
            this.lb_nome.TabIndex = 60;
            this.lb_nome.Text = "Nome Orientador";
            this.lb_nome.UseCompatibleTextRendering = true;
            this.lb_nome.UseWaitCursor = true;
            // 
            // bt_remover
            // 
            this.bt_remover.Image = global::Tap.Properties.Resources.rubbish_bin;
            this.bt_remover.Location = new System.Drawing.Point(215, 90);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(84, 31);
            this.bt_remover.TabIndex = 62;
            this.bt_remover.Text = "Remover";
            this.bt_remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click_1);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.Bt_Cancel.Location = new System.Drawing.Point(130, 90);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(81, 31);
            this.Bt_Cancel.TabIndex = 61;
            this.Bt_Cancel.Text = "Cancelar";
            this.Bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // RemoverOrientador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 141);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 180);
            this.Name = "RemoverOrientador";
            this.Text = "RemoverOrientador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_erro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Button bt_pesquisar;
    }
}