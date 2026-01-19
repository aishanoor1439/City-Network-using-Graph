using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNetworkUsingGraph
{
    public class Graph
    {
        int[,] adjMatrix;
        string[] cities;
        bool[] visited;
        int cityCount;

    public Graph(int size)
        {
            cityCount = size;
            adjMatrix = new int[size, size];
            cities = new string[size];
            visited = new bool[size];
        }
        public void AddCity(int index, string name)
        {
            cities[index] = name;
        }
        public void AddRoad(int city1, int city2)
        {
            adjMatrix[city1, city2] = 1;
            adjMatrix[city2, city1] = 1;
        }

    public void BFS(int start)
        {
            int[] queue = new int[cityCount];
            int front = 0, rear = 0;

            visited[start] = true;
            queue[rear++] = start;

            Console.WriteLine("Cities reachable from " + cities[start] + ":");

            while (front < rear)
            {
                int current = queue[front++];
                Console.WriteLine(cities[current]);

                for(int i = 0; i < cityCount; i++)
                {
                    if (adjMatrix[current, i] == 1 && visited[i] == false)
                    {
                        visited[i] = true;
                        queue[rear++] = i;
                    }
                }
            }
        }
}
}
