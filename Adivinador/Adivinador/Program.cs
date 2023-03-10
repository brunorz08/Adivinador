Console.WriteLine("Bienvenido al Adivinador 1.0");
Console.WriteLine("Se generará un numero aleatorio del 1 al 100. Usted posee 10 intentos para adivinarlo.");
Console.Write("Generando");
for(int i = 0;i < 5; i++)
{
    Console.Write(".");
    Thread.Sleep(350);
}

Console.WriteLine();

Random Random = new Random();
int numeroRandom;


numeroRandom = Random.Next(1, 101);
for (int i = 0; i < 10; i++)
{
    Console.Write("Por favor ingrese un número: ");
    int numeroDelUsuario = Convert.ToInt32(Console.ReadLine());

    if (numeroDelUsuario > numeroRandom)
    {
        Console.WriteLine("El numero a adivinar es menor al ingresado");

    }
    else if (numeroDelUsuario < numeroRandom)
    {
        Console.WriteLine("El numero a adivinar es mayor al ingresado");

    }

    else
    {
        Console.WriteLine($"Felicitaciones! El numero era {numeroRandom}");
        break;
    }

    if(i == 9)
    {
        Console.WriteLine($"Perdiste! El numero era {numeroRandom}");
    }
        
    }






