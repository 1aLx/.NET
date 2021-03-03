using System;

namespace _1leituraDeSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
             incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
             impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/

            //Usuário informa sua senha.
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) //Senha considerada = 2002
	        {   
                //Mensagem de erro caso a senha esteja errada.
                Console.WriteLine("Senha inválida.");
                
                //Usuário informa a senha novamente
                Console.Write("Informe a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
	        }
            //Caso a senha esteja certa.
            Console.WriteLine("Acesso permitido.");
        }
    }
}
