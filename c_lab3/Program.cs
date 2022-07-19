Console.WriteLine("vvedite den nedeli: ");
int input = Convert.ToInt32(Console.ReadLine());

    string itog = Day(input);
    Console.WriteLine(itog);

string Day (int Num) {
    String result;
    if ((Num==6)||(Num==7)){
        result="Да";
    } else {
         result="Нет";
    }
    return result;
}