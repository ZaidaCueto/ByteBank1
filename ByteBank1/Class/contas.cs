using System;


namespace ByteBank1
{
    public class Conta
    {

        private string Nome { get; set; }
        private double Credito { get; set; }
        private double Saldo { get; set; }
      

        public Conta(double saldo, string nome)
        {
            
            this.Saldo = saldo;
            this.Credito = saldo * 2;

            this.Nome = nome;
        }
        public bool Sacar(double valorSaque)
        {
            Conta conta = this;
            if (conta.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente");
                Console.WriteLine();
                Console.WriteLine("Seu saldo atual : R$ {0} . Crédito de R$ {1} . Valor disponível pra saque R$ {2} .", this.Saldo, this.Credito, (this.Saldo + this.Credito));
                Console.ResetColor();
                return false;
            }
            this.Saldo -= valorSaque;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Saque feito com sucesso!");
            Console.WriteLine("{0}, seu saldo atual é de R$ {1}", this.Nome, this.Saldo);

            Console.ResetColor();
            return true;
        }

   
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                Console.WriteLine("{0}, seu saldo atual é de R$ {1}", this.Nome, this.Saldo);
            }
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("{0}, seu saldo atual é de R$ {1}", this.Nome, this.Saldo);

        }




        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome : " + this.Nome + " | ";
            retorno += "Saldo : R$ " + this.Saldo + " | ";
            retorno += "Credito : R$ " + this.Credito + " | ";
            return retorno;
        }

        internal void SaldoTotalNoBanco()
        {
            Console.WriteLine("Seu saldo é");
            Console.WriteLine(this.Saldo);

        }

     
    }
}