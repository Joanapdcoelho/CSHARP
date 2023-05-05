using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App_BancoABC
{
    public partial class FormConta : Form
    {
        //variáveis 
        private int XLenght = 0; //para indicar o tamanho do array
        private int XPosicao = 0; //se o array estiver preenchido, qual a posição selecionada

        public FormConta()
        {
            InitializeComponent();
        }

        private void FormConta_Load(object sender, EventArgs e)
        {
            //Verificar o tamanho do array
            XLenght = App_BancoABC.Program.ArrayContas.Length;
            if (App_BancoABC.Program.Menu == 0) //0-> Nova Conta
            {
                //para criar a nova conta
                gb_NovaConta.Visible = true;//colocar visível o group box         
                gb_Desativar.Visible = false; //group box desativar fica invisível
                gb_NovaConta.Text = "Criar nova Conta "; //texto que aparece na group box
                lbl_NumConta.Text = Convert.ToString(XLenght + 1);//incrementa o número da conta
                //tb_TitularNConta.Focus();
            }

            else
            {
                //voltar a ativar conta que estava desativa ou desativar conta
                gb_NovaConta.Visible = true;
                gb_Desativar.Visible = true;
                gb_Desativar.Text = "Desativar ou ativar Conta";                
                //cb_NumContaD.Focus();
                
                if (XLenght > 0) //se o tamanho do array é maior do que 0
                {
                    cb_NumContaD.Items.Clear(); 
                    for (int i = 0; i < XLenght; i++)

                        cb_NumContaD.Items.Add(App_BancoABC.Program.ArrayContas[i].getNum_Conta()); //vai buscar número de conta
                }
                else
                {
                    //verifica se existe conta e se não existe mostra mensagem
                    MessageBox.Show("Não existe nenhuma conta registada!! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //string resposta;
            if(App_BancoABC.Program.Menu ==0) //inserir
            {
                //Incrementar uma posição no array
                Array.Resize(ref App_BancoABC.Program.ArrayContas, XLenght+1);

                App_BancoABC.Program.ArrayContas[XLenght] = new Conta();
                App_BancoABC.Program.ArrayContas[XLenght].setNum_Conta(Convert.ToInt16(lbl_NumConta.Text));
                App_BancoABC.Program.ArrayContas[XLenght].setTitular(tb_TitularNConta.Text);
                App_BancoABC.Program.ArrayContas[XLenght].setSaldo(Convert.ToDouble(tb_saldo.Text));
                App_BancoABC.Program.ArrayContas[XLenght].setDesativa(false);

                //Mensagem ao utilizador
                MessageBox.Show("Conta criada para o cliente " + tb_TitularNConta.Text, "Informação",MessageBoxButtons.OK, MessageBoxIcon.Information);

                XLenght =XLenght+1; //incrementa 
            }
            else //atualiza ativa ou desativa
            {
                App_BancoABC.Program.ArrayContas[XPosicao].setDesativa(chk_Desativo.Checked);
                this.Close();
            }
            this.Close();
        }

        //private void btn_sair_Click(object sender, EventArgs e)
        //{
        //    String resposta;
        //    resposta = Convert.ToString(MessageBox.Show("Quer mesmo sair da Aplicação? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        //    if (resposta == "Yes")
        //        Application.Exit();

        //}

        private void tb_saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_saldo_Leave(object sender, EventArgs e)
        {
            //if (tb_saldo.Text == "")
            //{
            //    MessageBox.Show("Deve digitar um valor positivo para o Saldo!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tb_saldo.Focus();
            //}
            //else if (Convert.ToInt32(tb_saldo.Text) <= 0)
            //{
            //    MessageBox.Show("O Saldo deve ser superior a Zero!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tb_saldo.Focus();
            //}
            //else
            //{
            //    btn_gravar.Visible = true;
            //}
        }

        private void tb_TitularNConta_Leave(object sender, EventArgs e)
        {
            //if (tb_TitularNConta.Text.Length < 6)
            //{
            //    MessageBox.Show("O nome do titular deve ter no mínimo 6 caracteres!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    tb_TitularNConta.Focus();
            //}
        }

        //Groupbox conta desativar
        private void cb_NumContaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < XLenght; i++)
            {
                if (App_BancoABC.Program.ArrayContas[i].getNum_Conta() == Convert.ToInt16(cb_NumContaD.Text))
                {
                    XPosicao = i;
                    tb_SaldoD.Text = Convert.ToString(App_BancoABC.Program.ArrayContas[XPosicao].getSaldo());
                    tb_TitularD.Text = App_BancoABC.Program.ArrayContas[XPosicao].getTitular();
                    chk_Desativo.Checked = App_BancoABC.Program.ArrayContas[XPosicao].getDesativa();
                    chk_Desativo.Enabled = true;//Mostra checkbox desativo
                    btn_gravar.Visible=true;
                    btn_cancelar.Visible=true;
                    break;
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
