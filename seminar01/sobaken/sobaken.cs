int count = 0; //счетчик, сколько пробежит собака
Console.WriteLine("Введите расстояние между друзьями (целое число):");
int distance = Convert.ToInt32(Console.ReadLine()); //km
int time = 0; //min
Console.WriteLine("Введите с какой скоростью идет первый друг (целое число):");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine()); //km/h
Console.WriteLine("Введите с какой скоростью идет второй друг (целое число):");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine()); //km/h
Console.WriteLine("Введите с какой скоростью бежит собака (целое число):");
int dogSpeed = Convert.ToInt32(Console.ReadLine()); //km/h
int friend = 2; //к какому другу бержит собака
while (distance > 1) // условие для окончания цикла
{
   	if (friend == 2) //условие - проверка к кому бежит собака
	{
    	time = distance / (secondFriendSpeed + dogSpeed); //формула вычисления времени в направлении 2 друга
		friend = 1; //смена направления
	}
	else 
	{
		time = distance / (firstFriendSpeed + dogSpeed); //формула вычисления времени в направлении 1 друга
		friend = 2; //смена направления
	}
	distance = (firstFriendSpeed + secondFriendSpeed) * time; //формула вычисления дистанции
	count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз.");