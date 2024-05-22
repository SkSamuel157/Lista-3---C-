// Questão 03

using System;

// 1
/*namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeroFuncionario;
            double horasTrabalhadas;
            double valorHora;
            double salario;

            
            Console.WriteLine("Informe o número do funcionário:");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas:");
            horasTrabalhadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora:");
            valorHora = double.Parse(Console.ReadLine());

            
            salario = horasTrabalhadas * valorHora;

            // Apresentação do resultado
            Console.WriteLine("Número do funcionário: " + numeroFuncionario.toString("F2");
            Console.WriteLine("Salário: " + salario.toString("F2");
        }
    }
}*/

// 2
/*namespace CalculoValorPecas
{
    class Program
    {
        static void Main(string[] args)
        {

            string codigoPeca1;
            int quantidadePeca1;
            double valorUnitarioPeca1;

            string codigoPeca2;
            int quantidadePeca2;
            double valorUnitarioPeca2;

            double valorTotal;


            Console.WriteLine("Informe o código da peça 1:");
            codigoPeca1 = Console.ReadLine();

            Console.WriteLine("Informe a quantidade da peça 1:");
            quantidadePeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário da peça 1:");
            valorUnitarioPeca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da peça 2:");
            codigoPeca2 = Console.ReadLine();

            Console.WriteLine("Informe a quantidade da peça 2:");
            quantidadePeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário da peça 2:");
            valorUnitarioPeca2 = double.Parse(Console.ReadLine());


            valorTotal = (quantidadePeca1 * valorUnitarioPeca1) + (quantidadePeca2 * valorUnitarioPeca2);


            Console.WriteLine("Código da peça 1: " + codigoPeca1);
            Console.WriteLine("Quantidade da peça 1: " + quantidadePeca1);
            Console.WriteLine("Valor unitário da peça 1: " + valorUnitarioPeca1.ToString("F2"));

            Console.WriteLine("Código da peça 2: " + codigoPeca2);
            Console.WriteLine("Quantidade da peça 2: " + quantidadePeca2);
            Console.WriteLine("Valor unitário da peça 2: " + valorUnitarioPeca2.ToString("F2"));

            Console.WriteLine("\nValor total a ser pago: " + valorTotal.ToString("F2"));
        }
    }
}*/

// 3
/*namespace CalculoAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valorA;
            double valorB;
            double valorC;

            
            Console.WriteLine("Informe o valor de A:");
            valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C:");
            valorC = double.Parse(Console.ReadLine());

            
            double areaTrianguloRetangulo = (valorA * valorC) / 2.0;
            double areaCirculo = 3.14159 * valorC * valorC;
            double areaTrapezio = (valorA + valorB) / 2.0 * valorC;
            double areaQuadrado = valorB * valorB;
            double areaRetangulo = valorA * valorB;

            
            Console.WriteLine("\nÁrea do triângulo retângulo: " + areaTrianguloRetangulo.ToString("F2"));
            Console.WriteLine("Área do círculo: " + areaCirculo.ToString("F2"));
            Console.WriteLine("Área do trapézio: " + areaTrapezio.ToString("F2"));
            Console.WriteLine("Área do quadrado: " + areaQuadrado.ToString("F2"));
            Console.WriteLine("Área do retângulo: " + areaRetangulo.ToString("F2"));
        }
    }
}*/


// Questão 3.5

// 1
/*namespace VerificaLoginSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string loginUsuario;
            string senhaUsuario;

            
            Console.WriteLine("Informe o login:");
            loginUsuario = Console.ReadLine();

            Console.WriteLine("Informe a senha:");
            senhaUsuario = Console.ReadLine();

            
            if (loginUsuario == "admin" && senhaUsuario == "1234")
            {
                Console.WriteLine("Acesso permitido!");
            }
            else
            {
                Console.WriteLine("Login ou senha incorreto.");
            }
        }
    }
}*/

// 2
/*namespace VerificaEstoqueBlusas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int quantidadeBlusas;

            
            Console.WriteLine("Informe a quantidade de blusas no estoque:");
            quantidadeBlusas = int.Parse(Console.ReadLine());

            
            if (quantidadeBlusas > 40)
            {
                Console.WriteLine("ESTOQUE OK");
            }
            else if (quantidadeBlusas > 20 && quantidadeBlusas <= 40)
            {
                Console.WriteLine("ATENÇÃO AO ESTOQUE");
            }
            else
            {
                Console.WriteLine("ESTOQUE CRÍTICO");
            }
        }
    }
}*/

// 3
/*namespace VerificaRequisitosVisto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int idadeUsuario;
            double salarioUsuario;

            
            Console.WriteLine("Informe sua idade:");
            idadeUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu salário:");
            salarioUsuario = double.Parse(Console.ReadLine());

            
            if (idadeUsuario >= 18 && salarioUsuario > 2000)
            {
                Console.WriteLine("PODE VIAJAR");
            }
            else
            {
                Console.WriteLine("NÃO PODE VIAJAR");
            }
        }
    }
}*/

// 4
/*namespace AulaEscolhida
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int escolhaAula;

            
            Console.WriteLine("Digite o número da sua escolha:");
            escolhaAula = int.Parse(Console.ReadLine());

            
            switch (escolhaAula)
            {
                case 1:
                case 2:
                    Console.WriteLine("DESENHO E PINTURA");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("DISCURSO E DEBATE");
                    break;
                default:
                    Console.WriteLine("DANÇA");
                    break;
            }
        }
    }
}*/

// 5
/*namespace VerificaNumeroEspecial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeroUsuario;

            
            Console.WriteLine("Digite um número:");
            numeroUsuario = int.Parse(Console.ReadLine());

            
            if (numeroUsuario > 0 && numeroUsuario > 100)
            {
                Console.WriteLine("Número especial");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}*/
