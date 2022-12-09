using System;

class Program
{
    static void Main(string[] args)
    {
        Tree<string> nameRepair = new Tree<string>();
        string name = Console.ReadLine();
        int money = int.Parse(Console.ReadLine());
        string check = Console.ReadLine();
        nameRepair.AddChild(-1,name);
        int price = 0,total = 0;
        while(total != money)
        {
            name = Console.ReadLine();
            price = int.Parse(Console.ReadLine());
            check = Console.ReadLine();
            total += price;
        }
    
    }
}