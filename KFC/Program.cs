public class Program
{
    public static void Main(string[] args )
    {
        Information inform = new Information();
        Circulation circul = new Circulation();
        Console.WriteLine("Input 1 for store , 2 for cofounder , 3 for employeejob ");
        Console.Write("Input 4 circulatio , 5 for salary : ");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            inform.printinfomationstore();
        }
        else if (n == 2)
        {
            inform.ptintcofounder();
        }
        else if (n == 3)
        {
            inform.employeejob();
        }
        else if (n == 4)
        {
            circul.ptintncirculatio();
        }
        else if (n == 5)
        {
            circul.printinfomationsalary();
        }
        else 
        {
            Console.WriteLine("Please input number 1-5");
        }
    }
   
}

