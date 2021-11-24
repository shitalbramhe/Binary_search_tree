using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarysearchtree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary<int> bst = new Binary<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            Console.WriteLine("Binary Search Tree ");
            bst.Display();
            Console.ReadLine();
        }
    }
}