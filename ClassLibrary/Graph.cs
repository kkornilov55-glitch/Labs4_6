namespace ClassLibrary
{
    public class Graph
    {
        public Dictionary<string, List<Edge>> adjacencyList = new Dictionary<string, List<Edge>>();

        public Dictionary<string, string> parent = new Dictionary<string, string>();
        public Dictionary<string, Colour> colour = new Dictionary<string, Colour>();
        public bool cycle = false;
        public enum Colour { White, Gray, Black }

        public void ReadGraph()
        {
            StreamReader F = new StreamReader("river_graph.txt");

            //Считываем матрицу
            string currentString;
            string from, to;
            int weight;
            while (true)
            {
                currentString = F.ReadLine();
                if (string.IsNullOrEmpty(currentString)) break;

                from = currentString.Split()[0];
                to = currentString.Split()[1];
                weight = int.Parse(currentString.Split(';')[2]);

                if (!adjacencyList.ContainsKey(from)) adjacencyList[from] = new List<Edge>();
                else adjacencyList[from].Add(new Edge(to, weight));
            }

            F.Close();
        }
        public List<List<string>> FindComponents()
        {
            //Список спписков вершин в каждой компоненте
            List<List<string>> components = new List<List<string>>();
            InitColours();

            foreach (var V in adjacencyList.Keys) //Для всех вершин
            {
                //Если была не посещена
                if (colour[V] == Colour.White)
                {
                    //Новая компонента
                    List<string> component = new List<string>();
                    DFS_Recursive(V, component);
                    components.Add(component);
                }
            }

            return components;
                
            
        }
        private void InitColours()
        {
            foreach(var V in adjacencyList.Keys)
            {
                colour[V] = Colour.White;
            }
            parent.Clear();
        }
        public List<string> DFS(string startV)
        {
            InitColours();
            parent[startV] = null;

            var way = new List<string>();
            DFS_Recursive(startV, way);

            return way;
        }
        private void DFS_Recursive(string V, List<string> way)
        {
            colour[V] = Colour.Gray;
            way.Add(V);

            foreach (Edge E in adjacencyList[V])
            {
                string neighbor = E.To;

                if (neighbor != null)
                {
                    if (colour[neighbor] == Colour.White)
                    {
                        parent[neighbor] = V;
                        DFS_Recursive(neighbor, way);
                    }
                }
            }
            colour[V] = Colour.Black;
        }
    }
}
