namespace App_BancoABC
{
    partial class FormLevantaDeposita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevantaDeposita));
            this.gb_tipoMovimento = new System.Windows.Forms.GroupBox();
            this.rb_depositar = new System.Windows.Forms.RadioButton();
            this.rb_levantar = new System.Windows.Forms.RadioButton();
            this.gb_Levantar = new System.Windows.Forms.GroupBox();
            this.lbl_valLevantar = new System.Windows.Forms.Label();
            this.tb_ValorLevanta = new System.Windows.Forms.TextBox();
            this.tb_SaldoAtualLevanta = new System.Windows.Forms.TextBox();
            this.tb_TitularLevanta = new System.Windows.Forms.TextBox();
            this.cb_NumContaLevanta = new System.Windows.Forms.ComboBox();
            this.lbl_valDepositar = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_titular1 = new System.Windows.Forms.Label();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_tipoMovimento.SuspendLayout();
            this.gb_Levantar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_tipoMovimento
            // 
            this.gb_tipoMovimento.Controls.Add(this.rb_depositar);
            this.gb_tipoMovimento.Controls.Add(this.rb_levantar);
            this.gb_tipoMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_tipoMovimento.Location = new System.Drawing.Point(21, 34);
            this.gb_tipoMovimento.Name = "gb_tipoMovimento";
            this.gb_tipoMovimento.Size = new System.Drawing.Size(700, 100);
            this.gb_tipoMovimento.TabIndex = 0;
            this.gb_tipoMovimento.TabStop = false;
            this.gb_tipoMovimento.Text = "Tipo de Movimento";
            // 
            // rb_depositar
            // 
            this.rb_depositar.AutoSize = true;
            this.rb_depositar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_depositar.Location = new System.Drawing.Point(442, 49);
            this.rb_depositar.Name = "rb_depositar";
            this.rb_depositar.Size = new System.Drawing.Size(129, 29);
            this.rb_depositar.TabIndex = 0;
            this.rb_depositar.TabStop = true;
            this.rb_depositar.Text = "Depositar";
            this.rb_depositar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_depositar.UseVisualStyleBackColor = true;
            this.rb_depositar.CheckedChanged += new System.EventHandler(this.rb_depositar_CheckedChanged);
            // 
            // rb_levantar
            // 
            this.rb_levantar.AutoSize = true;
            this.rb_levantar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_levantar.Location = new System.Drawing.Point(261, 49);
            this.rb_levantar.Name = "rb_levantar";
            this.rb_levantar.Size = new System.Drawing.Size(121, 29);
            this.rb_levantar.TabIndex = 0;
            this.rb_levantar.TabStop = true;
            this.rb_levantar.Text = "Levantar";
            this.rb_levantar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_levantar.UseVisualStyleBackColor = true;
            // 
            // gb_Levantar
            // 
            this.gb_Levantar.Controls.Add(this.lbl_valLevantar);
            this.gb_Levantar.Controls.Add(this.tb_ValorLevanta);
            this.gb_Levantar.Controls.Add(this.tb_SaldoAtualLevanta);
            this.gb_Levantar.Controls.Add(this.tb_TitularLevanta);
            this.gb_Levantar.Controls.Add(this.cb_NumContaLevanta);
            this.gb_Levantar.Controls.Add(this.lbl_valDepositar);
            this.gb_Levantar.Controls.Add(this.lbl_saldo);
            this.gb_Levantar.Controls.Add(this.lbl_titular1);
            this.gb_Levantar.Controls.Add(this.lbl_titular);
            this.gb_Levantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Levantar.Location = new System.Drawing.Point(21, 174);
            this.gb_Levantar.Name = "gb_Levantar";
            this.gb_Levantar.Size = new System.Drawing.Size(700, 272);
            this.gb_Levantar.TabIndex = 1;
            this.gb_Levantar.TabStop = false;
            // 
            // lbl_valLevantar
            // 
            this.lbl_valLevantar.AutoSize = true;
            this.lbl_valLevantar.Location = new System.Drawing.Point(21, 216);
            this.lbl_valLevantar.Name = "lbl_valLevantar";
            this.lbl_valLevantar.Size = new System.Drawing.Size(0, 25);
            this.lbl_valLevantar.TabIndex = 3;
            // 
            // tb_ValorLevanta
            // 
            this.tb_ValorLevanta.Location = new System.Drawing.Point(232, 213);
            this.tb_ValorLevanta.Name = "tb_ValorLevanta";
            this.tb_ValorLevanta.Size = new System.Drawing.Size(150, 30);
            this.tb_ValorLevanta.TabIndex = 2;
            this.tb_ValorLevanta.Leave += new System.EventHandler(this.tb_ValorLevanta_Leave);
            // 
            // tb_SaldoAtualLevanta
            // 
            this.tb_SaldoAtualLevanta.Enabled = false;
            this.tb_SaldoAtualLevanta.Location = new System.Drawing.Point(196, 150);
            this.tb_SaldoAtualLevanta.Name = "tb_SaldoAtualLevanta";
            this.tb_SaldoAtualLevanta.Size = new System.Drawing.Size(150, 30);
            this.tb_SaldoAtualLevanta.TabIndex = 2;
            // 
            // tb_TitularLevanta
            // 
            this.tb_TitularLevanta.Enabled = false;
            this.tb_TitularLevanta.Location = new System.Drawing.Point(196, 97);
            this.tb_TitularLevanta.Name = "tb_TitularLevanta";
            this.tb_TitularLevanta.Size = new System.Drawing.Size(434, 30);
            this.tb_TitularLevanta.TabIndex = 2;
            // 
            // cb_NumContaLevanta
            // 
            this.cb_NumContaLevanta.FormattingEnabled = true;
            this.cb_NumContaLevanta.Location = new System.Drawing.Point(196, 43);
            this.cb_NumContaLevanta.Name = "cb_NumContaLevanta";
            this.cb_NumContaLevanta.Size = new System.Drawing.Size(224, 33);
            this.cb_NumContaLevanta.TabIndex = 1;
            this.cb_NumContaLevanta.SelectedIndexChanged += new System.EventHandler(this.cb_NumContaLevanta_SelectedIndexChanged);
            // 
            // lbl_valDepositar
            // 
            this.lbl_valDepositar.AutoSize = true;
            this.lbl_valDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valDepositar.Location = new System.Drawing.Point(16, 216);
            this.lbl_valDepositar.Name = "lbl_valDepositar";
            this.lbl_valDepositar.Size = new System.Drawing.Size(0, 25);
            this.lbl_valDepositar.TabIndex = 0;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(16, 150);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(119, 25);
            this.lbl_saldo.TabIndex = 0;
            this.lbl_saldo.Text = "Saldo Atual:";
            // 
            // lbl_titular1
            // 
            this.lbl_titular1.AutoSize = true;
            this.lbl_titular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titular1.Location = new System.Drawing.Point(16, 100);
            this.lbl_titular1.Name = "lbl_titular1";
            this.lbl_titular1.Size = new System.Drawing.Size(72, 25);
            this.lbl_titular1.TabIndex = 0;
            this.lbl_titular1.Text = "Titular:";
            // 
            // lbl_titular
            // 
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titular.Location = new System.Drawing.Point(16, 43);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(97, 25);
            this.lbl_titular.TabIndex = 0;
            this.lbl_titular.Text = "Nº Conta:";
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackgroundImage = global::App_BancoABC.Properties.Resources.Save_37110;
            this.btn_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_gravar.Location = new System.Drawing.Point(755, 207);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(99, 80);
            this.btn_gravar.TabIndex = 2;
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Visible = false;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::App_BancoABC.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(755, 338);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 80);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormLevantaDeposita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 519);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.gb_Levantar);
            this.Controls.Add(this.gb_tipoMovimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLevantaDeposita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levantamento e depósito";
            this.Load += new System.EventHandler(this.FormLevantaDeposita_Load);
            this.gb_tipoMovimento.ResumeLayout(false);
            this.gb_tipoMovimento.PerformLayout();
            this.gb_Levantar.ResumeLayout(false);
            this.gb_Levantar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_tipoMovimento;
        private System.Windows.Forms.GroupBox gb_Levantar;
        private System.Windows.Forms.TextBox tb_ValorLevanta;
        private System.Windows.Forms.TextBox tb_SaldoAtualLevanta;
        private System.Windows.Forms.TextBox tb_TitularLevanta;
        private System.Windows.Forms.ComboBox cb_NumContaLevanta;
        private System.Windows.Forms.Label lbl_valDepositar;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_titular1;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.RadioButton rb_depositar;
        private System.Windows.Forms.RadioButton rb_levantar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_valLevantar;
    }
}