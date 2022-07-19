Console.WriteLine("Введите день недели: ");
int input = Convert.ToInt32(Console.ReadLine());

    string itog = Day(input);
    Console.WriteLine(itog);

string Day (int Num) 
{
    String result;
    if ((Num==6)||(Num==7))
    {
        result="Выходной день";
    } 
    else if (Num < 1 || Num > 7)
    result="Это не день недели";
    else 
    {
         result="Рабочий день";
    }
    
    
    return result;
}