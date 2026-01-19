using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNetworkUsingGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);

            g.AddCity(0, "Karachi");
            g.AddCity(1, "Lahore");
            g.AddCity(2, "Islamabad");
            g.AddCity(3, "Quetta");
            g.AddCity(4, "Peshawar");

            g.AddRoad(0, 1);
            g.AddRoad(1, 2);
            g.AddRoad(2, 4);
            g.AddRoad(1, 3);

            g.BFS(0);
        }
    }
}
