namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");
            LinkedList linkedList = new LinkedList();

            linkedList.OrderedLinkedlist(56);
            linkedList.OrderedLinkedlist(30);
            linkedList.OrderedLinkedlist(40);
            linkedList.OrderedLinkedlist(70);
            linkedList.Display();
        }
    }
}