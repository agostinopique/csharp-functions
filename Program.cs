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
    Console.WriteLine("}");
}

#endregion PrintArray Function


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

#endregion Somma elementi array

//int[] numbersArray = { 2, 6, 7, 5, 3, 9 };

//Console.WriteLine("L'array é: ");

//PrintArray(numbersArray);

//Console.WriteLine("L'array elevato al quadrato é: ");

//PrintArray(SquareElevation(numbersArray));

//Console.WriteLine("La somma dei numeri presenti nell'array é: " + ArrayElementsSum(numbersArray));

//Console.WriteLine("La somma di tutti i numeri dell'array elevati al quadrato é:" + ArrayElementsSum(SquareElevation(numbersArray));


#region BONUS

Console.WriteLine("Quanti numeri vuoi inserire?");

int[] userArray = new int[Convert.ToInt32(Console.ReadLine())];

for( int i = 0; i < userArray.Length; i++)
{

    Console.WriteLine("Inserisci un numero");

    userArray[i] = Convert.ToInt32(Console.ReadLine());

}


Console.WriteLine("L'array é: ");

PrintArray(userArray);

Console.WriteLine("L'array elevato al quadrato é: ");

PrintArray(SquareElevation(userArray));

Console.WriteLine("La somma dei numeri presenti nell'array é: " + ArrayElementsSum(userArray));

Console.WriteLine("La somma di tutti i numeri dell'array elevati al quadrato é:" + ArrayElementsSum(SquareElevation(userArray)));

#endregion BONUS