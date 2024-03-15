Console.Write("Digite o texo que você quer inverter: ");
string texto = Console.ReadLine(); 

string textoInvertido = "";

for (int i = texto.Length - 1; i >= 0; i--)
{
    textoInvertido += texto[i];
}

Console.WriteLine("Texto invertido: " + textoInvertido);

Console.ReadLine();
