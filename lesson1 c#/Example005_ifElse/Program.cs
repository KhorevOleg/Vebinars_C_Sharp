Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Олег")
{
    Console.WriteLine("Ура, это же Maria");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}