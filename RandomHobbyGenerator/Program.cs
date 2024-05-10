
using System.IO.Enumeration;

Random rand = new Random();
var name = "";
var exitOrNew = "";


void Run()
{   
    while (true) {
        Console.WriteLine("Who would Like a new hobby?");
        name = Console.ReadLine();
        GetHobby(); 
        Console.WriteLine("Type 'exit' to exit or type anything else for a new hobby");
        exitOrNew = Console.ReadLine();
        GoodBye();
    }
}


void GetHobby()
{
    var randHobby = rand.Next(0, 5);
    if (randHobby == 0)
    {
        Console.WriteLine($"{name} is now a liver-patè taster!");
    }
    else if(randHobby == 1)
    {
        Console.WriteLine($"{name} is now a professional toad licker!");
    }
    else if (randHobby == 2)
    {
        Console.WriteLine($"{name} is now a sock knitter!");
    }
    else if (randHobby == 3)
    {
        Console.WriteLine($"{name} is now a professional fish cuddler!");
    }
    else 
    {
        Console.WriteLine($"{name} is now a professional Waldo finder!");
    }
}

void GoodBye()
{
    if (exitOrNew == "exit")
    {
        Environment.Exit(0);
    }
}

Run();