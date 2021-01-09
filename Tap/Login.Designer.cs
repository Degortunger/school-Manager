namespace Tap
{
    partial class Login
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
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.cb_tipoUtilizador = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Lb_tipo = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Username);
            this.groupBox1.Controls.Add(this.lb_Password);
            this.groupBox1.Controls.Add(this.cb_tipoUtilizador);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.Lb_tipo);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(14, 57);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(55, 13);
            this.lb_Username.TabIndex = 2;
            this.lb_Username.Text = "Username";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(16, 88);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Password";
            // 
            // cb_tipoUtilizador
            // 
            this.cb_tipoUtilizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoUtilizador.FormattingEnabled = true;
            this.cb_tipoUtilizador.Items.AddRange(new object[] {
            "Aluno",
            "Orientador",
            "Docente",
            "Empresa"});
            this.cb_tipoUtilizador.Location = new System.Drawing.Point(75, 27);
            this.cb_tipoUtilizador.Name = "cb_tipoUtilizador";
            this.cb_tipoUtilizador.Size = new System.Drawing.Size(169, 21);
            this.cb_tipoUtilizador.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(75, 85);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(169, 20);
            this.txt_Password.TabIndex = 5;
            // 
            // Lb_tipo
            // 
            this.Lb_tipo.AutoSize = true;
            this.Lb_tipo.Location = new System.Drawing.Point(19, 30);
            this.Lb_tipo.Name = "Lb_tipo";
            this.Lb_tipo.Size = new System.Drawing.Size(50, 13);
            this.Lb_tipo.TabIndex = 0;
            this.Lb_tipo.Text = "Utilizador";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(75, 57);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(169, 20);
            this.txt_username.TabIndex = 4;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.bt_cancel.Location = new System.Drawing.Point(125, 142);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 30);
            this.bt_cancel.TabIndex = 11;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::Tap.Properties.Resources.checkmark_for_verification__1_;
            this.button1.Location = new System.Drawing.Point(206, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 187);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 226);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 226);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.ComboBox cb_tipoUtilizador;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label Lb_tipo;
        private System.Windows.Forms.TextBox txt_username;
    }
}