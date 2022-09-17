// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Metallica!");

#region PrintArray Function

void PrintArray(int[] array)
{
    Console.Write("{");

    int i;

    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
    Console.Write(array[i]);
    Console.Write("}");
}

#endregion PrintArray Function
int[] arrayNumeri = { 1, 2, 3 };

//PrintArray(arrayNumeri);

#region Quadrato function

int Quadrato(int numero)
{
    return numero * numero;
}

#endregion Quadrato function

#region Quadrato array function

int[] ElevaArrayAlQuadrato(int[] array)
{

    int[]arrayCopia = (int[])array.Clone();

    for (int i = 0; i < arrayCopia.Length; i++)
    {
        arrayCopia[i] = Quadrato(arrayCopia[i]);
    }

    return arrayCopia;
}

PrintArray(ElevaArrayAlQuadrato(arrayNumeri));

#endregion Quadrato array function

