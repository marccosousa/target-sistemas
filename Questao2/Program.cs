Console.Write("Digite o número para ver se ele pertece a sequência de Fibonacci: "); 
int num = int.Parse(Console.ReadLine());
int aux;
List<int> meusNumeros = new List<int>();

int primeiroTermo = 0, segundoTermo = 1; 
Console.Write(primeiroTermo + " " + segundoTermo + " ");
do
{
    aux = primeiroTermo + segundoTermo;
    meusNumeros.Add(aux); 
    primeiroTermo = segundoTermo;
    segundoTermo = aux; 
    Console.Write(aux + " ");
} while (aux <= num);
Console.WriteLine();
bool procurarNaSequencia = meusNumeros.Contains(num);

if (procurarNaSequencia)
{
    Console.WriteLine($"O número {num} pertence a sequência de Fibonacci :)"); 
}
else
{
    Console.WriteLine($"O número {num} não pertence a sequência de Fibonacci :(");
}

Console.ReadLine();

