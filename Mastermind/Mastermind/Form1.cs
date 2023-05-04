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
using System.Media;


namespace Mastermind
{
    public partial class Form1 : Form
    {
       
        int cor = 0;
        int linha = 1;
        int jogada = 0;
        
        public Form1()
        {
            
            InitializeComponent();
            btn_verificar.Hide();
            btn_1_f1.Enabled = false; btn_2_f1.Enabled = false;
            btn_3_f1.Enabled = false; btn_4_f1.Enabled = false;
            btn_1_f2.Enabled = false; btn_2_f2.Enabled = false;
            btn_3_f2.Enabled = false; btn_4_f2.Enabled = false;
            btn_1_f3.Enabled = false; btn_2_f3.Enabled = false;
            btn_3_f3.Enabled = false; btn_4_f3.Enabled = false;
            btn_1_f4.Enabled = false; btn_2_f4.Enabled = false;
            btn_3_f4.Enabled = false; btn_4_f4.Enabled = false;
            btn_1_f5.Enabled = false; btn_2_f5.Enabled = false;
            btn_3_f5.Enabled = false; btn_4_f5.Enabled = false;
            btn_1_f6.Enabled = false; btn_2_f6.Enabled = false;
            btn_3_f6.Enabled = false; btn_4_f6.Enabled = false;
            btn_1_f7.Enabled = false; btn_2_f7.Enabled = false;
            btn_3_f7.Enabled = false; btn_4_f7.Enabled = false;
            btn_1_f8.Enabled = false; btn_2_f8.Enabled = false;
            btn_3_f8.Enabled = false; btn_4_f8.Enabled = false;
            btn_1_f9.Enabled = false; btn_2_f9.Enabled = false;
            btn_3_f9.Enabled = false; btn_4_f9.Enabled = false;
            btn_1_f10.Enabled = false; btn_2_f10.Enabled = false;
            btn_3_f10.Enabled = false; btn_4_f10.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {

        }
        private void button44_Click(object sender, EventArgs e)
        {

        }
        private void btn_tab_1_Click(object sender, EventArgs e)
        {
            //ColorDialog cd = new ColorDialog();
            //if (cd.ShowDialog() == DialogResult.OK)
            //{
            //    btn_tab_1.ForeColor = cd.Color;
            //}

        }

        //-----------Fila1 a cor escolhida -------------
        private void btn_1_f1_Click(object sender, EventArgs e)
        {
            if (cor == 1)
            {
                btn_1_f1.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f1.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f1.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f1.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f1.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f1.BackColor = Color.Orange;
            }

        }
        private void btn_2_f1_Click(object sender, EventArgs e)
        {
            if (cor == 1)
            {
                btn_2_f1.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f1.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f1.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f1.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f1.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f1.BackColor = Color.Orange;
            }
        }
        private void btn_3_f1_Click(object sender, EventArgs e)
        {
            if (cor == 1)
            {
                btn_3_f1.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f1.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f1.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f1.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f1.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f1.BackColor = Color.Orange;
            }
        }
        private void btn_4_f1_Click(object sender, EventArgs e)
        {
            if (cor == 1)
            {
                btn_4_f1.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f1.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f1.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f1.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f1.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f1.BackColor = Color.Orange;
            }
        }//fim fila1
        

        //-----------botões CORES------------
        private void btn_blue_Click(object sender, EventArgs e)
        {
            cor = 1;
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            cor = 2;
        }

        private void btn_lime_Click(object sender, EventArgs e)
        {
            cor = 3;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            cor = 4;
        }

        private void btn_fuchsia_Click(object sender, EventArgs e)
        {
            cor = 5;
        }

        private void btn_orange_Click(object sender, EventArgs e)
        {
            cor = 6;
        }
        //fim botões cores

        private void Carrega_Cor_Fila(int btn, int fila)
        {
            //if (cor == 1)
            //{
            //   btn_(btn)_f(fila).BackColor = Color.Blue;
            //}
            //else if(cor ==2)
            if (cor == 2)
            {
                btn_1_f1.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f1.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f1.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f1.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f1.BackColor = Color.Orange;
            }
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            btn_verificar.Show();
            btn_1_f1.Enabled = true; btn_2_f1.Enabled = true; btn_3_f1.Enabled = true; btn_4_f1.Enabled = true;

            for (int i = 1; i < 5; i++)
            { 
                //Gerar aleatório
                Random aleatorio = new Random();
                int corAleatoria= aleatorio.Next(1, 7);
                int corAleatoria2 = aleatorio.Next(1, 7);
                int corAleatoria3 = aleatorio.Next(1, 7);
                int corAleatoria4 = aleatorio.Next(1, 7);

                //alterar cores e não serem todas iguais
                while (corAleatoria2==corAleatoria)
                    corAleatoria2=aleatorio.Next(1,7);
                while (corAleatoria3 == corAleatoria)
                    corAleatoria3 = aleatorio.Next(1, 7);
                while (corAleatoria4 == corAleatoria)
                    corAleatoria4 = aleatorio.Next(1, 7);
                                

                //Botão resultado 1 guarda cor no resultado e esconde
                if (corAleatoria == 1 && i==1)
                {
                    btn_result1.BackColor = Color.Blue;
                    btn_result1.Hide();
                }
                else if (corAleatoria == 2 && i == 1)
                {
                    btn_result1.BackColor = Color.Yellow;
                    btn_result1.Hide();
                }
                else if (corAleatoria == 3 && i == 1)
                {
                    btn_result1.BackColor = Color.Lime;
                    btn_result1.Hide();
                }
                else if (corAleatoria == 4 && i == 1)
                {
                    btn_result1.BackColor = Color.Red;
                    btn_result1.Hide();
                }
                else if (corAleatoria == 5 && i == 1)
                {
                    btn_result1.BackColor = Color.Fuchsia;
                    btn_result1.Hide();
                }
                else if (corAleatoria == 6 && i == 1)
                {
                    btn_result1.BackColor = Color.Orange;
                    btn_result1.Hide();
                }

                //Botão resultado 2
                else if (corAleatoria2 == 1 && i == 2)
                {
                    btn_result2.BackColor = Color.Blue;
                    btn_result2.Hide();
                }
                else if (corAleatoria2 == 2 && i == 2)
                {
                    btn_result2.BackColor = Color.Yellow;
                    btn_result2.Hide();
                }
                else if (corAleatoria2 == 3 && i == 2)
                {
                    btn_result2.BackColor = Color.Lime;
                    btn_result2.Hide();
                }
                else if (corAleatoria2 == 4 && i == 2)
                {
                    btn_result2.BackColor = Color.Red;
                    btn_result2.Hide();
                }
                else if (corAleatoria2 == 5 && i == 2)
                {
                    btn_result2.BackColor = Color.Fuchsia;
                    btn_result2.Hide();
                }
                else if (corAleatoria2 == 6 && i == 2)
                {
                    btn_result2.BackColor = Color.Orange;
                    btn_result2.Hide();
                }

                //Botão resultado 3
                else if (corAleatoria3 == 1 && i == 3)
                {
                    btn_result3.BackColor = Color.Blue;
                    btn_result3.Hide();
                }
                else if (corAleatoria3 == 2 && i == 3)
                {
                    btn_result3.BackColor = Color.Yellow;
                    btn_result3.Hide();
                }
                else if (corAleatoria3 == 3 && i == 3)
                {
                    btn_result3.BackColor = Color.Lime;
                    btn_result3.Hide();
                }
                else if (corAleatoria3 == 4 && i == 3)
                {
                    btn_result3.BackColor = Color.Red;
                    btn_result3.Hide();
                }
                else if (corAleatoria3 == 5 && i == 3)
                {
                    btn_result3.BackColor = Color.Fuchsia;
                    btn_result3.Hide();
                }
                else if (corAleatoria3 == 6 && i == 3)
                {
                    btn_result3.BackColor = Color.Orange;
                    btn_result3.Hide();
                }

                //Botão resultado 4
                else if (corAleatoria4 == 1 && i == 4)
                {
                    btn_result4.BackColor = Color.Blue;
                    btn_result4.Hide();
                }
                else if (corAleatoria4 == 2 && i == 4)
                {
                    btn_result4.BackColor = Color.Yellow;
                    btn_result4.Hide();
                }
                else if (corAleatoria4 == 3 && i == 4)
                {
                    btn_result4.BackColor = Color.Lime;
                    btn_result4.Hide();
                }
                else if (corAleatoria4 == 4 && i == 4)
                {
                    btn_result4.BackColor = Color.Red;
                    btn_result4.Hide();
                }
                else if (corAleatoria4 == 5 && i == 4)
                {
                    btn_result4.BackColor = Color.Fuchsia;
                    btn_result4.Hide();
                }
                else if (corAleatoria4 == 6 && i == 4)
                {
                    btn_result4.BackColor = Color.Orange;
                    btn_result4.Hide();
                }
                btn_jogar.Hide();
            }

         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //------------Botão VERIFICAR Fila1------------
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            //-----------Fila1------------
            jogada++;//conta as jogadas 
            playSimpleSound();//faz o som
            //o botão 1 da fila 1 é igual ao botão do resultado 1
            if (btn_1_f1.BackColor == btn_result1.BackColor)
            {
                btn_check1_f1.BackColor = Color.Black;
            }

            //botão 1 fila 1 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f1.BackColor == btn_result2.BackColor || btn_1_f1.BackColor == btn_result3.BackColor || btn_1_f1.BackColor == btn_result4.BackColor)
            {
                btn_check1_f1.BackColor = Color.White;
            }

            else
            {
                btn_check1_f1.BackColor = Color.Red;
            }

            //o botão 2 da fila 1 é igual ao botão do resultado 2
            if (btn_2_f1.BackColor == btn_result2.BackColor)
            {
                btn_check2_f1.BackColor = Color.Black;
            }
            //botão 2 fila 1 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f1.BackColor == btn_result1.BackColor || btn_2_f1.BackColor == btn_result3.BackColor || btn_2_f1.BackColor == btn_result4.BackColor)
            {
                btn_check2_f1.BackColor = Color.White;
            }
            
            else
            {
                btn_check2_f1.BackColor = Color.Red;
            }
            //o botão 3 da fila 1 é igual ao botão do resultado 3
            if (btn_3_f1.BackColor == btn_result3.BackColor)
            {
                btn_check3_f1.BackColor = Color.Black;
            }
            //botão 3 fila 1 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f1.BackColor == btn_result1.BackColor || btn_3_f1.BackColor == btn_result2.BackColor || btn_3_f1.BackColor == btn_result4.BackColor)
            {
                btn_check3_f1.BackColor = Color.White;
            }
            
            else
            {
                btn_check3_f1.BackColor = Color.Red;
            }

            //o botão 4 da fila 1 é igual ao botão do resultado 4
            if (btn_4_f1.BackColor == btn_result4.BackColor)
            {
                btn_check4_f1.BackColor = Color.Black;
            }
            //botão 4 fila 1 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f1.BackColor == btn_result1.BackColor || btn_4_f1.BackColor == btn_result2.BackColor || btn_4_f1.BackColor == btn_result3.BackColor)
            {
                btn_check4_f1.BackColor = Color.White;
            }
                 
            else
            {
                btn_check4_f1.BackColor = Color.Red;
            }

            if (btn_check1_f1.BackColor == Color.Black && btn_check2_f1.BackColor == Color.Black && btn_check3_f1.BackColor == Color.Black && btn_check4_f1.BackColor == Color.Black)
            {
                //quando acerta chama a função sair (quando ganha)
                sair();                
              
            }
            
                btn_verificar.Hide(); //esconde o botão
                btn_1_f2.Enabled = true;
                btn_2_f2.Enabled = true;
                btn_3_f2.Enabled = true;
                btn_4_f2.Enabled = true;
                btn_verificar2.Show(); //mostra o seguinte
            
        }

        //-----------Botão Regras------------
        private void btn_regras_Click(object sender, EventArgs e)
        {
            //Mostrar o formulário 2
            Form2_regras f2 = new Form2_regras();

            f2.Show();

        }

        //-----------Fila2------------
        private void btn_1_f2_Click(object sender, EventArgs e)
        {
            btn_1_f2.Enabled = false;

            if (cor == 1)
            {
                btn_1_f2.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f2.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f2.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f2.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f2.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f2.BackColor = Color.Orange;
            }
        }

        private void btn_2_f2_Click(object sender, EventArgs e)
        {
            btn_2_f2.Enabled = false;
            if (cor == 1)
            {
                btn_2_f2.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f2.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f2.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f2.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f2.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f2.BackColor = Color.Orange;
            }
        }

        private void btn_3_f2_Click(object sender, EventArgs e)
        {
            btn_3_f2.Enabled = false;
            if (cor == 1)
            {
                btn_3_f2.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f2.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f2.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f2.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f2.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f2.BackColor = Color.Orange;
            }
        }

        private void btn_4_f2_Click(object sender, EventArgs e)
        {
            btn_4_f2.Enabled = false;
            if (cor == 1)
            {
                btn_4_f2.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f2.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f2.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f2.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f2.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f2.BackColor = Color.Orange;
            }
        }

        

        private void btn_check1_f2_Click(object sender, EventArgs e)
        {

        }

        private void btn_check3_f2_Click(object sender, EventArgs e)
        {

        }

        private void btn_check4_f2_Click(object sender, EventArgs e)
        {

        }
        //-----------Botão VERIFICAR Fila2------------
        private void btn_verificar2_Click(object sender, EventArgs e)
        {
            //-----------Fila2------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 2 é igual ao botão do resultado 1
            if (btn_1_f2.BackColor == btn_result1.BackColor)
            {
                btn_check1_f2.BackColor = Color.Black;
            }
            //botão 1 fila 2 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f2.BackColor == btn_result2.BackColor || btn_1_f2.BackColor == btn_result3.BackColor || btn_1_f2.BackColor == btn_result4.BackColor)
            {
                btn_check1_f2.BackColor = Color.White;
            }
            
            else
            {
                btn_check1_f2.BackColor = Color.Red;
            }

            //o botão 2 da fila 2 é igual ao botão do resultado 2
            if (btn_2_f2.BackColor == btn_result2.BackColor)
            {
                btn_check2_f2.BackColor = Color.Black;
            }
            //botão 2 fila 2 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f2.BackColor == btn_result1.BackColor || btn_2_f2.BackColor == btn_result3.BackColor || btn_2_f2.BackColor == btn_result4.BackColor)
            {
                btn_check2_f2.BackColor = Color.White;
            }
            
            else
            {
                btn_check2_f2.BackColor = Color.Red;
            }

            //o botão 3 da fila 2 é igual ao botão do resultado 3
            if (btn_3_f2.BackColor == btn_result3.BackColor)
            {
                btn_check3_f2.BackColor = Color.Black;
            }
            //botão 3 fila 2 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f2.BackColor == btn_result1.BackColor || btn_3_f2.BackColor == btn_result2.BackColor || btn_3_f2.BackColor == btn_result4.BackColor)
            {
                btn_check3_f2.BackColor = Color.White;
            }
            
            else
            {
                btn_check3_f2.BackColor = Color.Red;
            }

            //o botão 4 da fila 2 é igual ao botão do resultado 4
            if (btn_4_f2.BackColor == btn_result4.BackColor)
            {
                btn_check4_f2.BackColor = Color.Black;
            }
            //botão 4 fila 2 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f2.BackColor == btn_result1.BackColor || btn_4_f2.BackColor == btn_result2.BackColor || btn_4_f2.BackColor == btn_result3.BackColor)
            {
                btn_check4_f2.BackColor = Color.White;
            }
            
            else
            {
                btn_check4_f2.BackColor = Color.Red;
            }

            if (btn_check1_f2.BackColor == Color.Black && btn_check2_f2.BackColor == Color.Black && btn_check3_f2.BackColor == Color.Black && btn_check4_f2.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar2.Hide();
            btn_1_f3.Enabled = true;
            btn_2_f3.Enabled = true;
            btn_3_f3.Enabled = true;
            btn_4_f3.Enabled = true;
            button1.Show();
        }
        //-----------Botão VERIFICAR Fila3------------
        private void button1_Click_1(object sender, EventArgs e)
        {
            //-----------Fila3------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 3 é igual ao botão do resultado 1
            if (btn_1_f3.BackColor == btn_result1.BackColor)
            {
                btn_check1_f3.BackColor = Color.Black;
            }
            //botão 1 fila 3 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f3.BackColor == btn_result2.BackColor || btn_1_f3.BackColor == btn_result3.BackColor || btn_1_f3.BackColor == btn_result4.BackColor)
            {
                btn_check1_f3.BackColor = Color.White;
            }

            else
            {
                btn_check1_f3.BackColor = Color.Red;
            }

            //o botão 2 da fila 3 é igual ao botão do resultado 2
            if (btn_2_f3.BackColor == btn_result2.BackColor)
            {
                btn_check2_f3.BackColor = Color.Black;
            }
            //botão 2 fila 3 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f3.BackColor == btn_result1.BackColor || btn_2_f3.BackColor == btn_result3.BackColor || btn_2_f3.BackColor == btn_result4.BackColor)
            {
                btn_check2_f3.BackColor = Color.White;
            }

            else
            {
                btn_check2_f3.BackColor = Color.Red;
            }

            //o botão 3 da fila 3 é igual ao botão do resultado 3
            if (btn_3_f3.BackColor == btn_result3.BackColor)
            {
                btn_check3_f3.BackColor = Color.Black;
            }
            //botão 3 fila 3 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f3.BackColor == btn_result1.BackColor || btn_3_f3.BackColor == btn_result2.BackColor || btn_3_f3.BackColor == btn_result4.BackColor)
            {
                btn_check3_f3.BackColor = Color.White;
            }

            else
            {
                btn_check3_f3.BackColor = Color.Red;
            }

            //o botão 4 da fila 3 é igual ao botão do resultado 4
            if (btn_4_f3.BackColor == btn_result4.BackColor)
            {
                btn_check4_f3.BackColor = Color.Black;
            }
            //botão 4 fila 3 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f3.BackColor == btn_result1.BackColor || btn_4_f3.BackColor == btn_result2.BackColor || btn_4_f3.BackColor == btn_result3.BackColor)
            {
                btn_check4_f3.BackColor = Color.White;
            }

            else
            {
                btn_check4_f3.BackColor = Color.Red;
            }

            if (btn_check1_f3.BackColor == Color.Black && btn_check2_f3.BackColor == Color.Black && btn_check3_f3.BackColor == Color.Black && btn_check4_f3.BackColor == Color.Black)
            {
                sair();
            }
            button1.Hide();
            btn_1_f4.Enabled = true;
            btn_2_f4.Enabled = true;
            btn_3_f4.Enabled = true;
            btn_4_f4.Enabled = true;
            btn_verificar4.Show();

        }
        //-----------Botão VERIFICAR Fila4------------
        private void btn_verificar4_Click(object sender, EventArgs e)
        {
            //-----------Fila4------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 4 é igual ao botão do resultado 1
            if (btn_1_f4.BackColor == btn_result1.BackColor)
            {
                btn_check1_f4.BackColor = Color.Black;
            }
            //botão 1 fila 4 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f4.BackColor == btn_result2.BackColor || btn_1_f4.BackColor == btn_result3.BackColor || btn_1_f4.BackColor == btn_result4.BackColor)
            {
                btn_check1_f4.BackColor = Color.White;
            }

            else
            {
                btn_check1_f4.BackColor = Color.Red;
            }

            //o botão 2 da fila 4 é igual ao botão do resultado 2
            if (btn_2_f4.BackColor == btn_result2.BackColor)
            {
                btn_check2_f4.BackColor = Color.Black;
            }
            //botão 2 fila 4 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f4.BackColor == btn_result1.BackColor || btn_2_f4.BackColor == btn_result3.BackColor || btn_2_f4.BackColor == btn_result4.BackColor)
            {
                btn_check2_f4.BackColor = Color.White;
            }

            else
            {
                btn_check2_f4.BackColor = Color.Red;
            }

            //o botão 3 da fila 4 é igual ao botão do resultado 3
            if (btn_3_f4.BackColor == btn_result3.BackColor)
            {
                btn_check3_f4.BackColor = Color.Black;
            }
            //botão 3 fila 4 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f4.BackColor == btn_result1.BackColor || btn_3_f4.BackColor == btn_result2.BackColor || btn_3_f4.BackColor == btn_result4.BackColor)
            {
                btn_check3_f4.BackColor = Color.White;
            }

            else
            {
                btn_check3_f4.BackColor = Color.Red;
            }

            //o botão 4 da fila 4 é igual ao botão do resultado 4
            if (btn_4_f4.BackColor == btn_result4.BackColor)
            {
                btn_check4_f4.BackColor = Color.Black;
            }
            //botão 4 fila 4 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f4.BackColor == btn_result1.BackColor || btn_4_f4.BackColor == btn_result2.BackColor || btn_4_f4.BackColor == btn_result3.BackColor)
            {
                btn_check4_f4.BackColor = Color.White;
            }

            else
            {
                btn_check4_f4.BackColor = Color.Red;
            }

            if (btn_check1_f4.BackColor == Color.Black && btn_check2_f4.BackColor == Color.Black && btn_check3_f4.BackColor == Color.Black && btn_check4_f4.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar4.Hide();
            btn_1_f5.Enabled = true;
            btn_2_f5.Enabled = true;
            btn_3_f5.Enabled = true;
            btn_4_f5.Enabled = true;
            btn_verificar5.Show();
        }
        //-----------Botão VERIFICAR Fila5------------
        private void btn_verificar5_Click(object sender, EventArgs e)
        {
            //-----------Fila5------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 5 é igual ao botão do resultado 1
            if (btn_1_f5.BackColor == btn_result1.BackColor)
            {
                btn_check1_f5.BackColor = Color.Black;
            }
            //botão 1 fila 5 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f5.BackColor == btn_result2.BackColor || btn_1_f5.BackColor == btn_result3.BackColor || btn_1_f5.BackColor == btn_result4.BackColor)
            {
                btn_check1_f5.BackColor = Color.White;
            }

            else
            {
                btn_check1_f5.BackColor = Color.Red;
            }

            //o botão 2 da fila 5 é igual ao botão do resultado 2
            if (btn_2_f5.BackColor == btn_result2.BackColor)
            {
                btn_check2_f5.BackColor = Color.Black;
            }
            //botão 2 fila 5 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f5.BackColor == btn_result1.BackColor || btn_2_f5.BackColor == btn_result3.BackColor || btn_2_f5.BackColor == btn_result4.BackColor)
            {
                btn_check2_f5.BackColor = Color.White;
            }

            else
            {
                btn_check2_f5.BackColor = Color.Red;
            }

            //o botão 3 da fila 5 é igual ao botão do resultado 3
            if (btn_3_f5.BackColor == btn_result3.BackColor)
            {
                btn_check3_f5.BackColor = Color.Black;
            }
            //botão 3 fila 5 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f5.BackColor == btn_result1.BackColor || btn_3_f5.BackColor == btn_result2.BackColor || btn_3_f5.BackColor == btn_result4.BackColor)
            {
                btn_check3_f5.BackColor = Color.White;
            }

            else
            {
                btn_check3_f5.BackColor = Color.Red;
            }

            //o botão 4 da fila 5 é igual ao botão do resultado 4
            if (btn_4_f5.BackColor == btn_result4.BackColor)
            {
                btn_check4_f5.BackColor = Color.Black;
            }
            //botão 4 fila 5 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f5.BackColor == btn_result1.BackColor || btn_4_f5.BackColor == btn_result2.BackColor || btn_4_f5.BackColor == btn_result3.BackColor)
            {
                btn_check4_f5.BackColor = Color.White;
            }

            else
            {
                btn_check4_f5.BackColor = Color.Red;
            }

            if (btn_check1_f5.BackColor == Color.Black && btn_check2_f5.BackColor == Color.Black && btn_check3_f5.BackColor == Color.Black && btn_check4_f5.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar5.Hide();
            btn_1_f6.Enabled = true;
            btn_2_f6.Enabled = true;
            btn_3_f6.Enabled = true;
            btn_4_f6.Enabled = true;
            btn_verificar6.Show();
        }
        //-----------Botão VERIFICAR Fila6------------
        private void btn_verificar6_Click(object sender, EventArgs e)
        {
            //-----------Fila6------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 6 é igual ao botão do resultado 1
            if (btn_1_f6.BackColor == btn_result1.BackColor)
            {
                btn_check1_f6.BackColor = Color.Black;
            }
            //botão 1 fila 6 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f6.BackColor == btn_result2.BackColor || btn_1_f6.BackColor == btn_result3.BackColor || btn_1_f6.BackColor == btn_result4.BackColor)
            {
                btn_check1_f6.BackColor = Color.White;
            }

            else
            {
                btn_check1_f6.BackColor = Color.Red;
            }

            //o botão 2 da fila 6 é igual ao botão do resultado 2
            if (btn_2_f6.BackColor == btn_result2.BackColor)
            {
                btn_check2_f6.BackColor = Color.Black;
            }
            //botão 2 fila 6 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f6.BackColor == btn_result1.BackColor || btn_2_f6.BackColor == btn_result3.BackColor || btn_2_f6.BackColor == btn_result4.BackColor)
            {
                btn_check2_f6.BackColor = Color.White;
            }

            else
            {
                btn_check2_f6.BackColor = Color.Red;
            }

            //o botão 3 da fila 6 é igual ao botão do resultado 3
            if (btn_3_f6.BackColor == btn_result3.BackColor)
            {
                btn_check3_f6.BackColor = Color.Black;
            }
            //botão 3 fila 6 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f6.BackColor == btn_result1.BackColor || btn_3_f6.BackColor == btn_result2.BackColor || btn_3_f6.BackColor == btn_result4.BackColor)
            {
                btn_check3_f6.BackColor = Color.White;
            }

            else
            {
                btn_check3_f6.BackColor = Color.Red;
            }

            //o botão 4 da fila 6 é igual ao botão do resultado 4
            if (btn_4_f6.BackColor == btn_result4.BackColor)
            {
                btn_check4_f6.BackColor = Color.Black;
            }
            //botão 4 fila 6 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f6.BackColor == btn_result1.BackColor || btn_4_f6.BackColor == btn_result2.BackColor || btn_4_f6.BackColor == btn_result3.BackColor)
            {
                btn_check4_f6.BackColor = Color.White;
            }

            else
            {
                btn_check4_f6.BackColor = Color.Red;
            }

            if (btn_check1_f6.BackColor == Color.Black && btn_check2_f6.BackColor == Color.Black && btn_check3_f6.BackColor == Color.Black && btn_check4_f6.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar6.Hide();
            btn_1_f7.Enabled = true;
            btn_2_f7.Enabled = true;
            btn_3_f7.Enabled = true;
            btn_4_f7.Enabled = true;
            btn_verificar7.Show();
        }
        //-----------Botão VERIFICAR Fila7------------
        private void btn_verificar7_Click(object sender, EventArgs e)
        {
            //-----------Fila7------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 7 é igual ao botão do resultado 1
            if (btn_1_f7.BackColor == btn_result1.BackColor)
            {
                btn_check1_f7.BackColor = Color.Black;
            }
            //botão 1 fila 7 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f7.BackColor == btn_result2.BackColor || btn_1_f7.BackColor == btn_result3.BackColor || btn_1_f7.BackColor == btn_result4.BackColor)
            {
                btn_check1_f7.BackColor = Color.White;
            }

            else
            {
                btn_check1_f7.BackColor = Color.Red;
            }

            //o botão 2 da fila 7 é igual ao botão do resultado 2
            if (btn_2_f7.BackColor == btn_result2.BackColor)
            {
                btn_check2_f7.BackColor = Color.Black;
            }
            //botão 2 fila 7 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f7.BackColor == btn_result1.BackColor || btn_2_f7.BackColor == btn_result3.BackColor || btn_2_f7.BackColor == btn_result4.BackColor)
            {
                btn_check2_f7.BackColor = Color.White;
            }

            else
            {
                btn_check2_f7.BackColor = Color.Red;
            }

            //o botão 3 da fila 7 é igual ao botão do resultado 3
            if (btn_3_f7.BackColor == btn_result3.BackColor)
            {
                btn_check3_f7.BackColor = Color.Black;
            }
            //botão 3 fila 7 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f7.BackColor == btn_result1.BackColor || btn_3_f7.BackColor == btn_result2.BackColor || btn_3_f7.BackColor == btn_result4.BackColor)
            {
                btn_check3_f7.BackColor = Color.White;
            }

            else
            {
                btn_check3_f7.BackColor = Color.Red;
            }

            //o botão 4 da fila 7 é igual ao botão do resultado 4
            if (btn_4_f7.BackColor == btn_result4.BackColor)
            {
                btn_check4_f7.BackColor = Color.Black;
            }
            //botão 4 fila 7 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f7.BackColor == btn_result1.BackColor || btn_4_f7.BackColor == btn_result2.BackColor || btn_4_f7.BackColor == btn_result3.BackColor)
            {
                btn_check4_f7.BackColor = Color.White;
            }

            else
            {
                btn_check4_f7.BackColor = Color.Red;
            }

            if (btn_check1_f7.BackColor == Color.Black && btn_check2_f7.BackColor == Color.Black && btn_check3_f7.BackColor == Color.Black && btn_check4_f7.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar7.Hide();
            btn_1_f8.Enabled = true;
            btn_2_f8.Enabled = true;
            btn_3_f8.Enabled = true;
            btn_4_f8.Enabled = true;
            btn_verificar8.Show();
        }
        //-----------Botão VERIFICAR Fila8------------
        private void btn_verificar8_Click(object sender, EventArgs e)
        {
            //-----------Fila8------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 8 é igual ao botão do resultado 1
            if (btn_1_f8.BackColor == btn_result1.BackColor)
            {
                btn_check1_f8.BackColor = Color.Black;
            }
            //botão 1 fila 8 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f8.BackColor == btn_result2.BackColor || btn_1_f8.BackColor == btn_result3.BackColor || btn_1_f8.BackColor == btn_result4.BackColor)
            {
                btn_check1_f8.BackColor = Color.White;
            }

            else
            {
                btn_check1_f8.BackColor = Color.Red;
            }

            //o botão 2 da fila 8 é igual ao botão do resultado 2
            if (btn_2_f8.BackColor == btn_result2.BackColor)
            {
                btn_check2_f8.BackColor = Color.Black;
            }
            //botão 2 fila 8 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f8.BackColor == btn_result1.BackColor || btn_2_f8.BackColor == btn_result3.BackColor || btn_2_f8.BackColor == btn_result4.BackColor)
            {
                btn_check2_f8.BackColor = Color.White;
            }

            else
            {
                btn_check2_f8.BackColor = Color.Red;
            }

            //o botão 3 da fila 8 é igual ao botão do resultado 3
            if (btn_3_f8.BackColor == btn_result3.BackColor)
            {
                btn_check3_f8.BackColor = Color.Black;
            }
            //botão 3 fila 8 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f8.BackColor == btn_result1.BackColor || btn_3_f8.BackColor == btn_result2.BackColor || btn_3_f8.BackColor == btn_result4.BackColor)
            {
                btn_check3_f8.BackColor = Color.White;
            }

            else
            {
                btn_check3_f8.BackColor = Color.Red;
            }

            //o botão 4 da fila 8 é igual ao botão do resultado 4
            if (btn_4_f8.BackColor == btn_result4.BackColor)
            {
                btn_check4_f8.BackColor = Color.Black;
            }
            //botão 4 fila 8 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f8.BackColor == btn_result1.BackColor || btn_4_f8.BackColor == btn_result2.BackColor || btn_4_f8.BackColor == btn_result3.BackColor)
            {
                btn_check4_f8.BackColor = Color.White;
            }

            else
            {
                btn_check4_f8.BackColor = Color.Red;
            }

            if (btn_check1_f8.BackColor == Color.Black && btn_check2_f8.BackColor == Color.Black && btn_check3_f8.BackColor == Color.Black && btn_check4_f8.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar8.Hide();
            btn_1_f9.Enabled = true;
            btn_2_f9.Enabled = true;
            btn_3_f9.Enabled = true;
            btn_4_f9.Enabled = true;
            btn_verificar9.Show();
        }
        //-----------Botão VERIFICAR Fila9------------
        private void btn_verificar9_Click(object sender, EventArgs e)
        {
            //-----------Fila9------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 9 é igual ao botão do resultado 1
            if (btn_1_f9.BackColor == btn_result1.BackColor)
            {
                btn_check1_f9.BackColor = Color.Black;
            }
            //botão 1 fila 9 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f9.BackColor == btn_result2.BackColor || btn_1_f9.BackColor == btn_result3.BackColor || btn_1_f9.BackColor == btn_result4.BackColor)
            {
                btn_check1_f9.BackColor = Color.White;
            }

            else
            {
                btn_check1_f9.BackColor = Color.Red;
            }

            //o botão 2 da fila 9 é igual ao botão do resultado 2
            if (btn_2_f9.BackColor == btn_result2.BackColor)
            {
                btn_check2_f9.BackColor = Color.Black;
            }
            //botão 2 fila 9 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f9.BackColor == btn_result1.BackColor || btn_2_f9.BackColor == btn_result3.BackColor || btn_2_f9.BackColor == btn_result4.BackColor)
            {
                btn_check2_f9.BackColor = Color.White;
            }

            else
            {
                btn_check2_f9.BackColor = Color.Red;
            }

            //o botão 3 da fila 9 é igual ao botão do resultado 3
            if (btn_3_f9.BackColor == btn_result3.BackColor)
            {
                btn_check3_f9.BackColor = Color.Black;
            }
            //botão 3 fila 9 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f9.BackColor == btn_result1.BackColor || btn_3_f9.BackColor == btn_result2.BackColor || btn_3_f9.BackColor == btn_result4.BackColor)
            {
                btn_check3_f9.BackColor = Color.White;
            }

            else
            {
                btn_check3_f9.BackColor = Color.Red;
            }

            //o botão 4 da fila 9 é igual ao botão do resultado 4
            if (btn_4_f9.BackColor == btn_result4.BackColor)
            {
                btn_check4_f9.BackColor = Color.Black;
            }
            //botão 4 fila 9 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f9.BackColor == btn_result1.BackColor || btn_4_f9.BackColor == btn_result2.BackColor || btn_4_f9.BackColor == btn_result3.BackColor)
            {
                btn_check4_f9.BackColor = Color.White;
            }

            else
            {
                btn_check4_f9.BackColor = Color.Red;
            }

            if (btn_check1_f9.BackColor == Color.Black && btn_check2_f9.BackColor == Color.Black && btn_check3_f9.BackColor == Color.Black && btn_check4_f9.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar9.Hide();
            btn_1_f10.Enabled = true;
            btn_2_f10.Enabled = true;
            btn_3_f10.Enabled = true;
            btn_4_f10.Enabled = true;
            btn_verificar10.Show();
        }
        //-----------Botão VERIFICAR Fila10------------
        private void btn_verificar10_Click(object sender, EventArgs e)
        {
            //-----------Fila10------------
            jogada++;
            playSimpleSound();
            //o botão 1 da fila 10 é igual ao botão do resultado 1
            if (btn_1_f10.BackColor == btn_result1.BackColor)
            {
                btn_check1_f10.BackColor = Color.Black;
            }
            //botão 1 fila 10 igual botão resultado 2, resultado 3 ou resultado 4
            else if (btn_1_f10.BackColor == btn_result2.BackColor || btn_1_f10.BackColor == btn_result3.BackColor || btn_1_f10.BackColor == btn_result4.BackColor)
            {
                btn_check1_f10.BackColor = Color.White;
            }

            else
            {
                btn_check1_f10.BackColor = Color.Red;
            }

            //o botão 2 da fila 10 é igual ao botão do resultado 2
            if (btn_2_f10.BackColor == btn_result2.BackColor)
            {
                btn_check2_f10.BackColor = Color.Black;
            }
            //botão 2 fila 10 igual botão resultado 1, resultado 3 ou resultado 4
            else if (btn_2_f10.BackColor == btn_result1.BackColor || btn_2_f10.BackColor == btn_result3.BackColor || btn_2_f10.BackColor == btn_result4.BackColor)
            {
                btn_check2_f10.BackColor = Color.White;
            }

            else
            {
                btn_check2_f10.BackColor = Color.Red;
            }

            //o botão 3 da fila 10 é igual ao botão do resultado 3
            if (btn_3_f10.BackColor == btn_result3.BackColor)
            {
                btn_check3_f10.BackColor = Color.Black;
            }
            //botão 3 fila 10 igual botão resultado 1, resultado 2 ou resultado 4
            else if (btn_3_f10.BackColor == btn_result1.BackColor || btn_3_f10.BackColor == btn_result2.BackColor || btn_3_f10.BackColor == btn_result4.BackColor)
            {
                btn_check3_f10.BackColor = Color.White;
            }

            else
            {
                btn_check3_f10.BackColor = Color.Red;
            }

            //o botão 4 da fila 10 é igual ao botão do resultado 4
            if (btn_4_f10.BackColor == btn_result4.BackColor)
            {
                btn_check4_f10.BackColor = Color.Black;
            }
            //botão 4 fila 10 igual botão resultado 1, resultado 2 ou resultado 3
            else if (btn_4_f10.BackColor == btn_result1.BackColor || btn_4_f10.BackColor == btn_result2.BackColor || btn_4_f10.BackColor == btn_result3.BackColor)
            {
                btn_check4_f10.BackColor = Color.White;
            }

            else
            {
                btn_check4_f10.BackColor = Color.Red;
            }

            if (btn_check1_f10.BackColor == Color.Black && btn_check2_f10.BackColor == Color.Black && btn_check3_f10.BackColor == Color.Black && btn_check4_f10.BackColor == Color.Black)
            {
                sair();
            }
            btn_verificar10.Hide();

            btn_result1.Show();
            btn_result2.Show();
            btn_result3.Show();
            btn_result4.Show();

            System.Media.SoundPlayer ver = new System.Media.SoundPlayer(@"c:\Windows\Media\critical.wav");
            ver.Play();

            int resposta = Convert.ToInt32(MessageBox.Show("Deu o seu melhor, mas não conseguiu decifrar o código!\n \n Pretende jogar novamente?", "Ooooops!", MessageBoxButtons.YesNo));

            if (resposta == 7)
            {
                Application.Exit();
            }
            else
            {
                Application.Restart();
                Environment.Exit(0);
            }

            MessageBox.Show(resposta.ToString());

        }
        //-----------FILA3------------
        private void btn_1_f3_Click(object sender, EventArgs e)
        {
            //btn_1_f3.Enabled = false;
            if (cor == 1)
            {
                btn_1_f3.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f3.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f3.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f3.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f3.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f3.BackColor = Color.Orange;
            }
        }
       
        private void btn_2_f3_Click(object sender, EventArgs e)
        {
            btn_2_f3.Enabled = false;
            if (cor == 1)
            {
                btn_2_f3.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f3.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f3.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f3.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f3.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f3.BackColor = Color.Orange;
            }
        }

        private void btn_3_f3_Click(object sender, EventArgs e)
        {
            btn_3_f3.Enabled = false;
            if (cor == 1)
            {
                btn_3_f3.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f3.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f3.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f3.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f3.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f3.BackColor = Color.Orange;
            }
        }

        private void btn_4_f3_Click(object sender, EventArgs e)
        {
            btn_4_f3.Enabled = false;
            if (cor == 1)
            {
                btn_4_f3.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f3.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f3.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f3.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f3.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f3.BackColor = Color.Orange;
            }
            
        //fim FILA3
        }
        //-----------FILA4------------
        private void btn_1_f4_Click(object sender, EventArgs e)
        {
            btn_1_f4.Enabled = false;
            if (cor == 1)
            {
                btn_1_f4.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f4.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f4.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f4.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f4.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f4.BackColor = Color.Orange;
            }
        }
       
        private void btn_2_f4_Click(object sender, EventArgs e)
        {
            btn_2_f4.Enabled = false;
            if (cor == 1)
            {
                btn_2_f4.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f4.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f4.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f4.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f4.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f4.BackColor = Color.Orange;
            }
        }

        private void btn_3_f4_Click(object sender, EventArgs e)
        {
            btn_3_f4.Enabled = false;
            if (cor == 1)
            {
                btn_3_f4.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f4.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f4.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f4.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f4.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f4.BackColor = Color.Orange;
            }
        }

        private void btn_4_f4_Click(object sender, EventArgs e)
        {
            btn_4_f4.Enabled = false;
            if (cor == 1)
            {
                btn_4_f4.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f4.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f4.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f4.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f4.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f4.BackColor = Color.Orange;
            }
            //fim fila4
        }

        //----------Fila5--------------
        private void btn_1_f5_Click(object sender, EventArgs e)
        {
            btn_1_f5.Enabled = false;
            if (cor == 1)
            {
                btn_1_f5.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f5.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f5.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f5.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f5.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f5.BackColor = Color.Orange;
            }
        }

        private void btn_2_f5_Click(object sender, EventArgs e)
        {
            btn_2_f5.Enabled = false;
            if (cor == 1)
            {
                btn_2_f5.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f5.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f5.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f5.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f5.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f5.BackColor = Color.Orange;
            }
        }

        private void btn_3_f5_Click(object sender, EventArgs e)
        {
            btn_3_f5.Enabled = false;
            if (cor == 1)
            {
                btn_3_f5.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f5.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f5.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f5.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f5.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f5.BackColor = Color.Orange;
            }
        }

        private void btn_4_f5_Click(object sender, EventArgs e)
        {
            btn_4_f5.Enabled = false;
            if (cor == 1)
            {
                btn_4_f5.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f5.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f5.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f5.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f5.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f5.BackColor = Color.Orange;
            }
            //fim fila5

        }
        //-----------Fila6-------------
        private void btn_1_f6_Click(object sender, EventArgs e)
        {
            btn_1_f6.Enabled = false;
            if (cor == 1)
            {
                btn_1_f6.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f6.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f6.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f6.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f6.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f6.BackColor = Color.Orange;
            }
        }

        private void btn_2_f6_Click(object sender, EventArgs e)
        {
            btn_2_f6.Enabled = false;
            if (cor == 1)
            {
                btn_2_f6.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f6.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f6.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f6.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f6.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f6.BackColor = Color.Orange;
            }
        }

        private void btn_3_f6_Click(object sender, EventArgs e)
        {
            btn_3_f6.Enabled = false;
            if (cor == 1)
            {
                btn_3_f6.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f6.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f6.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f6.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f6.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f6.BackColor = Color.Orange;
            }
        }

        private void btn_4_f6_Click(object sender, EventArgs e)
        {
            btn_4_f6.Enabled = false;
            if (cor == 1)
            {
                btn_4_f6.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f6.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f6.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f6.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f6.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f6.BackColor = Color.Orange;
            }
            //fim fila6
        }
        //----------Fila7------------------
        private void btn_1_f7_Click(object sender, EventArgs e)
        {
            btn_1_f7.Enabled = false;
            if (cor == 1)
            {
                btn_1_f7.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f7.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f7.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f7.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f7.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f7.BackColor = Color.Orange;
            }
        }

        private void btn_2_f7_Click(object sender, EventArgs e)
        {
            btn_2_f7.Enabled = false;
            if (cor == 1)
            {
                btn_2_f7.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f7.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f7.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f7.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f7.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f7.BackColor = Color.Orange;
            }
        }

        private void btn_3_f7_Click(object sender, EventArgs e)
        {
            btn_3_f7.Enabled = false;
            if (cor == 1)
            {
                btn_3_f7.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f7.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f7.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f7.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f7.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f7.BackColor = Color.Orange;
            }
        }

        private void btn_4_f7_Click(object sender, EventArgs e)
        {
            btn_4_f7.Enabled = false;
            if (cor == 1)
            {
                btn_4_f7.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f7.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f7.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f7.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f7.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f7.BackColor = Color.Orange;
            }
            //fim fila7
        }
        //-----------Fila8--------------
        private void btn_1_f8_Click(object sender, EventArgs e)
        {
            btn_1_f8.Enabled = false;
            if (cor == 1)
            {
                btn_1_f8.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f8.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f8.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f8.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f8.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f8.BackColor = Color.Orange;
            }
        }

        private void btn_2_f8_Click(object sender, EventArgs e)
        {
            btn_2_f8.Enabled = false;
            if (cor == 1)
            {
                btn_2_f8.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f8.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f8.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f8.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f8.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f8.BackColor = Color.Orange;
            }
        }

        private void btn_3_f8_Click(object sender, EventArgs e)
        {
            btn_3_f8.Enabled = false;
            if (cor == 1)
            {
                btn_3_f8.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f8.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f8.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f8.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f8.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f8.BackColor = Color.Orange;
            }
        }

        private void btn_4_f8_Click(object sender, EventArgs e)
        {
            btn_4_f8.Enabled = false;
            if (cor == 1)
            {
                btn_4_f8.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f8.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f8.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f8.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f8.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f8.BackColor = Color.Orange;
            }
            //fim fila8
        }
        //------Fila 9--------------
        private void btn_1_f9_Click(object sender, EventArgs e)
        {
            btn_1_f9.Enabled = false;
            if (cor == 1)
            {
                btn_1_f9.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f9.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f9.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f9.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f9.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f9.BackColor = Color.Orange;
            }
        }

        private void btn_2_f9_Click(object sender, EventArgs e)
        {
            btn_2_f9.Enabled = false;
            if (cor == 1)
            {
                btn_2_f9.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f9.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f9.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f9.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f9.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f9.BackColor = Color.Orange;
            }
        }

        private void btn_3_f9_Click(object sender, EventArgs e)
        {
            btn_3_f9.Enabled = false;
            if (cor == 1)
            {
                btn_3_f9.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f9.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f9.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f9.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f9.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f9.BackColor = Color.Orange;
            }
        }

        private void btn_4_f9_Click(object sender, EventArgs e)
        {
            btn_4_f9.Enabled = false;
            if (cor == 1)
            {
                btn_4_f9.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f9.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f9.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f9.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f9.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f9.BackColor = Color.Orange;
            }
            //fim fila9
        }
        //---------Fila10--------------
        private void btn_1_f10_Click(object sender, EventArgs e)
        {
            btn_1_f10.Enabled = false;

            if (cor == 1)
            {
                btn_1_f10.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_1_f10.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_1_f10.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_1_f10.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_1_f10.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_1_f10.BackColor = Color.Orange;
            }
        }

        private void btn_2_f10_Click(object sender, EventArgs e)
        {
            btn_2_f10.Enabled = false;
            if (cor == 1)
            {
                btn_2_f10.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_2_f10.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_2_f10.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_2_f10.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_2_f10.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_2_f10.BackColor = Color.Orange;
            }
        }

        private void btn_3_f10_Click(object sender, EventArgs e)
        {
            btn_3_f10.Enabled = false;
            if (cor == 1)
            {
                btn_3_f10.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_3_f10.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_3_f10.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_3_f10.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_3_f10.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_3_f10.BackColor = Color.Orange;
            }
        }

        private void btn_4_f10_Click(object sender, EventArgs e)
        {
            btn_4_f10.Enabled = false;
            if (cor == 1)
            {
                btn_4_f10.BackColor = Color.Blue;
            }
            else if (cor == 2)
            {
                btn_4_f10.BackColor = Color.Yellow;
            }
            else if (cor == 3)
            {
                btn_4_f10.BackColor = Color.Lime;
            }
            else if (cor == 4)
            {
                btn_4_f10.BackColor = Color.Red;
            }
            else if (cor == 5)
            {
                btn_4_f10.BackColor = Color.Fuchsia;
            }
            else if (cor == 6)
            {
                btn_4_f10.BackColor = Color.Orange;
            }
            //fim fila10
        }

        private void sair()
        {
            btn_result1.Show();
            btn_result2.Show();
            btn_result3.Show();
            btn_result4.Show();

            System.Media.SoundPlayer ver = new System.Media.SoundPlayer(@"c:\Windows\Media\tada.wav");
            ver.Play();

            int resposta = Convert.ToInt32(MessageBox.Show($"Parabéns Ganhou!\n Precisou de {jogada} jogadas! Pretende jogar novamente?", "", MessageBoxButtons.YesNo));

            if (resposta == 7)
            {
                Application.Exit();
            }
            else
            {
                Application.Restart();
                Environment.Exit(0);
            }

            MessageBox.Show(resposta.ToString());
            
        }

        private void playSimpleSound()
        {
            System.Media.SoundPlayer ver = new System.Media.SoundPlayer(@"c:\Windows\Media\chimes.wav");
            ver.Play();
        }


    }

}
