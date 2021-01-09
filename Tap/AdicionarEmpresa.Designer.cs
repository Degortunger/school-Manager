namespace Tap
{
    partial class AdicionarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarEmpresa));
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Actividade = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_Fax = new System.Windows.Forms.Label();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.lb_atividade = new System.Windows.Forms.Label();
            this.lb_NIF = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.cb_NomeEmpresa = new System.Windows.Forms.ComboBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_FAX = new System.Windows.Forms.MaskedTextBox();
            this.txt_nif = new System.Windows.Forms.MaskedTextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.erro_nomeempresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_NifEmpresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_atividadeEmpresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_telefoneempresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_faxempresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.erro_emailempresa = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erro_nomeempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_NifEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_atividadeEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefoneempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_faxempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_emailempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(92, 190);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(163, 20);
            this.txt_Email.TabIndex = 6;
            // 
            // txt_Actividade
            // 
            this.txt_Actividade.Location = new System.Drawing.Point(92, 71);
            this.txt_Actividade.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Actividade.Multiline = true;
            this.txt_Actividade.Name = "txt_Actividade";
            this.txt_Actividade.Size = new System.Drawing.Size(259, 46);
            this.txt_Actividade.TabIndex = 3;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(92, 17);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(260, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(20, 192);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 15);
            this.lb_email.TabIndex = 41;
            this.lb_email.Text = "E-Mail *";
            // 
            // lb_Fax
            // 
            this.lb_Fax.AutoSize = true;
            this.lb_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fax.Location = new System.Drawing.Point(20, 157);
            this.lb_Fax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Fax.Name = "lb_Fax";
            this.lb_Fax.Size = new System.Drawing.Size(37, 15);
            this.lb_Fax.TabIndex = 40;
            this.lb_Fax.Text = "FAX *";
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Telefone.Location = new System.Drawing.Point(20, 130);
            this.lb_Telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(63, 15);
            this.lb_Telefone.TabIndex = 39;
            this.lb_Telefone.Text = "Telefone *";
            // 
            // lb_atividade
            // 
            this.lb_atividade.AutoSize = true;
            this.lb_atividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_atividade.Location = new System.Drawing.Point(20, 73);
            this.lb_atividade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_atividade.Name = "lb_atividade";
            this.lb_atividade.Size = new System.Drawing.Size(70, 15);
            this.lb_atividade.TabIndex = 38;
            this.lb_atividade.Text = "Actividade *";
            // 
            // lb_NIF
            // 
            this.lb_NIF.AutoSize = true;
            this.lb_NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NIF.Location = new System.Drawing.Point(20, 44);
            this.lb_NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NIF.Name = "lb_NIF";
            this.lb_NIF.Size = new System.Drawing.Size(72, 15);
            this.lb_NIF.TabIndex = 37;
            this.lb_NIF.Text = "N. Contrib. *";
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(20, 13);
            this.lb_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(49, 15);
            this.lb_Nome.TabIndex = 36;
            this.lb_Nome.Text = "Nome *";
            // 
            // cb_NomeEmpresa
            // 
            this.cb_NomeEmpresa.FormattingEnabled = true;
            this.cb_NomeEmpresa.Location = new System.Drawing.Point(92, 11);
            this.cb_NomeEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.cb_NomeEmpresa.Name = "cb_NomeEmpresa";
            this.cb_NomeEmpresa.Size = new System.Drawing.Size(260, 21);
            this.cb_NomeEmpresa.TabIndex = 1;
            this.cb_NomeEmpresa.SelectedIndexChanged += new System.EventHandler(this.cb_NomeEmpresa_SelectedIndexChanged_1);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(92, 128);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefone.Mask = "000000000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(128, 20);
            this.txt_telefone.TabIndex = 4;
            // 
            // txt_FAX
            // 
            this.txt_FAX.Location = new System.Drawing.Point(92, 154);
            this.txt_FAX.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FAX.Mask = "000000000";
            this.txt_FAX.Name = "txt_FAX";
            this.txt_FAX.Size = new System.Drawing.Size(128, 20);
            this.txt_FAX.TabIndex = 5;
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(92, 41);
            this.txt_nif.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nif.Mask = "000000000";
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(136, 20);
            this.txt_nif.TabIndex = 2;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Image = global::Tap.Properties.Resources.cancel_cross;
            this.bt_Cancel.Location = new System.Drawing.Point(182, 552);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(81, 30);
            this.bt_Cancel.TabIndex = 8;
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
            this.bt_Guardar.Location = new System.Drawing.Point(266, 552);
            this.bt_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(81, 30);
            this.bt_Guardar.TabIndex = 7;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click_1);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(23, 226);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(323, 305);
            this.gmap.TabIndex = 42;
            this.gmap.Zoom = 0D;
            // 
            // erro_nomeempresa
            // 
            this.erro_nomeempresa.ContainerControl = this;
            // 
            // erro_NifEmpresa
            // 
            this.erro_NifEmpresa.ContainerControl = this;
            // 
            // erro_atividadeEmpresa
            // 
            this.erro_atividadeEmpresa.ContainerControl = this;
            // 
            // erro_telefoneempresa
            // 
            this.erro_telefoneempresa.ContainerControl = this;
            // 
            // erro_faxempresa
            // 
            this.erro_faxempresa.ContainerControl = this;
            // 
            // erro_emailempresa
            // 
            this.erro_emailempresa.ContainerControl = this;
            // 
            // AdicionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 593);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.txt_nif);
            this.Controls.Add(this.txt_FAX);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Actividade);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_Fax);
            this.Controls.Add(this.lb_Telefone);
            this.Controls.Add(this.lb_atividade);
            this.Controls.Add(this.lb_NIF);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.cb_NomeEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 632);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 632);
            this.Name = "AdicionarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarEmpresa";
            this.Load += new System.EventHandler(this.AdicionarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erro_nomeempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_NifEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_atividadeEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_telefoneempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_faxempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro_emailempresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bt_Cancel;
        internal System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Actividade;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_Fax;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.Label lb_atividade;
        private System.Windows.Forms.Label lb_NIF;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.ComboBox cb_NomeEmpresa;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_FAX;
        private System.Windows.Forms.MaskedTextBox txt_nif;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ErrorProvider erro_nomeempresa;
        private System.Windows.Forms.ErrorProvider erro_NifEmpresa;
        private System.Windows.Forms.ErrorProvider erro_atividadeEmpresa;
        private System.Windows.Forms.ErrorProvider erro_telefoneempresa;
        private System.Windows.Forms.ErrorProvider erro_faxempresa;
        private System.Windows.Forms.ErrorProvider erro_emailempresa;
    }
}