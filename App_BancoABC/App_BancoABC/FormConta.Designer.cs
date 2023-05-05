namespace App_BancoABC
{
    partial class FormConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConta));
            this.gb_NovaConta = new System.Windows.Forms.GroupBox();
            this.lbl_NumConta = new System.Windows.Forms.Label();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.tb_TitularNConta = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.lbl_nConta = new System.Windows.Forms.Label();
            this.gb_Desativar = new System.Windows.Forms.GroupBox();
            this.chk_Desativo = new System.Windows.Forms.CheckBox();
            this.tb_SaldoD = new System.Windows.Forms.TextBox();
            this.cb_NumContaD = new System.Windows.Forms.ComboBox();
            this.tb_TitularD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_NovaConta.SuspendLayout();
            this.gb_Desativar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_NovaConta
            // 
            this.gb_NovaConta.Controls.Add(this.lbl_NumConta);
            this.gb_NovaConta.Controls.Add(this.tb_saldo);
            this.gb_NovaConta.Controls.Add(this.tb_TitularNConta);
            this.gb_NovaConta.Controls.Add(this.lbl_saldo);
            this.gb_NovaConta.Controls.Add(this.lbl_titular);
            this.gb_NovaConta.Controls.Add(this.lbl_nConta);
            this.gb_NovaConta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_NovaConta.Location = new System.Drawing.Point(33, 44);
            this.gb_NovaConta.Name = "gb_NovaConta";
            this.gb_NovaConta.Size = new System.Drawing.Size(593, 259);
            this.gb_NovaConta.TabIndex = 0;
            this.gb_NovaConta.TabStop = false;
            // 
            // lbl_NumConta
            // 
            this.lbl_NumConta.AutoSize = true;
            this.lbl_NumConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_NumConta.Location = new System.Drawing.Point(172, 49);
            this.lbl_NumConta.Name = "lbl_NumConta";
            this.lbl_NumConta.Size = new System.Drawing.Size(26, 25);
            this.lbl_NumConta.TabIndex = 3;
            this.lbl_NumConta.Text = "1";
            // 
            // tb_saldo
            // 
            this.tb_saldo.Location = new System.Drawing.Point(173, 163);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.Size = new System.Drawing.Size(100, 32);
            this.tb_saldo.TabIndex = 1;
            this.tb_saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_saldo_KeyPress);
            this.tb_saldo.Leave += new System.EventHandler(this.tb_saldo_Leave);
            // 
            // tb_TitularNConta
            // 
            this.tb_TitularNConta.Location = new System.Drawing.Point(173, 110);
            this.tb_TitularNConta.Name = "tb_TitularNConta";
            this.tb_TitularNConta.Size = new System.Drawing.Size(405, 32);
            this.tb_TitularNConta.TabIndex = 1;
            this.tb_TitularNConta.Leave += new System.EventHandler(this.tb_TitularNConta_Leave);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(22, 165);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(77, 25);
            this.lbl_saldo.TabIndex = 0;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // lbl_titular
            // 
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titular.Location = new System.Drawing.Point(22, 110);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(87, 25);
            this.lbl_titular.TabIndex = 0;
            this.lbl_titular.Text = "Titular:";
            // 
            // lbl_nConta
            // 
            this.lbl_nConta.AutoSize = true;
            this.lbl_nConta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nConta.Location = new System.Drawing.Point(22, 49);
            this.lbl_nConta.Name = "lbl_nConta";
            this.lbl_nConta.Size = new System.Drawing.Size(144, 25);
            this.lbl_nConta.TabIndex = 0;
            this.lbl_nConta.Text = "Nº de Conta:";
            // 
            // gb_Desativar
            // 
            this.gb_Desativar.Controls.Add(this.chk_Desativo);
            this.gb_Desativar.Controls.Add(this.tb_SaldoD);
            this.gb_Desativar.Controls.Add(this.cb_NumContaD);
            this.gb_Desativar.Controls.Add(this.tb_TitularD);
            this.gb_Desativar.Controls.Add(this.label1);
            this.gb_Desativar.Controls.Add(this.label2);
            this.gb_Desativar.Controls.Add(this.label4);
            this.gb_Desativar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Desativar.Location = new System.Drawing.Point(16, 55);
            this.gb_Desativar.Name = "gb_Desativar";
            this.gb_Desativar.Size = new System.Drawing.Size(610, 288);
            this.gb_Desativar.TabIndex = 4;
            this.gb_Desativar.TabStop = false;
            this.gb_Desativar.Visible = false;
            // 
            // chk_Desativo
            // 
            this.chk_Desativo.AutoSize = true;
            this.chk_Desativo.Location = new System.Drawing.Point(442, 168);
            this.chk_Desativo.Name = "chk_Desativo";
            this.chk_Desativo.Size = new System.Drawing.Size(136, 29);
            this.chk_Desativo.TabIndex = 7;
            this.chk_Desativo.Text = "Desativo";
            this.chk_Desativo.UseVisualStyleBackColor = true;
            // 
            // tb_SaldoD
            // 
            this.tb_SaldoD.Enabled = false;
            this.tb_SaldoD.Location = new System.Drawing.Point(173, 165);
            this.tb_SaldoD.Name = "tb_SaldoD";
            this.tb_SaldoD.Size = new System.Drawing.Size(100, 32);
            this.tb_SaldoD.TabIndex = 5;
            // 
            // cb_NumContaD
            // 
            this.cb_NumContaD.FormattingEnabled = true;
            this.cb_NumContaD.Location = new System.Drawing.Point(173, 49);
            this.cb_NumContaD.Name = "cb_NumContaD";
            this.cb_NumContaD.Size = new System.Drawing.Size(121, 33);
            this.cb_NumContaD.TabIndex = 4;
            this.cb_NumContaD.SelectedIndexChanged += new System.EventHandler(this.cb_NumContaD_SelectedIndexChanged);
            // 
            // tb_TitularD
            // 
            this.tb_TitularD.Enabled = false;
            this.tb_TitularD.Location = new System.Drawing.Point(173, 110);
            this.tb_TitularD.Name = "tb_TitularD";
            this.tb_TitularD.Size = new System.Drawing.Size(405, 32);
            this.tb_TitularD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº de Conta:";
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackgroundImage = global::App_BancoABC.Properties.Resources.Save_37110;
            this.btn_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_gravar.Location = new System.Drawing.Point(676, 86);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(99, 80);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::App_BancoABC.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(676, 206);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 80);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gb_Desativar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.gb_NovaConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancária";
            this.Load += new System.EventHandler(this.FormConta_Load);
            this.gb_NovaConta.ResumeLayout(false);
            this.gb_NovaConta.PerformLayout();
            this.gb_Desativar.ResumeLayout(false);
            this.gb_Desativar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_NovaConta;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.Label lbl_nConta;
        private System.Windows.Forms.TextBox tb_TitularNConta;
        private System.Windows.Forms.TextBox tb_saldo;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.GroupBox gb_Desativar;
        private System.Windows.Forms.TextBox tb_TitularD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_NumContaD;
        private System.Windows.Forms.Label lbl_NumConta;
        private System.Windows.Forms.TextBox tb_SaldoD;
        private System.Windows.Forms.CheckBox chk_Desativo;
        private System.Windows.Forms.Button btn_cancelar;
    }
}