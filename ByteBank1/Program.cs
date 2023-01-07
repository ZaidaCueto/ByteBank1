
using System;
using System.Collections.Generic;

namespace ByteBank1;
class Program
{
    static List<Conta> listaContas = new List<Conta>();

    private static void SubMenu()
    {
        
        Console.WriteLine("1 - Depositaer");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Tranferir");
        Console.WriteLine("4 - Votar ao menu Inicial");
        Console.Write("Digite a opção desejada: ");

    }

    private static void SaldoTotalNoBanco()
    {
        Console.Write("Digite o número da conta : ");
        int indiceConta = int.Parse(Console.ReadLine());

        listaContas[indiceConta].SaldoTotalNoBanco();
    }

    private static void Transferir()
    {
        Console.Write("Digite o número da conta de origem : ");
        int contaOrigem = int.Parse(Console.ReadLine());

        Console.Write("Digite o número da conta Destino : ");
        int contaDestino = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser transferido : R$ ");
        double valorTransferencia = double.Parse(Console.ReadLine());

        listaContas[contaOrigem].Transferir(valorTransferencia, listaContas[contaDestino]);
    }

    private static void Depositar()
    {
        Console.Write("Digite o número da conta : ");
        int indiceConta = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor que você deseja depositar : R$ ");
        double indiceDeposito = double.Parse(Console.ReadLine());

        listaContas[indiceConta].Depositar(indiceDeposito);
    }

    private static void Sacar()
    {
        Console.WriteLine("Sacar valor da conta");
        Console.WriteLine();
        Console.Write("Digite o número da conta : ");
        int indiceConta = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Digite o valor do saque : R$ ");
        double saque = double.Parse(Console.ReadLine());

        Console.Clear();

        listaContas[indiceConta].Sacar(saque);

    }

    private static void ListarContas()
    {
        if (listaContas.Count == 0)
        {

            Console.WriteLine("Nenhuma conta registrada");
            return;
        }

        for (int i = 0; i < listaContas.Count; i++)
        {
            Conta conta = listaContas[i];
            Console.Write("Numero da conta {0} - ", i);
            Console.Write(conta);
            Console.WriteLine();
        }
    }

    private static void showSubMenu()
    {



        int optionSubmenu;
        SubMenu();

        optionSubmenu = int.Parse(Console.ReadLine());


        while (optionSubmenu > 5)

            SubMenu();
        switch (optionSubmenu)
        {
            case 1:
               
                Depositar();
                break;
            case 2:
                Console.Clear();
                Sacar();
                break;
            case 3:
                Console.Clear();
                Transferir();
                break;
            case 4:
                Console.Clear();
                SubMenu();

                break;
            default:
                throw new ArgumentOutOfRangeException();

        }
       

    }



    private static void RegistrarNovoUsuario()
    {
        Console.WriteLine("Inserir Nova conta");
        Console.WriteLine();

        Console.Write("Digite o nome do Cliente : ");
        string entradaNome = Console.ReadLine();

        Console.Write("Deposito Inicial : R$ ");
        double entradaSaldo = Convert.ToDouble(Console.ReadLine());

        if (entradaSaldo < 0)
        {

            throw new ArgumentOutOfRangeException("Seu saldo inicial não pode ser negativo ");

        }

        Conta novaConta = new Conta( saldo: entradaSaldo, nome: entradaNome);

        listaContas.Add(novaConta);

        Console.Clear();
        Console.WriteLine("Conta criada com sucesso");
        Console.WriteLine();
        Console.WriteLine(novaConta.ToString());

    }
    private static void deletarUmUsuario()
    {
        throw new NotImplementedException();
    }

    private static int obterOpcao()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine();
        Console.WriteLine("0 - Parar para sair do programa");
        Console.WriteLine("1 - Inserir novo usuário");
        Console.WriteLine("2 - Deletar um usuário");
        Console.WriteLine("3 - Listar todas as contas registrados ");
        Console.WriteLine("4 - Detalhes de um usuário");
        Console.WriteLine("5 - Total armazenado no banco");
        Console.WriteLine("6 - Manipular conta"); // depositaer, sacar, tranferir, sair
      

        Console.WriteLine();
        Console.ResetColor();
        Console.Write("Digite a opicão desejada:  ");


        Console.ResetColor();

        int opcaoUsuario = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return opcaoUsuario;
    }
    static void Main(string[] args)
    {
        Console.ForegroundColor= ConsoleColor.DarkCyan;
        Console.WriteLine("#########################################################################################################");
        Console.WriteLine("####################################  Bem-vindos ao  ByteBank1   ########################################");
        Console.WriteLine("#########################################################################################################");
      
        int opcaoUsuario = obterOpcao();

        while (opcaoUsuario != 0)
        {


            switch (opcaoUsuario)
            {

                case 0:
                    Console.Clear();
                    Console.WriteLine("Estou Encerrando o Program....");

                    break;
                case 1:
                    Console.Clear();
                    RegistrarNovoUsuario();
                    break;

                case 2:
                    Console.Clear();
                    deletarUmUsuario();
                    break;

                case 3:
                    Console.Clear();
                    ListarContas();
                    break;

                case 4:

                    break;


                case 5:
                    Console.Clear();
                    SaldoTotalNoBanco();
                    break;
                case 6:
                    showSubMenu();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = obterOpcao();
        }

        Console.WriteLine("Obrigado por utilizar nossos serviços.");
        Console.ReadLine();

    }


}





















