namespace Racoon
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirNovoChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.chamadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovoUsuárioToolStripMenuItem,
            this.editarUsuárioToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // criarNovoUsuárioToolStripMenuItem
            // 
            this.criarNovoUsuárioToolStripMenuItem.Name = "criarNovoUsuárioToolStripMenuItem";
            this.criarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarNovoUsuárioToolStripMenuItem.Text = "Criar Novo Usuário";
            this.criarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.criarNovoUsuárioToolStripMenuItem_Click);
            // 
            // editarUsuárioToolStripMenuItem
            // 
            this.editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            this.editarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarUsuárioToolStripMenuItem.Text = "Listar Usuários";
            // 
            // chamadosToolStripMenuItem
            // 
            this.chamadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirNovoChamadoToolStripMenuItem});
            this.chamadosToolStripMenuItem.Name = "chamadosToolStripMenuItem";
            this.chamadosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.chamadosToolStripMenuItem.Text = "Chamados";
            // 
            // abrirNovoChamadoToolStripMenuItem
            // 
            this.abrirNovoChamadoToolStripMenuItem.Name = "abrirNovoChamadoToolStripMenuItem";
            this.abrirNovoChamadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirNovoChamadoToolStripMenuItem.Text = "Novo Chamado";
            this.abrirNovoChamadoToolStripMenuItem.Click += new System.EventHandler(this.abrirNovoChamadoToolStripMenuItem_Click);
            // 
            // dgvChamados
            // 
            this.dgvChamados.AllowUserToResizeColumns = false;
            this.dgvChamados.AllowUserToResizeRows = false;
            this.dgvChamados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChamados.Location = new System.Drawing.Point(93, 40);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.ReadOnly = true;
            this.dgvChamados.RowHeadersVisible = false;
            this.dgvChamados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChamados.ShowCellErrors = false;
            this.dgvChamados.Size = new System.Drawing.Size(629, 282);
            this.dgvChamados.TabIndex = 2;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(617, 0);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(105, 23);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "Encerrar Sessão";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(13, 40);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(12, 69);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "Excluir Tudo";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.dgvChamados);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racoon 1.0";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirNovoChamadoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}