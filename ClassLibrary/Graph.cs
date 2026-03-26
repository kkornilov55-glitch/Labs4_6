namespace ClassLibrary
{
    public class Graph
    {
        public Dictionary<string, List<Edge>> adjacencyList = new Dictionary<string, List<Edge>>();
        public Dictionary<string, string> parent = new Dictionary<string, string>();
        public Dictionary<string, Colour> colour = new Dictionary<string, Colour>();
        public enum Colour { White, Gray, Black }
        public void ReadGraph()
        {
            StreamReader F = new StreamReader("river_graph.txt");

            //Считываем матрицу
            string currentString;
            string vertexStart, vertexFinish;
            int weight;
            while (true)
            {
                currentString = F.ReadLine();
                if (string.IsNullOrEmpty(currentString)) break;

                vertexStart = currentString.Split()[0];
                vertexFinish = currentString.Split()[1];
                weight = int.Parse(currentString.Split()[2]);

                if (!adjacencyList.ContainsKey(vertexStart)) adjacencyList[vertexStart] = new List<Edge>();
                else adjacencyList[vertexStart].Add(new Edge(vertexFinish, weight));
            }
            foreach (var edge in adjacencyList.Keys)
            {
                colour.Add(edge, Colour.White);
            }
        }
        public void DFS()
        {
            
        }

    }
}
