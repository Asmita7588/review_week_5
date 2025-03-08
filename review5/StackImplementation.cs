using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review5
{
    public class StackImplementation<T>
    {
        public class Node
        {
            public T Data;
             public Node next;

             public Node(T data)
             {
                 Data = data;
                 next = null;
             }
        }

   
        Node Top;
        int count;

        public StackImplementation()
        {
            Top = null;
            count =  0;
        }

        public void Push(T data)
        {
            Node newNode = new Node(data);
            newNode.next = Top;
            Top = newNode;
            count++;
            
        }
        public T Pop() {

            if (count < 0)
            {
                Console.WriteLine("list is emplty can not pop up element from list");
            }
                T data = Top.Data;
                Top = Top.next;
                count--;
                
            
            return data;
        }

        public T Peek()
        {
            if (count < 0)
            {
                Console.WriteLine("list is emplty can not pop up element from list");
               
            }
            return Top.Data;
        }
    }
}
