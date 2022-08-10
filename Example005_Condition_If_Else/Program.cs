Console.Write("Insertati numele utilizatorului: ");
string username = Console.ReadLine();

if(username.ToLower() == "masa")
{
    Console.WriteLine("WOW, este MASHA!");
}
else
{
    Console.Write("Buna, ");
    Console.WriteLine(username);
}