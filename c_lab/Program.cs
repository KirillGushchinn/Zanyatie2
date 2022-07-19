// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
int itog = CenterNum(input);
Console.WriteLine(itog);
    
int CenterNum (int Num) {
    int Second = Num/10%10;
    return Second;
}