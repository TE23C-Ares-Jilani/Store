using Microsoft.VisualBasic;

int playerMoney = 100;

while (playerMoney > 0)
{
    Console.WriteLine("welcome to the diddy shop.");
    Console.WriteLine($"you got {playerMoney} diddy coins");

    // vad man kan köpa

    Console.WriteLine("You can buy:");
    Console.WriteLine("1. toilet (10 dcoins)");
    Console.WriteLine("2. baby oil (20 dcoins)");
    Console.WriteLine("3. drugs (30 dcoins)");

    string buy = "";
    while (buy != "1" && buy != "2" && buy != "3")
    {
        buy = Console.ReadLine();
    }

    //price per item

    int pricePerItem = 0;
    if (buy == "1")
    {
        pricePerItem = 10;
    }
    if (buy == "2")
    {
        pricePerItem = 20;
    }
    if (buy == "3")
    {
        pricePerItem = 30;
    }
    // How many buy

    Console.WriteLine("Hur många vill du köpa?");
    int howMany = 0;
    while (howMany == 0)
    {
        string num = Console.ReadLine();
        bool success = int.TryParse(num, out howMany);
        if (success == false)
        {
            Console.WriteLine("write a number dickhead");
        }
    }
    int finalCost = pricePerItem * howMany;
    if (finalCost <= playerMoney)
    {
        Console.WriteLine("Ight that works");
        playerMoney -= finalCost;
    }
else
    {
        Console.WriteLine("Nah, you to poor for that");
}
}

Console.WriteLine("You out of money now");
Console.WriteLine("cya later. press ENTER to close");
Console.ReadKey();








