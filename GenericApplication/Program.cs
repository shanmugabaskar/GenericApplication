// See https://aka.ms/new-console-template for more information
//declaring an int array
using GenericApplication;

MyGenericArray<int> intArray = new MyGenericArray<int>(5);

//setting values
for (int c = 0; c < 5; c++)
{
    intArray.setItem(c, c * 5);
}

//retrieving the values
for (int c = 0; c < 5; c++)
{
    Console.Write(intArray.getItem(c) + " ");
}

Console.WriteLine();

//declaring a character array
MyGenericArray<char> charArray = new MyGenericArray<char>(5);

//setting values
for (int c = 0; c < 5; c++)
{
    charArray.setItem(c, (char)(c + 97));
}

//retrieving the values
for (int c = 0; c < 5; c++)
{
    Console.Write(charArray.getItem(c) + " ");
}
Console.WriteLine();

Console.ReadKey();
