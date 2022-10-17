/* Задача №27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

void GetSumm()
{
    Console.WriteLine("Введите число N: ");
    int num = int.Parse(Console.ReadLine());
    int summ = 0;
    int ostatok = 0;
    while (num > 0)
    {
        ostatok = num%10;
        summ = summ+ostatok;
        num = num/10;
         
    }
    Console.WriteLine($"Сумма цифр в числе {summ}");
}
GetSumm();

