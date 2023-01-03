
using System.Drawing;

namespace ByteBank1
{
    public class Program
    {



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
                ApresentaConta(i,cpfs, titulares, saldos);
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


        private static void testc()
        {
            for(int i = 8; i < 18; i++)
            {
                Console.WriteLine(i);
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

        static double Soma(List<double> saldos)
        {
            return saldos.Sum();//Aggregate(0.0,(x, y) => x + y);
        }


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





            int option;

            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine( );
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
                        break;
                    case 2:
                        Console.Clear();
                        deletarUmUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 3:
                        Console.Clear();
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        Console.Clear();
                       ApresentarUsuario(cpfs, titulares, senhas, saldos);
                      
                        break;

                        case 5:
                        Console.Clear();
                        {
                            testc();
                            break;
                        }

                }


            }
            while (option != 0);







        }

      
    }
}