using DIO_ByteBank.AccountCorrentServices;
using DIO_ByteBank.Interfaces;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class AdministrativeLoginView
    {
        public static object ValidateLogin { get; private set; }

        public static void LoginView()
        {
            string login;
            string password = "";
            bool res;
            Console.WriteLine("+------------------------------------------------------+");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|    Você está Tentando Acessar Área Administrativa    |");
            Console.WriteLine("|      Necessário Realizar o Login de Autorização      |");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("+------------------------------------------------------+");
            Console.Write("\n   Informe o Nome de usuário autorizado: ");
            Console.Write("\n   ");
            login = Console.ReadLine();
            Console.Write("\n   Informe a Senha de Autorização: ");
            Console.Write("\n   ");

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);  // A Lib/Namespace System possui a CLASSE ConsoleKeyInfo que permite capturar as teclas pressionadas via console
                // Instanciei o objeto Key da classe ConsoleKeyInfo
                
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter) // Através do objeto Key podemos acesar a Properti Key que retorna a tecla UNICODE pressionada.
                                                                                    // Então vamos comprar a tecla pressionada se é a tecla Backspace ou a tecla Enter
                // Se não teclar o Backspace ou a Tecla Enter faça
                {
                    password += key.KeyChar;  //  O objeto Key da classe ConsoleKeyInfo possui a Properti KeyChar que nos permite acessar e retornar a tecla perssionada
                    Console.Write("*"); // No console vamos exibir apenas o * 
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)  // Se a tecla Backspace for pressionada e existir caracteres armazenados na variável password faça
                    {
                        password = password.Substring(0, (password.Length - 1)); // O método Substring vai remover os caracteres que estão fora da condição passada por parâmetro.
                                                                                 // Da posição zero até a posição passado no segundo parâmetro vai manter, os demais caracateres serão removidos.
                                                                                 // Por exemplo, se a senha for 123456, temos um array de caractere contendo 6 elementos. O Substring vai manter os elementos que
                                                                                 // estão dentro do intervalo passado por parâmetro e vai remover os demais, porque conforme podemos observar, então, 
                                                                                 // o caracatere da posição 0 até a posição do tamanho da senha MENOS UM deve ser mantido, os demais caracateres serão removidos.
                        Console.Write("\b \b"); // \b é um operador de linha de comando
                    }
                    else if (key.Key == ConsoleKey.Enter)  // Assim que teclar ENTER sai do loop do while
                    {
                        break;
                    }
                }
            } while (true);

            res = AdmLogin.ValidateLogin(login, password);

            do
            {
                if (res)
                {
                    Console.WriteLine("\nLogin Autorizado");
                    Console.WriteLine("Tecle ENTER para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nTela Inical > Alerta");
                    Console.WriteLine("\n+======================================================+");
                    Console.WriteLine("|               Login Não Autorizado                   |");
                    Console.WriteLine("|    Usuário ou Senha Incorretos - Tente Novamente!    |");
                    Console.WriteLine("|                                                      |");
                    Console.WriteLine("|    ENTER para Tentar Novamente                       |");
                    Console.WriteLine("|    [P] para Voltar ao Menu Principal                 |");
                    Console.WriteLine("+======================================================+");
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.P)
                    {
                        InitialInterfaceView.Menu();
                        break;
                    }
                    Console.Clear();
                    LoginView();
                }
            } while (true);
            AdministrativeView.Menu();
        }
    }
}
