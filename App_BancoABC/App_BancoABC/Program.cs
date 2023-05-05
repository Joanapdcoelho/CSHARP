using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_BancoABC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //As variáveis criadas aqui são variáveis globais. Ficam disponíveis para visualização em todos os forms (ocupam mais espaço em memória)
        // Variável pública Menu   0-> Nova Conta;  1- Desativar Conta  2 - Levantamento   3- Depósito
        public static int Menu = 0;

        //Array de contas
        public static Conta[] ArrayContas = new Conta[0];

        //variável pública para o caminho do ficheiro
        public static string XPath = "C:\\Users\\joana\\Desktop\\App_BancoABC_02_03_2023";


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
    }
}
