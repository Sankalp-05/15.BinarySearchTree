using BinarySearchTree;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Program ");
            Console.WriteLine("\n1. Create Binary Search Tree byadding 56 and then adding 30 & 70");
            Console.WriteLine("2. Create binary tree as show in the figure also show size");
            Console.WriteLine("3. Search 63 in the Binary Search Tree");
            Console.Write("Enter your choice : ");
            int option = Convert.ToInt32(Console.ReadLine());
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            switch (option)
            {
                case 1:
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Display();
                    break;
                case 2:
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Insert(22);
                    binarySearch.Insert(40);
                    binarySearch.Insert(60);
                    binarySearch.Insert(95);
                    binarySearch.Insert(11);
                    binarySearch.Insert(65);
                    binarySearch.Insert(3);
                    binarySearch.Insert(16);
                    binarySearch.Insert(63);
                    binarySearch.Insert(67);
                    Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
                    binarySearch.Display();
                    binarySearch.GetSize();
                    break;
                case 3:
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Insert(22);
                    binarySearch.Insert(40);
                    binarySearch.Insert(60);
                    binarySearch.Insert(95);
                    binarySearch.Insert(11);
                    binarySearch.Insert(65);
                    binarySearch.Insert(3);
                    binarySearch.Insert(16);
                    binarySearch.Insert(63);
                    binarySearch.Insert(67);
                    Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
                    binarySearch.Display();
                    binarySearch.GetSize();
                    bool result = binarySearch.IfExists(63, binarySearch);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}