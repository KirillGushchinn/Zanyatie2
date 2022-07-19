Console.WriteLine("vvedite 4islo: ");
int input = Convert.ToInt32(Console.ReadLine());

if (input<99) {
    Console.WriteLine("третьей цифры нет");
}
else {
    int itog = EndNum(input);
    Console.WriteLine(itog);
}

int EndNum (int Num) {
    while (Num>1000){
        Num=Num/10;
    }
    int three = Num%10;
    return three;
}