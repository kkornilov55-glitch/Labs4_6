using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Edge
    {
        public string To;
        public int Weight;

        public Edge(string to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }
}
