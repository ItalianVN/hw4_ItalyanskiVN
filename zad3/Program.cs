/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/



Console.WriteLine ("Введите 8 элементов масива, через запятую");
string array = Console.ReadLine();
string [] arr = array.Split(new char[] {','});
int[] result = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    result[i]= int.Parse(arr[i]);
}
Console.WriteLine("[{0}]",string.Join(",",result));
