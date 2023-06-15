// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

/* atividade 1
 * 
 * 
 * 
class program
{
    static void main(string[] args)
    {
        cultureinfo ci = cultureinfo.invariantculture;
        double x;
        x = 2.3456;
        console.writeline(x.tostring("f5", ci));
        console.writeline("hello, world!");
    }

}
*/

/* ATIVIDADE 2
 * 
 * 
 * 
class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int idade;
        double salario;
        string nome;
        char sexo;

        idade = 32;
        salario = 4560.09;
        nome = "Maria silva";
        sexo = 'F';

        Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo + " , ganha " +
            salario.ToString("F2", CI) + " e tem " + idade + " anos");
    }

}
*/

/* ATIVIDADE 3
 * 
 * 
 * 
class Program
{
    static void Main(string[] args)
    {

        CultureInfo CI = CultureInfo.InvariantCulture;
        int x;
        double y;
        x = 5;
        y = 2 * x;
        Console.WriteLine(x);
        Console.WriteLine(y.ToString("F1", CI));
    }

}
*/

/* ATIVIDADE 4
 * 
 * 
 * 
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;
            Console.Write("Nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
            Console.Write("Salario da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.Write("Salario da segunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite um sexo (F/M): ");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Nome 1: " + nome1);
            Console.WriteLine("Salario 1: " + salario1.ToString("F2", CI));
            Console.WriteLine("Nome 2: " + nome2);
            Console.WriteLine("Salario 2: " + salario2.ToString("F2", CI));
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Sexo: " + sexo);
        }
    }
}
*/

/*
 * 
 * 
 * 
using System;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.Write("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                Console.WriteLine("Boa tarde!");
            }
        }
    }
}

*/


namespace programa
{
    class program
    {
        static void main(string[] args)
        {
            int x, soma;
            soma = 0;
            console.write("digite o primeiro numero: ");
            x = int.parse(console.readline());
            while (x != 0)
            {
                soma = soma + x;
                console.write("digite outro numero: ");
                x = int.parse(console.readline());
            }
            console.writeline("soma = " + soma);
        }
    }
}