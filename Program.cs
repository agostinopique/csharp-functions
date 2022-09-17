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


#region Square function

int Square(int numero)
{
    return numero * numero;
}

#endregion Square function

#region Square array function

int[] SquareElevation(int[] array)
{

    int[]arrayCopia = (int[])array.Clone();

    for (int i = 0; i < arrayCopia.Length; i++)
    {
        arrayCopia[i] = Square(arrayCopia[i]);
    }

    return arrayCopia;
}

PrintArray(SquareElevation(arrayNumeri));

#endregion Square array function


#region Somma elementi array

int ArrayElementsSum(int[] array)
{
    int sumArray = 0;

    for (int i = 0; i < array.Length; i++)
    {

        sumArray = sumArray + array[i];

    }
    return sumArray;
}

Console.WriteLine();

PrintArray(arrayNumeri);


Console.WriteLine(ArrayElementsSum(arrayNumeri));

#endregion Somma elementi array