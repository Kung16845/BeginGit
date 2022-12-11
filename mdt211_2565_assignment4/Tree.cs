class Tree<T>
{
    private TreeNode<T> root = null;
    private int length = 0;

    public TreeNode<T> GetRoot()
    {
        return this.root;
    }
    public void AddSibling(int index,string value)
    {
        TreeNode<T> node = new TreeNode<T>(value);
        TreeNode<T> ptr = this.GetTreeNode(index);
        node.SetNext(ptr.Next());
        ptr.SetNext(node);
        this.length++;
    }
     public void FindAllHead(TreeNode<T> Node, string name, ref Stack<string> ans, ref bool isFind)
    {
        TreeNode<T> ptr = Node;
        Stack<string> list = ans;

        if (ptr.GetValue() == name)
        {
            while (list.GetLength() > 0)
            {
                Console.WriteLine(list.Pop());
            }
            isFind = true;
            return;
        }

        if (Node.Child() != null && !isFind)
        {
            list.Push(ptr.GetValue());
            this.FindAllHead(Node.Child(), name, ref list, ref isFind);
            if (list.GetLength() != 0)
            {
                list.Pop();
            }
        }

        if (Node.Next() != null && !isFind)
        {
            this.FindAllHead(Node.Next(), name, ref list, ref isFind);
        }

        return;
    }
    public void AddName(string value,int member)
    {
        int numbermem = this.length;
        TreeNode<T> ptr = CheckNull(this.root,ref numbermem);
        ptr.SetValue(value);
        int i = 1;
        while (i <= member)
        {
            TreeNode<T> node = new TreeNode<T>(null);
            if (i == 1)
            {
                ptr.SetChild(node);
                ptr = ptr.Child();
            }
            else
            {
                ptr.SetNext(node);
                ptr = ptr.Next();
            }
            this.length++;

            i++;
        } 
    }
    private TreeNode<T> CheckNull(TreeNode<T> Node, ref int numbermem)
    {

        TreeNode<T> ptr = Node;

        if (ptr.GetValue() == null) 
        { 
            numbermem = 0; 
            return ptr; 
        }

        if (numbermem > 0 && Node.Child() != null)
        {
            numbermem++;
            ptr = this.CheckNull(Node.Child(), ref numbermem);
        }

        if (numbermem > 0 && Node.Next() != null)
        {
            ptr = this.CheckNull(Node.Next(), ref numbermem);
        }

        return ptr;
    }
    public void AddChild(string value,int index)
    {
        TreeNode<T> node = new TreeNode<T>(value);
        if(index == -1)
        {
            node.SetChild(this.root);
            this.root = node;
        }
        else
        {
            TreeNode<T> ptr = this.GetTreeNode(index);
            node.SetChild(ptr.Child());
            ptr.SetChild(node);
        }
        this.length++;
    }

    public int GetLength()
    {
        return this.length;
    }

    public string Get(int index)
    {
        TreeNode<T> ptr = this.GetTreeNode(index);
        return ptr.GetValue();
    }

    private TreeNode<T> GetTreeNode(int index)
    {
        int traverseStep = index;
        return this.Traverse(this.root, ref traverseStep);
    }

    private TreeNode<T> Traverse(TreeNode<T> currentTreeNode, ref int traverseStep)
    {
        TreeNode<T> ptr = currentTreeNode;

        if(traverseStep > 0 && currentTreeNode.Child() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentTreeNode.Child(), ref traverseStep);
        }

        if(traverseStep > 0 && currentTreeNode.Next() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentTreeNode.Next(), ref traverseStep);
        }

        return ptr;
    }
}