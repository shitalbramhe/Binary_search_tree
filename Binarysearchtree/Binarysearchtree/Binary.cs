using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarysearchtree
{
    public class Binary<T> where T : IComparable
    {
        T nodedata;
        public Binary<T> lefttree { get; set; }
        public Binary<T> righttree { get; set; }
        bool result = false;

        public Binary(T nodedata)
        {
            this.nodedata = nodedata;
            this.nodedata = nodedata;
            this.lefttree = null;
            this.righttree = null;
        }
 
        public void Insert(T item)
        {
            T currentnodevalue = this.nodedata;
            if ((currentnodevalue.CompareTo(item)) > 0)
            {
                if (this.lefttree == null)
                    this.lefttree = new Binary<T>(item);
                else
                    this.lefttree.Insert(item);
            }
            else
            {
                if (this.righttree == null)
                    this.righttree = new Binary<T>(item);
                else
                    this.righttree.Insert(item);
            }
        }
          public void Display()
        {
            if (this.lefttree != null)
            {
                this.lefttree.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.righttree != null)
            {
                this.righttree.Display();
            }
        }
    }
}

