
class Program
{
    static void Main()
    {
        Console.Write("Ingrese el rango inferior: ");
        int rangoInferior = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el rango superior: ");
        int rangoSuperior = int.Parse(Console.ReadLine());

        Console.WriteLine($"Números amigos en el rango de {rangoInferior} a {rangoSuperior}:");
        EncontrarAmigos(rangoInferior, rangoSuperior);

    }

    static void EncontrarAmigos(int rangoInferior, int rangoSuperior)
    {
        for (int i = rangoInferior; i <= rangoSuperior; i++)
        {
            int sumaDivisoresI = SumaDivisores(i);

            if (sumaDivisoresI > i && sumaDivisoresI <= rangoSuperior)
            {
                int sumaDivisoresAmigo = SumaDivisores(sumaDivisoresI);

                if (sumaDivisoresAmigo == i)
                {
                    Console.WriteLine($"{i} y {sumaDivisoresI} son números amigos.");
                }
            }
        }
    }

    static int SumaDivisores(int numero)
    {
        int suma = 1;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                suma += i;

                if (i != (numero / i))
                {
                    suma += numero / i;
                }
            }
        }

        return suma;
    }
} 
