namespace App_BancoABC
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevantarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FicheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CriarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AbrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GerarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContaToolStripMenuItem,
            this.OperaçõesToolStripMenuItem,
            this.FicheiroToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(816, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menustrip";
            // 
            // ContaToolStripMenuItem
            // 
            this.ContaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovaToolStripMenuItem,
            this.EncerrarToolStripMenuItem,
            this.toolStripSeparator1,
            this.SairToolStripMenuItem});
            this.ContaToolStripMenuItem.Name = "ContaToolStripMenuItem";
            this.ContaToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.ContaToolStripMenuItem.Text = "&Contas";
            // 
            // NovaToolStripMenuItem
            // 
            this.NovaToolStripMenuItem.Name = "NovaToolStripMenuItem";
            this.NovaToolStripMenuItem.Size = new System.Drawing.Size(208, 40);
            this.NovaToolStripMenuItem.Text = "&Nova";
            this.NovaToolStripMenuItem.Click += new System.EventHandler(this.novaToolStripMenuItem_Click);
            // 
            // EncerrarToolStripMenuItem
            // 
            this.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem";
            this.EncerrarToolStripMenuItem.Size = new System.Drawing.Size(208, 40);
            this.EncerrarToolStripMenuItem.Text = "&Encerrar";
            this.EncerrarToolStripMenuItem.Click += new System.EventHandler(this.EncerrarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(208, 40);
            this.SairToolStripMenuItem.Text = "&Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // OperaçõesToolStripMenuItem
            // 
            this.OperaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LevantarToolStripMenuItem,
            this.DepósitoToolStripMenuItem});
            this.OperaçõesToolStripMenuItem.Name = "OperaçõesToolStripMenuItem";
            this.OperaçõesToolStripMenuItem.Size = new System.Drawing.Size(145, 36);
            this.OperaçõesToolStripMenuItem.Text = "&Operações";
            // 
            // LevantarToolStripMenuItem
            // 
            this.LevantarToolStripMenuItem.Name = "LevantarToolStripMenuItem";
            this.LevantarToolStripMenuItem.Size = new System.Drawing.Size(275, 40);
            this.LevantarToolStripMenuItem.Text = "&Levantamento";
            this.LevantarToolStripMenuItem.Click += new System.EventHandler(this.levantarToolStripMenuItem_Click);
            // 
            // DepósitoToolStripMenuItem
            // 
            this.DepósitoToolStripMenuItem.Name = "DepósitoToolStripMenuItem";
            this.DepósitoToolStripMenuItem.Size = new System.Drawing.Size(275, 40);
            this.DepósitoToolStripMenuItem.Text = "&Depósito";
            this.DepósitoToolStripMenuItem.Click += new System.EventHandler(this.depósitoToolStripMenuItem_Click);
            // 
            // FicheiroToolStripMenuItem
            // 
            this.FicheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CriarToolStripMenuItem,
            this.toolStripSeparator3,
            this.AbrirToolStripMenuItem,
            this.GuardarToolStripMenuItem,
            this.toolStripSeparator2,
            this.GerarXMLToolStripMenuItem});
            this.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem";
            this.FicheiroToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.FicheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // CriarToolStripMenuItem
            // 
            this.CriarToolStripMenuItem.Name = "CriarToolStripMenuItem";
            this.CriarToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.CriarToolStripMenuItem.Text = "&Criar";
            this.CriarToolStripMenuItem.Click += new System.EventHandler(this.CriarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // AbrirToolStripMenuItem
            // 
            this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
            this.AbrirToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.AbrirToolStripMenuItem.Text = "&Abrir";
            this.AbrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.GuardarToolStripMenuItem.Text = "&Gravar";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // GerarXMLToolStripMenuItem
            // 
            this.GerarXMLToolStripMenuItem.Name = "GerarXMLToolStripMenuItem";
            this.GerarXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.GerarXMLToolStripMenuItem.Text = "&Gerar XML";
            this.GerarXMLToolStripMenuItem.Click += new System.EventHandler(this.GerarXMLToolStripMenuItem_Click);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutorToolStripMenuItem});
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.SobreToolStripMenuItem.Text = "&Sobre";
            // 
            // AutorToolStripMenuItem
            // 
            this.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem";
            this.AutorToolStripMenuItem.Size = new System.Drawing.Size(180, 40);
            this.AutorToolStripMenuItem.Text = "&Autor";
            this.AutorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco ABC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FicheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CriarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GerarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LevantarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem AutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