/*using System.Drawing;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace ByteBank1
{
    public class Program
    {


        static List<Conta> listaContas = new List<Conta>();


        //  static List<Conta> listaContas = new();
        //*  Console.WriteLine("1 - Depositar");
        //  Console.WriteLine("2 - Sacar");
        //      Console.WriteLine("3 - Transferir");

        static void SubMenu()
        {
            int optionSubmenu = 0;
            Console.WriteLine("1 - Depositaer");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Tranferir");
            Console.WriteLine("4 - Votar ao menu Inicial");
            Console.Write("Digite a opção desejada: ");

        }

        static void ShowMenu()
        {

            Console.WriteLine();
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registrados ");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Total armazenado no banco");
            Console.WriteLine("6 - Manipular conta"); // depositaer, sacar, tranferir, sair
            Console.WriteLine("0 - Parar para sair do programa");
            Console.Write("Digite a opicão desejada:  ");

        }

    


        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {

            Console.Write($"\ndigite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Insira a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);


        }




        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine();
            Console.WriteLine("lista de todas as contas");
            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentaConta(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine($"CPF = {cpfs[index]} │  Titular = {titulares[index]} │ saldo = R${saldos[index]:f2}");
        }

        private static void deletarUmUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {

            Console.Write("digite um cpf: ");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(d => d == cpfParaDeletar);


            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Não foi possível deletar esta conta");
                Console.WriteLine("MOTIVO: conta não encontrada.");
            }

            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("conta deletada conm sucesso!");

        }

        *//*       private static void ListarContas()
               {
                   if (listaContas.Count == 0)
                   {

                       Console.WriteLine("Nenhuma conta registrada");
                       return;
                   }

                   for (int i = 0; i < listaContas.Count; i++)
                   {
                       Conta conta = listaContas[i];
                       Console.Write("#{0} - ", i);
                       Console.Write(conta);
                       Console.WriteLine();
                   }
               }*//*


        private static void Transferir(List<string> titulares, List<double> saldos)
        {
            Console.Write("Digite o número da conta de origem : ");
            int contaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta Destino : ");
            int contaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido : R$ ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            ApresentaConta(indiceConta,  titulares, saldos);
            listaContas[indiceConta].Sacar(saque);
        }



        static void Sacar(List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("Sacar valor da conta");
            Console.WriteLine();
            Console.Write("Digite o número da conta : ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o valor do saque : R$ ");
            double saque = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("tesr");
            ApresentaConta(indiceConta, titulares, saldos);
            listaContas[indiceConta].Sacar(saque);

        }

        private static void ApresentaConta(int indiceConta, List<string> titulares, List<double> saldos)
        {
          
        }

        private static void showSubMenu(List<string> titulares, List<double> saldos)
        {

            int optionSubmenu = 0;
            SubMenu();

            optionSubmenu = int.Parse(Console.ReadLine());


            if (optionSubmenu < 4 && optionSubmenu > 0)
            {
                do
                {
                    SubMenu();
                    switch (optionSubmenu)
                    {
                        case 1:
                            Console.Clear();
                            Depositar(); break;
                        case 2:
                            Console.Clear();
                            Sacar(titulares,saldos);
                            break; 
                        case 3:
                            Console.Clear();
                            Transferir(titulares, saldos);
                            break;

                    }

                } while (optionSubmenu != 0);
            }
           


        }


        private static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("digite um cpf: ");
            string cpfParaAprensentar = Console.ReadLine();
            int indexParaApresentar = cpfs.FindIndex(d => d == cpfParaAprensentar);

            if (indexParaApresentar == -1)
            {
                Console.WriteLine("Não foi possível apresentar esta conta");
                Console.WriteLine("MOTIVO: conta não encontrada.");
            }

            ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
        }

 *//*       static double Soma(List<double> saldos)
        {
            return saldos.Sum();//Agregate(0.0,(x, y) => x + y);
        }
*//*

        public static void Main(string[] args)
        {
            Console.Title = "ByteBank1";
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.Clear();



            Console.WriteLine("antes de começar a usar, vamos confimar alguns valores: ");
            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();






            ShowMenu();

            int option;

            do
            {

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("----------------");




                switch (option)
                {



                    case 0:
                        Console.Clear();
                        Console.WriteLine("Estou Encerrando o Program....");

                        break;
                    case 1:
                        Console.Clear();
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        ShowMenu();
                        break;
                    case 2:
                        Console.Clear();
                        deletarUmUsuario(cpfs, titulares, senhas, saldos);
                        ShowMenu();
                        break;
                    case 3:
                        Console.Clear();
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        ShowMenu();
                        break;
                    case 4:
                        Console.Clear();
                        ApresentarUsuario(cpfs, titulares, senhas, saldos);
                        ShowMenu();

                        break;

                    case 5:
                        Console.Clear();
                        SaldoTotalNoBanco(titulares, saldos);
                        break;

                    case 6:
                    
                        Console.Clear();

                        showSubMenu(titulares,  saldos);
                        break;
                }

            }
            while (option != 0);
        }

    }
}
*/



