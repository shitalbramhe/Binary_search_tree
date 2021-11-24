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
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            Console.WriteLine("Binary Search Tree ");
            bst.Display();
            bst.Size();
            bool find = bst.search(63, bst);
            Console.ReadLine();
        }
    }
}