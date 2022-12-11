class Program
{
    static void Main(string[] args)
    {
        Tree<string> tree = new Tree<string>();
        Stack<string> wait = new Stack<string>();   
        bool test = false;  
        int level = 0;
        tree.AddChild(null,-1);
        do
        {                     
            tree.AddName(InputName(),Inputnumber());
            level++;    
        } 
        while (tree.GetLength() != level);   
        tree.FindAllHead(tree.GetRoot(),InputName(),ref wait,ref test); 
    }
    static string InputName()
    {
        return Console.ReadLine();
    }
    static int Inputnumber()
    {
        return int.Parse(Console.ReadLine());
    }
}