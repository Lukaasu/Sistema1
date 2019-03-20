namespace Cadastro
{
    partial class frmFuncionarios
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbdSolteiro = new System.Windows.Forms.RadioButton();
            this.rbdCasado = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 20);
            this.txtNome.TabIndex = 1;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbdCasado);
            this.gbxEstadoCivil.Controls.Add(this.rbdSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(15, 75);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(200, 44);
            this.gbxEstadoCivil.TabIndex = 2;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "EstadoCivil";
            // 
            // rbdSolteiro
            // 
            this.rbdSolteiro.AutoSize = true;
            this.rbdSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rbdSolteiro.Name = "rbdSolteiro";
            this.rbdSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbdSolteiro.TabIndex = 0;
            this.rbdSolteiro.TabStop = true;
            this.rbdSolteiro.Text = "Solteiro(a)";
            this.rbdSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbdCasado
            // 
            this.rbdCasado.AutoSize = true;
            this.rbdCasado.Location = new System.Drawing.Point(97, 19);
            this.rbdCasado.Name = "rbdCasado";
            this.rbdCasado.Size = new System.Drawing.Size(73, 17);
            this.rbdCasado.TabIndex = 1;
            this.rbdCasado.TabStop = true;
            this.rbdCasado.Text = "Casado(a)";
            this.rbdCasado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(17, 136);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(180, 56);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 208);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbdCasado;
        private System.Windows.Forms.RadioButton rbdSolteiro;
        private System.Windows.Forms.Button btnSalvar;
    }
}