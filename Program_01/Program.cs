using System;

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<float> number = new CircularLinkedList<float>();
        LinkedList<float> Finalnumber = new LinkedList<float>();
        bool newnum = true;
        float num,n,a;
        while(newnum == true)
        {
            num = float.Parse(Console.ReadLine());
            if(num > 0)
            {
                number.Add(num);
            }
            else
            {
                newnum = false;
            }
        }
        n = float.Parse(Console.ReadLine());
        a = (n-1)/2;
        float total1 = 0;
        float total2 = 0;
        for(int i = 0; i < number.GetLength();i++)
        {            
            for(int j = 1; j <= a ;j++)
            {
                total1 += number.Get(i+j);
            }
            for(int j = 1; j <= a ;j++)
            {
                total2 += number.Get(i-j);
            }
            Finalnumber.Add((total1+total2+number.Get(i))/n);
            total1 = 0;
            total2 = 0;
        }
        for(int j = 0; j < Finalnumber.GetLength();j++)
        {
            Console.WriteLine(Finalnumber.Get(j));
        }
    }
}