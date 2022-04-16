Console.WriteLine("Приветствую! Прежде чем мы начнем игру я хочу напомнить, конь Юлий из известного мульфильма практически выиграл 2 полцарства благодаря такой игре.");
Console.WriteLine("Правила просты: я загадываю, ты отгадываешь.");
Console.WriteLine("У тебя 3 попытки, если не угадаешь сразу, я подскажу больше число от загаданого или меньше. Начнем!");
int tries = 1;
int numberA = new Random().Next(1, 10);
Console.WriteLine("Число от 1 до 10. Угадывай.");
while (tries <= 3)
{
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (tries == 1)
    {
        Console.WriteLine("Первая попытка");
    }
    if (tries == 2)
    {
        Console.WriteLine("Вторая попытка");
    }
    if (tries == 3)
    {
        Console.WriteLine("Третья и последняя попытка");
    }
    if (numberB == numberA)
    {
        Console.WriteLine("Ты выиграл! Два полцарства в твоих руках :)");
        Console.Write("Загаданное число было: ");
        Console.WriteLine(numberA);
        break;
    }
    if (numberA < numberB)
    {
        Console.WriteLine("Загаданное мной число меньше.");
    }
    if (numberA > numberB)
    {
        Console.WriteLine("Загаданное число больше"); 
    }
    tries++;
}
if (tries > 3)
{
    Console.WriteLine("Не получилось. Два полцарства остались у меня :). Загаданное число было " + numberA + ".");
}

//int RandomInt()
//{
//    return new Random().Next(1, 10);
//}