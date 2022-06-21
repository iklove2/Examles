Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Я так ждала тебя, Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}