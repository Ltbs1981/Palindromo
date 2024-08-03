Console.WriteLine("Digite uma palavra" );
string palavra = Console.ReadLine();
Console.WriteLine($"A palavra digitada foi: {palavra}.");

//convertendo a palavra para um vetor

char[] arr = palavra.ToCharArray();
Array.Reverse(arr);

string palindromo = new string(arr);

if (palindromo == palavra)
{
    Console.WriteLine("essa palavra é um palíndromo!" );
}else
{
    Console.WriteLine("palavra não é um palíndromo ");
}