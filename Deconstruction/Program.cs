Console.WriteLine("what is your name?");
Console.WriteLine("");

String Name = Console.ReadLine();


Console.WriteLine("");
Console.WriteLine("how much gold do you have?");
Console.WriteLine("");

int Gold = int.Parse(Console.ReadLine());


Console.WriteLine("a bronze sword costs 15 gold");

if (Gold < 15)
{
    Console.WriteLine($"uh oh! sorry {Name}, you dont have enough gold!");
}

else 
{
    Gold -= 15;
    Console.WriteLine("you buy the bronze sword!");
    Console.WriteLine($"its a nice sword, {Name}, you now only have {Gold} gold left!");
}