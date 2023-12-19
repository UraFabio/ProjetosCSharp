using CalculadoraSimples;

CalculadoraSimples.CalculadoraSimples calculadora = new CalculadoraSimples.CalculadoraSimples();

int counter = -1;
int input, x, y;

while(counter != 0)
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("[1] - Somar");
    Console.WriteLine("[2] - Subtrair");
    Console.WriteLine("[3] - Multiplicar");
    Console.WriteLine("[4] - Dividir inteiro");
    Console.WriteLine("[5] - Potencia");
    Console.WriteLine("[6] - Raiz quadrada");
    Console.WriteLine("[0] - Sair\n");

    Console.Write(">> ");
    input = Convert.ToInt16(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.Write("Primeiro termo >> ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Segundo termo >> ");
            y = Convert.ToInt16(Console.ReadLine());
            calculadora.Somar(x, y);
            break;
        case 2:
            Console.Write("Primeiro termo >> ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Segundo termo >> ");
            y = Convert.ToInt16(Console.ReadLine());
            calculadora.Subtrair(x, y);
            break;
        case 3:
            Console.Write("Primeiro termo >> ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Segundo termo >> ");
            y = Convert.ToInt16(Console.ReadLine());
            calculadora.Multiplicar(x, y);
            break;
        case 4:
            Console.Write("Primeiro termo >> ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Segundo termo >> ");
            y = Convert.ToInt16(Console.ReadLine());
            calculadora.Dividir(x, y);
            break;
        case 5:
            Console.Write("Primeiro termo >> ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Segundo termo >> ");
            y = Convert.ToInt16(Console.ReadLine());
            calculadora.Potencia(x, y);
            break;
        case 6:
            Console.Write("Primeiro termo >> ");
            x = Convert.ToInt16(Console.ReadLine());
            calculadora.RaizQuadrada(x);
            break;
        case 0:
            counter = 0;
            break;
        default:
            Console.WriteLine("Opção inválida, digite novamente");
            break;
    }

    Console.WriteLine("Obrigado por usar minha calculadora");

}