do
{
    Console.WriteLine("Digite uma palavra");
    string palavra = Console.ReadLine();
    Console.WriteLine($"A palavra digitada foi: {palavra}.");

    //convertendo a palavra para um vetor

    char[] vetor = palavra.ToCharArray();
    Array.Reverse(vetor);

    string palindromo = new string(vetor);

    if (palindromo == palavra)
    {
        Console.WriteLine("Essa palavra é um palíndromo!");
    }
    else
    {
        Console.WriteLine("A palavra não é um palíndromo ");
    }
    Console.WriteLine("Digite 1 para sair, ou qualquer outro número para testar outra palavra!");
    int sair = int.Parse(Console.ReadLine());
    if (sair == 1)
    {
        break;

    }
} while (true);
