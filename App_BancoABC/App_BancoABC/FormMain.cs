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
using System.Xml;

namespace App_BancoABC
{
    public partial class Form_Main : Form
    {
        //variáveis 
        private int XLength = 0; //para indicar o tamanho do array

        public Form_Main()
        {
            InitializeComponent();
        }
        

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Criar uma nova conta ";
            //Variável global, identificamos o nome do projeto. nome do programa. variável global
            App_BancoABC.Program.Menu = 0; //Nova conta
            FormConta conta = new FormConta();
            conta.ShowDialog();
            toolStripStatusLabel1.Text = "";
        }

        private void EncerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Encerrar conta ";
            //Variável global, identificamos o nome do projeto. nome do programa. variável global
            App_BancoABC.Program.Menu = 1; //desativar conta
            FormConta conta = new FormConta();
            conta.ShowDialog();
            toolStripStatusLabel1.Text = "";
        }

        private void levantarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Levantar ";
            App_BancoABC.Program.Menu = 2; //Levantar dinheiro
            FormLevantaDeposita levantadeposita = new FormLevantaDeposita();
            levantadeposita.ShowDialog();
            toolStripStatusLabel1.Text = "";
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Depositar ";
            App_BancoABC.Program.Menu = 3; //Depositar dinheiro
            FormLevantaDeposita levantadeposita = new FormLevantaDeposita();
            levantadeposita.ShowDialog();
            toolStripStatusLabel1.Text = "";
        }

        
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Autor da aplicação ";
            FormAutor autor = new FormAutor();
            autor.ShowDialog();
            toolStripStatusLabel1.Text = "";
        }

        private void CriarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App_BancoABC.Program.Menu = 6;
            toolStripStatusLabel1.Text = "Criar Ficheiro ";
            OpenFileDialog openDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\joana\Desktop\App_BancoABC_02_03_2023",
                CheckFileExists = true,
                CheckPathExists = false,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true

            };

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                App_BancoABC.Program.XPath = openDialog.FileName;

                StreamWriter XFile;
                if (File.Exists(App_BancoABC.Program.XPath))
                {
                    MessageBox.Show("O ficheiro: " + App_BancoABC.Program.XPath + " já existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XFile = File.CreateText(App_BancoABC.Program.XPath);
                    MessageBox.Show("Foi criado o ficheiro: " + App_BancoABC.Program.XPath + " já existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    XFile.Close();
                }
                toolStripStatusLabel1.Text = "";
            }

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String resposta;
            resposta = Convert.ToString(MessageBox.Show("Quer mesmo sair da Aplicação? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == "Yes")
                Application.Exit();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            toolStripStatusLabel1.Text = "Guardar Ficheiro de texto";

            if(File.Exists(App_BancoABC.Program.XPath)==false)
            {
                MessageBox.Show("O ficheiro: " + App_BancoABC.Program.XPath + "não existe!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            XLength = App_BancoABC.Program.ArrayContas.Length;
            if(XLength ==0)
            {
                MessageBox.Show("Não existem registos para gravar no ficheiro!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            App_BancoABC.Program.Menu = 5; //Guardar ficheiro
            //declarar variável tipo StreamWriter para abrir criar ficheiro
            StreamWriter XFile;
            //método append apra abrir e escrever no ficheiro
            //XFile =File.AppendText(App_BancoABC.Program.XPath);
            //método para criar arquivo de texto
            XFile = File.CreateText(App_BancoABC.Program.XPath);
            //Tamanho do array
            for (i=0;  i<XLength; i++) 
            {
                XFile.Write(App_BancoABC.Program.ArrayContas[i].getNum_Conta() + ";");
                XFile.Write(App_BancoABC.Program.ArrayContas[i].getTitular() + ";");
                XFile.Write(App_BancoABC.Program.ArrayContas[i].getSaldo() + ";");
                XFile.WriteLine(App_BancoABC.Program.ArrayContas[i].getDesativa() + ";" );
            }
            MessageBox.Show("Foram gravadas " + Convert.ToString(i) + "contas no ficheiro .txt", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //fechar o ficheiro
            XFile.Close();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            toolStripStatusLabel1.Text = "Abrir Ficheiro .txt ";
            if (File.Exists(App_BancoABC.Program.XPath) == false)
            {
                MessageBox.Show("O ficheiro: " + App_BancoABC.Program.XPath + " não existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            XLength = App_BancoABC.Program.ArrayContas.Length;
            if (XLength == 0)
            {
                MessageBox.Show("Não existem registos para gravar o ficheiro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            App_BancoABC.Program.Menu = 5;
            StreamWriter XFile;
            XFile = File.CreateText(App_BancoABC.Program.XPath);
            for (i = 0; i < XLength; i++)
            {
                XFile.Write(App_BancoABC.Program.ArrayContas[i].getNum_Conta() + ";");
                XFile.Write(App_BancoABC.Program.ArrayContas[i].getTitular() + ";");
                XFile.Write(App_BancoABC.Program.ArrayContas[i].getSaldo() + ";");
                XFile.WriteLine(App_BancoABC.Program.ArrayContas[i].getDesativa() + ";");
            }
            MessageBox.Show("Foram gravadas " + Convert.ToString(i) + " contas no ficheiro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            XFile.Close();
        }

        private void GerarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            toolStripStatusLabel1.Text = "Gerar ficheiro XML";

            string XPathXML = "C:\\Users\\joana\\Desktop\\App_BancoABC_02_03_2023\\Contas.xml";
            //Verificar se o array tem dados
            if (XLength > 0)
            {
                // Cria um novo arquivo XML
                XmlWriterSettings Xsettings = new XmlWriterSettings();
                Xsettings.Indent = true; // formata o XML com indentação
                Xsettings.Encoding = Encoding.UTF8;
                Xsettings.NewLineOnAttributes = true;//escreve os atributos na linha
                using (XmlWriter writer = XmlWriter.Create(XPathXML, Xsettings)) 
                {
                    // Escreve o cabeçalho do documento
                    writer.WriteStartElement("Contas");
                    for (i = 0; i < XLength; i++)
                    {
                        // Escreve o elemento raiz
                        writer.WriteStartElement("Conta");
                        // Escreve os elementos filho
                        writer.WriteElementString("NumConta", Convert.ToString(App_BancoABC.Program.ArrayContas[i].getNum_Conta()));
                        writer.WriteElementString("Titular", Convert.ToString(App_BancoABC.Program.ArrayContas[i].getTitular()));
                        writer.WriteElementString("Saldo", Convert.ToString(App_BancoABC.Program.ArrayContas[i].getSaldo()));
                        writer.WriteElementString("Desativo", Convert.ToString(App_BancoABC.Program.ArrayContas[i].getDesativa()));
                        writer.WriteEndElement();
                    }
                    // Fecha o elemento raiz
                    writer.WriteEndElement();
                    // Fecha o documento
                    writer.WriteEndDocument();
                    writer.Close();
                }
                MessageBox.Show("Foram gravadas" + Convert.ToString(i) + "contas no ficheiro XML", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Não existem dados para gerar o ficheiro XML", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);          

        }
    }
}
