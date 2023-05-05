using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_BancoABC
{
    public partial class FormLevantaDeposita : Form
    {
        //variáveis
        //nº de contas bancárias
        private int XLenght = 0;
        //a conta a que estou a aceder (o seu índice)
        private int XPosicao = 0;

        public FormLevantaDeposita()
        {          
            InitializeComponent();
        }

        private void FormLevantaDeposita_Load(object sender, EventArgs e)
        {
            //verifica o tamanho do ArrayContas -- nº de contas bancárias
            XLenght = App_BancoABC.Program.ArrayContas.Length;
            if(XLenght>0) //vai carregar o nº de conta na combobox
            {
                gb_Levantar.Visible = true;
                cb_NumContaLevanta.Items.Clear();
                for(int i=0; i<XLenght; i++)
                {
                    if (App_BancoABC.Program.ArrayContas[i].getDesativa() == false)
                    {
                        cb_NumContaLevanta.Items.Add(App_BancoABC.Program.ArrayContas[i].getNum_Conta());
                    }
                }                
            }
            else
            {
                MessageBox.Show("Não existe nenhuma conta registada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (App_BancoABC.Program.Menu==2) //Faz o levantamento (opção 2 do Menu)
            {
                gb_Levantar.Text = "Levantamento";
                rb_levantar.Checked = true;
                rb_depositar.Checked = false;
                lbl_valLevantar.Text = "Valor a Levantar:";
            }
            else //deposita
            {
                rb_depositar.Checked= true;
                rb_depositar.Checked=false;
                gb_Levantar.Text = "Depósito";
                lbl_valDepositar.Text = "Valor a depositar:";
            }

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            double XSAtual = Convert.ToDouble(tb_SaldoAtualLevanta.Text);
            double XValor = Convert.ToDouble(tb_ValorLevanta.Text);
            string XMensagem = "";

            if (rb_levantar.Checked ==true) //levantamento
            {
                if(XValor>XSAtual)
                {
                    MessageBox.Show("Não tem saldo para levantar o montante!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    App_BancoABC.Program.ArrayContas[XPosicao].Levantar(XValor);
                    XMensagem = "O levantamento de " + Convert.ToString(XValor) + "€ foi executado com sucesso! ";
                }                
            }
            else //Depósito
            {
                App_BancoABC.Program.ArrayContas[XPosicao].Depositar(XValor);
                XMensagem = "O depósito de " + Convert.ToString(XValor) + "€ foi executado com sucesso! ";
            }

            MessageBox.Show(XMensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            String resposta;
            resposta = Convert.ToString(MessageBox.Show("Quer mesmo sair da Aplicação? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == "Yes")
                Application.Exit();
        }

        private void cb_NumContaLevanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (i=0; i<XLenght; i++) 
            {
                if (App_BancoABC.Program.ArrayContas[i].getNum_Conta() ==Convert.ToInt16(cb_NumContaLevanta.Text))
                {
                    XPosicao = i;
                    tb_SaldoAtualLevanta.Text = Convert.ToString(App_BancoABC.Program.ArrayContas[XPosicao].getSaldo());
                    tb_TitularLevanta.Text = App_BancoABC.Program.ArrayContas[XPosicao].getTitular();
                    btn_gravar.Visible = true;
                    break;
                }
            }
        }

        private void tb_ValorLevanta_Leave(object sender, EventArgs e)
        {
            if (tb_ValorLevanta.Text == "")
            {
                MessageBox.Show("Deve digitar o valor da operação!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_ValorLevanta.Focus();
            }
            else if (Convert.ToDouble(tb_ValorLevanta.Text) < 0)
            {
                MessageBox.Show("Valor inválido!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ValorLevanta.Focus();
            }
            else
            {
                btn_gravar.Visible = true;
                btn_cancelar.Visible = true;
            }
        }

        private void rb_depositar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
