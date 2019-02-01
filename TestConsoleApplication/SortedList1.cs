using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class SortedList1
    {
        static void Main(string[] args)
        {
            SortedList sortedList1 = new SortedList();
            sortedList1.Add("one", 1);
            sortedList1.Add("two", 2);
            sortedList1.Add("three", 3);
            sortedList1.Add("four", 4);

            sortedList1.Remove("one");//removes element whose key is 'one'
            sortedList1.RemoveAt(0);//removes element at zero index i.e first element: four

            foreach (DictionaryEntry kvp in sortedList1)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
            foreach (var item in myStack)
            {
                Console.WriteLine("value {0} ",item);
            }
            Console.WriteLine("Peek value {0} ", myStack.Peek());
            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop());
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
   
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");
            foreach (var item in queue)
            {
                Console.WriteLine("value {0} ", item);
            }
            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);
            Console.ReadKey();
        }
    }
}
