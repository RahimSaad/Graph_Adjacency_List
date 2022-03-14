using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList
{

    class AdjacencyList
    {
        public Vertex[] xList;

        public Vertex this [int idx]
        {
            get => xList[idx];
            set => xList[idx] = value;
        }

        public AdjacencyList(int NumberOfNodes)
        {
            this.xList = new Vertex[NumberOfNodes];
        }
        
        public void addVertex(int idx , Vertex vertex)
        {
            this.xList[idx] = vertex;
        }
        public Vertex getVertex(int idx)
        {
            return this.xList[idx];
        }

        internal void Display()
        {
            foreach(Vertex v in xList)
            {
                Console.Write("Name : {0}  Neighbours =  ", v.Name);
                v.Neighbours.Display();        
            }
        }
    }



    class Vertex
    {
        public string Name;
        public SLL_Queue<Edge> Neighbours;

        public Vertex(string name)
        {
            this.Name = name;
            Neighbours = new SLL_Queue<Edge>();
        }

        public void addEdge(int idx , int weight)
        {
            Neighbours.addNode(new Edge(idx, weight));
        }
        
    }



    class Edge
    {
        public int idx, weight;

        public Edge(int idx, int weight)
        {
            this.idx = idx;
            this.weight = weight;
        }

        public override string ToString()
        {
            return idx.ToString();
        }

    }


    class SLL_Node<T>
    {
        T xValue;
        SLL_Node<T> next;
        public T Value { get => xValue; set => xValue = value; }
        public SLL_Node<T> Next { get => next; set => next = value; }

        public SLL_Node(T value, SLL_Node<T> next)
        {
            this.xValue = value;
            this.next = next;
        }
    }
    
    class SLL_Queue<T>
    {
        SLL_Node<T> head;
        SLL_Node<T> tail;
        int size;
        public SLL_Node<T> Head { get => head; }
        public SLL_Node<T> Tail { get => tail; }
        public int Size { get => size; }

        public SLL_Queue()
        {
            this.size = 0;
        }

        public void addNode(SLL_Node<T> node)
        {
            if (head == null) { head = node; tail = node; }
            else
            {
                tail.Next = node;
                tail = node;
            }
            this.size++;
        }

        public void addNode(T value)
        {
            SLL_Node<T> node = new SLL_Node<T>(value, null);
            if (head == null) { head = node; tail = node; }
            else
            {
                tail.Next = node;
                tail = node;
            }
            this.size++;
        }

        public void addAllNode(SLL_Queue<T> list)
        {
            if (head == null)
            {
                head = list.Head;
                tail = list.Tail;
            }
            else
            {
                tail.Next = list.Head;
                tail = list.Tail;
            }
            this.size += list.Size;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        // u have to check if the list is empty or not before using poll method
        public T poll()
        {
            if (this.isEmpty()) { throw new Exception("list is empty"); }
            T tmp = head.Value;
            head = head.Next;
            this.size--;
            return tmp;

        }

        public void Display()
        {
            SLL_Node<T> ptr = head;
            while (ptr != null)
            {
                Console.Write("  {0}  ", ptr.Value);
                ptr = ptr.Next;
            }
            Console.Write("\n");
        }

    }



}
