using System;

namespace MeuAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            string name = RetornaNome("Aline", "Lima");
            Console.WriteLine(name);
        }

        static void MeuMetodo()
        {
            Console.WriteLine(" Teste ======>");
        }

        static string RetornaNome(
            string name,
            string lastname,
            int age = 34,
            string gender = "mulher"
            )
        {
            return name + " " + lastname + " tem " + age + " anos e, é uma " + gender;
        }

    }
}