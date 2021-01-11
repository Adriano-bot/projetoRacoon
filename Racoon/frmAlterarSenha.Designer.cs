namespace Racoon
{
    partial class frmAlterarSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfNovaSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nova Senha:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(89, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(147, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(89, 42);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(147, 20);
            this.txtNovaSenha.TabIndex = 5;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Location = new System.Drawing.Point(74, 114);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(100, 23);
            this.btnAlterarSenha.TabIndex = 6;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Nova Senha:";
            // 
            // txtConfNovaSenha
            // 
            this.txtConfNovaSenha.Location = new System.Drawing.Point(136, 76);
            this.txtConfNovaSenha.Name = "txtConfNovaSenha";
            this.txtConfNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfNovaSenha.TabIndex = 8;
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 151);
            this.Controls.Add(this.txtConfNovaSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterarSenha";
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.frmAlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfNovaSenha;
    }
}