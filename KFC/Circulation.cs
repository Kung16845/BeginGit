public class Circulation
{ 
    
    public void ptintncirculatio()
    {           
       int i = 0;
       string[] numberstore = new string[] {"26","27","35","50","138"};
       string[] totalstore = new string[] {"3,302" , "3,429","4,445","6,350","17,526"}; 
       string[] numberdelivery = new string[] {"78","96","159","271","604"};
       string[] totaldelivery = new string[] {"27,846" , "34,272","59,763","96,747","218,628"}; 
       Console.WriteLine("Number of store(Time)  Total of store(Baht)  Number of delivery(Time)  Total of delivery(Bath)");
       for ( i = 0 ; i < 4;i++)
       {                       
            Console.WriteLine("Week {0} :  {1}   {2}   {3}  {4}", i+1, numberstore[i], totalstore[i],numberdelivery[i],totaldelivery[i]);
       }
       Console.WriteLine("AllTotalincome : {0}  {1}   {2}   {3} ", numberstore[4], totalstore[4],numberdelivery[4],totaldelivery[4]);
    }
    public void printinfomationsalary()
    {
        int i = 0;
        string[] name = new string[] {"NaiChaiDi","NaiNonDi","NaiAphaiDi","NaiThamDi","NaiNon Di"};
        string[] jobs = new string[] {"Store Staff","Food delivery man"};
        string[] numberstore = new string[] {"25","52","61","0","0"};
        string[] numberdelivery = new string[] {"201","201","202","300","304"};
        string[] salary = new string[] {"15,000","12,500"};
        string[] selesshare = new string[] {"1,873.3","1,959.025","1,996.525","2,677.5","2,713.2"};
        string[] fare = new string[] {"8,250"};
        string[] faredelivery = new string[] {"0","45000"};
        Console.WriteLine("Name    Jobs   Number of store(Time)   Number of delivery(Time)  Salary(ฺBaht)  Profit   Fare   Faredelivery");
        for ( i = 0 ; i < 5;i++)
        { 
            if (i < 3)
            {
                Console.WriteLine("{0}  {1}   {2}   {3}  {4}  {5}  {6}  {7} ",name[i],jobs[0],numberstore[i],numberdelivery[i],salary[0],selesshare[i],fare[0],faredelivery[0]);
            }
            else 
            {
                Console.WriteLine("{0}  {1}   {2}   {3}  {4}  {5}  {6}  {7} ",name[i],jobs[1],numberstore[i],numberdelivery[i],salary[1],selesshare[i],fare[0],faredelivery[1]);
            }
        }
        Console.WriteLine("AllTotaloutcome : 213,776.55");
    }
}