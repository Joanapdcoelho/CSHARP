namespace Mastermind
{
    partial class Form2_regras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_regras));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_texto_regras = new System.Windows.Forms.Label();
            this.lbl_atencao = new System.Windows.Forms.Label();
            this.lbl_textoatencao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGRAS DO JOGO MASTERMIND";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.LightCyan;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(189, 887);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(102, 38);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_texto_regras
            // 
            this.lbl_texto_regras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto_regras.Location = new System.Drawing.Point(30, 70);
            this.lbl_texto_regras.Name = "lbl_texto_regras";
            this.lbl_texto_regras.Size = new System.Drawing.Size(465, 407);
            this.lbl_texto_regras.TabIndex = 3;
            this.lbl_texto_regras.Text = resources.GetString("lbl_texto_regras.Text");
            // 
            // lbl_atencao
            // 
            this.lbl_atencao.AutoSize = true;
            this.lbl_atencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atencao.ForeColor = System.Drawing.Color.Red;
            this.lbl_atencao.Location = new System.Drawing.Point(37, 795);
            this.lbl_atencao.Name = "lbl_atencao";
            this.lbl_atencao.Size = new System.Drawing.Size(131, 25);
            this.lbl_atencao.TabIndex = 4;
            this.lbl_atencao.Text = "ATENÇÃO: ";
            // 
            // lbl_textoatencao
            // 
            this.lbl_textoatencao.AutoSize = true;
            this.lbl_textoatencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textoatencao.Location = new System.Drawing.Point(39, 825);
            this.lbl_textoatencao.Name = "lbl_textoatencao";
            this.lbl_textoatencao.Size = new System.Drawing.Size(252, 25);
            this.lbl_textoatencao.TabIndex = 5;
            this.lbl_textoatencao.Text = "As cores podem-se repetir! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 275);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form2_regras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(507, 992);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_textoatencao);
            this.Controls.Add(this.lbl_atencao);
            this.Controls.Add(this.lbl_texto_regras);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2_regras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regras do jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_texto_regras;
        private System.Windows.Forms.Label lbl_atencao;
        private System.Windows.Forms.Label lbl_textoatencao;
        private System.Windows.Forms.Label label2;
    }
}