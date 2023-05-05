using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_BancoABC
{
    // Definição da classe
    class Conta //classe Conta
    {
        //Nas classes não se coloca mensagens
        //atributos 
        private int Num_Conta = 0;
        private string Titular = "";
        private double Saldo = 0;
        private Boolean Desativa =false;       
       
        
        //método get
        public string getTitular()
        { return Titular; }
        //método set
        public void setTitular(string XTitular)
        { this.Titular = XTitular; }
        //método get
        public int getNum_Conta() 
        { return Num_Conta; }
        //método set
        public void setNum_Conta(int XNum_Conta)
        { this.Num_Conta = XNum_Conta; }
        //método get
        public double getSaldo() 
        { return Saldo; }
        //método set
        public void setSaldo(double XSaldo)
        { this.Saldo = XSaldo; }

        //método get
        public Boolean getDesativa() { return Desativa; }

        //método set
        public void setDesativa(Boolean Desativa) { this.Desativa = Desativa;}


        //Método para levantar dinheiro
        public void Levantar(double valor)
        {
            if (this.Saldo>=valor)
                this.Saldo = this.Saldo - valor;
        }

        //Método para depositar dinheiro
        public void Depositar(double valor)
        {
            this.Saldo+= valor;
        }


    }
}
