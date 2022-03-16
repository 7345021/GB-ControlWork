//Написать программу, которая из имеющегося массива строк, формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно задать либо с клавиатуры,
//либо задать на старте выполнения алгоритма.
string[] myString = new string[] { "hello", "two", "C#", "we", "one", "nine", "and", "first" };
Console.WriteLine("Первоначальный массив");
Console.WriteLine(myString[0]);
Console.WriteLine(myString[1]);
Console.WriteLine(myString[2]);
Console.WriteLine(myString[3]);
Console.WriteLine(myString[4]);
Console.WriteLine(myString[5]);
Console.WriteLine(myString[6]);
Console.WriteLine(myString[7]);
Console.WriteLine();
int L=3;
Console.WriteLine("Элементы массива с количеством символов <=3: ");
