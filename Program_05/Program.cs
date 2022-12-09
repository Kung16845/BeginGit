using System;

class Program
{
    static void Main(string[] args)
    {
       BinarySearchTree<int> number = new BinarySearchTree<int>();
       bool newnum = true;
       int num,a = 0,b = 0;
        while(newnum == true)
        {
            num = int.Parse(Console.ReadLine());
            if(num > 0)
            {
                number.Add(num);
            }
            else
            {
                newnum = false;
            }
        }
        int num1 =int.Parse(Console.ReadLine());
        int num2 =int.Parse(Console.ReadLine());
        for(int i = 0;i < number.GetLength();i++)
        {
            if(num1 == number.Get(i))
            {
                a = i;
            }
            if(num2 == number.Get(i))
            {
                b = i;
            }
        }
        Console.WriteLine(Math.Abs(a-b+1));
    }
}