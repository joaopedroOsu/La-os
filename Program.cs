Console.Write("Quantos devo exibir");
int maximo = Convert.ToInt32(Console.ReadLine());
int Contador = 0;

while(Contador < maximo)
{
    if(Contador % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    Console.Write("Hello, World! ");
int repeticoes = 0;
while (repeticoes < 3)
    {
        
    repeticoes = repeticoes + 1;
    }
Contador = Contador + 1;

Console.WriteLine(Contador );
}
Console.ReadLine();