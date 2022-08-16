Console.WriteLine("Enter username");
string username = Console.ReadLine();

if (username.ToLower() == "sergey") 
{
    Console.WriteLine("Ura, eto je SERGEY");
}
else 
{
    Console.WriteLine("GO AWAY, ");
    Console.WriteLine(username);
}
