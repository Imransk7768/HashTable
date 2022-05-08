using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
            string words = "to be or not to be";
            string[] arr = words.Split(' ');
            LinkedList<string> checkForDuplication = new LinkedList<string>();
            foreach (string element in arr)
            {
                int count = 0;
                foreach (string match in arr)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplication.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplication.Contains(element))
                {
                    checkForDuplication.AddLast(element);
                    hash.Add(element, count);
                }
            }
            hash.Display();
        }
    }
}