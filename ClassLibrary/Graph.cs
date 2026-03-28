namespace ClassLibrary
{
    public class Graph
    {
        //Список смежности
        public Dictionary<string, List<Edge>> adjacencyList = new Dictionary<string, List<Edge>>();


        public Dictionary<string, string> parent = new Dictionary<string, string>();
        public Dictionary<string, Colour> colour = new Dictionary<string, Colour>();
        public enum Colour { White, Gray, Black }   

        public void ReadGraph()
        {
            StreamReader F = new StreamReader("river_graph.txt");

            //Считываем граф по строкам
            string currentString;
            string from, to;
            int weight;
            while (true)
            {
                currentString = F.ReadLine();
                if (string.IsNullOrEmpty(currentString)) break;

                from = currentString.Split(';')[0];
                to = currentString.Split(';')[1];
                weight = int.Parse(currentString.Split(';')[2]);

                if (!adjacencyList.ContainsKey(from)) adjacencyList[from] = new List<Edge>();
                if (!adjacencyList.ContainsKey(to)) adjacencyList[to] = new List<Edge>();
                adjacencyList[from].Add(new Edge(to, weight));
                adjacencyList[to].Add(new Edge(from, weight));
            }

            F.Close();
        }
        public List<List<string>> FindComponents()
        {
            //Список списков вершин в каждой компоненте
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
            if (!adjacencyList.ContainsKey(startV)) throw new InvalidDataException("В текущем графе не существует города с таким названием"); ;

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
        public List<string> BFS(string startV)
        {
            if (!adjacencyList.ContainsKey(startV)) throw new InvalidDataException("В текущем графе не существует города с таким названием"); ;

            InitColours();
            parent.Clear();
            Queue<string> q = new Queue<string>();
            List<string> way = new List<string>();

            q.Enqueue(startV);
            colour[startV] = Colour.Gray;
            parent[startV] = null;

            while (q.Count != 0)
            {
                string current = q.Dequeue();
                way.Add(current);
                
                foreach (Edge E in adjacencyList[current])
                {
                    string neighbor = E.To;
                    if (neighbor != null && colour[neighbor] == Colour.White)
                    {
                        q.Enqueue(neighbor);
                        colour[neighbor] = Colour.Gray;
                        parent[neighbor] = current;
                    }
                }
                colour[current] = Colour.Black;
            }

            return way;
        }
        public bool IsReachable(string startV, string finishV)
        {
            if (!adjacencyList.ContainsKey(startV) || !adjacencyList.ContainsKey(finishV)) throw new InvalidDataException("В текущем графе не существует города с таким названием");

            if (BFS(startV).Contains(finishV)) 
                return true;
            else
                return false;
        }
        public List<string> GetPath(string startV, string finishV)
        {

        }
    }
}
