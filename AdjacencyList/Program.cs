using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList adjList = new AdjacencyList(5);

            adjList[0] = new Vertex("S");
            adjList[1] = new Vertex("A");
            adjList[2] = new Vertex("B");
            adjList[3] = new Vertex("C");
            adjList[4] = new Vertex("G");
           
            adjList[0].addEdge(1, 1);
            adjList[0].addEdge(2, 4);

            adjList[1].addEdge(2, 2);
            adjList[1].addEdge(3, 5);
            adjList[1].addEdge(4, 12);

            adjList[2].addEdge(3, 2);

            adjList[3].addEdge(4, 3);


            adjList.Display();
            
        }
    }
}
