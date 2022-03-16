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
int L = 3;
Console.WriteLine("Элементы массива с количеством символов <=3: ");
for (int i = 0; i < myString.Length; i++)
{
    int result = myString[i].Length;
    if (result <= L)
    {

        Console.WriteLine($" {myString[i]} ");
    }
}
//Второй (нерекомендованный) вариант решения задачи
/*string[] myString = { "мир", "one", "Привет", "list", "Строка", "we", "C#", "LINQ" };
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
List<string> result = new List<string>();
foreach (string s in myString)
{
    if (s.Length <= 3)
    {
        result.Add(s);
    }
}
Console.WriteLine("Массив строк, длина которых <= 3 символа:");
foreach (string s in result)
    Console.WriteLine(s);*/

//Кроме непосредственного решения задачи в виде составления программы
//была составлена блок-схема решения данной задачи. Был создан репозиторий на GitHub.
//Создан файл README.md