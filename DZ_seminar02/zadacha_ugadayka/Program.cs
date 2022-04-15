Console.WriteLine("Приветствую! Прежде чем мы начнем игру я хочу напомнить, конь Юлий из известного мульфильма практически выиграл 2 полцарства благодаря такой игре. Правила просты: я загадываю, ты отгадываешь. У тебя 3 попытки, если не угадаешь сразу, я подскажу больше число от загаданого или меньше. Начнем!");
int tries = Convert.ToInt32("1");
int numberA = RandomInt(int numA);
Console.WriteLine("Число от 1 до 10. Угадывай.");
do
{

    if (tries == 1)
    {
        Console.WriteLine("Первая попытка");
    }
    int numberB = Convert.ToInt32(Console.ReadLine());
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
    }
    if (numberA > numberB)
    {
        Console.WriteLine("Загаданное мной число меньше.");
    }
    if (numberA < numberB)
    {
        Console.WriteLine("Загаданное число больше");
    }
    tries++;
    
}
while (tries > 3);
if (tries > 3)
    {
        Console.WriteLine("Не получилось. Два полцарства остались у меня :)");
    }

int RandomInt(int numA)
{
    return new Random().Next(1, 10);
}