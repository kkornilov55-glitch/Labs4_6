namespace ClassLibrary
{
    public class Graph
    {
        //Список смежности
        public Dictionary<string, List<Edge>> adjacencyList = new Dictionary<string, List<Edge>>();
        public Dictionary<string, string> parent { get; private set; } = new Dictionary<string, string>(); 
        private Dictionary<string, Colour> colour = new Dictionary<string, Colour>();
        private enum Colour { White, Gray, Black }
        private const int INF = int.MaxValue;

        /// <summary>
        /// Метод для чтения графа из файла на выбор, необходим перед началом работы с классом.
        /// </summary>
        public void ReadGraph(string filePath)
        {
            //if (filePath.ToLower() != "*.txt") throw new InvalidDataException("Выбран не текстовый файл");
            StreamReader F = new StreamReader(filePath);

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
        /// <summary>
        /// Метод, для нахождения всех компонент.
        /// </summary>
        /// <returns>Список списков вершин в каждой компоненте</returns>
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
            foreach (var V in adjacencyList.Keys)
            {
                colour[V] = Colour.White;
            }
            parent.Clear();
        }
        /// <summary>
        /// Поиск в глубину (DFS)
        /// </summary>
        /// <param name="startV">Начальная вершина</param>
        /// <returns>Список достижимых вершин из переданной методу</returns>
        /// <exception cref="InvalidDataException">Ошибка, несуществующая вершина</exception>
        public List<string> DFS(string startV)
        {
            if (!adjacencyList.ContainsKey(startV))
                throw new InvalidDataException("В текущем графе не существует города с таким названием");
            if (adjacencyList[startV] == null)
                throw new InvalidOperationException("Перед запуском алгоритма, необходимо выбрать стартовый город");

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
        /// <summary>
        /// Поиск в ширину (BFS)
        /// </summary>
        /// <param name="startV">Начальная вершина</param>
        /// <returns>Список достижимых вершин из переданной методу</returns>
        /// <exception cref="InvalidDataException">Ошибка, несуществующая вершина</exception>
        public List<string> BFS(string startV)
        {
            if (!adjacencyList.ContainsKey(startV))
                throw new InvalidDataException("В текущем графе не существует города с таким названием");

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
        /// <summary>
        /// Метод, для проверки достижимости вершины finishV из startV
        /// </summary>
        /// <param name="startV">Начальная вершина</param>
        /// <param name="finishV">Конечная вершина</param>
        /// <returns>Да/нет</returns>
        /// <exception cref="InvalidDataException">Ошибка, несуществующая вершина</exception>
        public bool IsReachable(string startV, string finishV)
        {
            if (!adjacencyList.ContainsKey(startV) || !adjacencyList.ContainsKey(finishV))
                throw new InvalidDataException();

            if (BFS(startV).Contains(finishV))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Метод, для восстановления найденного пути
        /// </summary>
        /// <param name="startV">Начальная вершина</param>
        /// <param name="finishV">Конечная вершина</param>
        /// <returns>Найденный путь (Списком вершин)</returns>
        /// <exception cref="InvalidDataException">Ошибка, несуществующая вершина</exception>
        public List<string> GetWay(string startV, string finishV, out int wayLength)
        {
            if (!adjacencyList.ContainsKey(startV) || !adjacencyList.ContainsKey(finishV))
                throw new InvalidDataException("В текущем графе не существует города с таким названием");

            List<string> way = new List<string>();
            if (finishV == startV)
            {
                wayLength = 0;
                way.Add(startV);
                return way;
            }

            string current = finishV;
            wayLength = 0;
            string prew = null;
            while (current != null)
            {
                way.Add(current);
                if (current == startV || !parent.ContainsKey(current)) break;
                prew = current;
                current = parent[current];
                foreach (Edge E in adjacencyList[current])
                {
                    if (E.To == prew)
                    {
                        wayLength += E.Weight;
                        break;
                    }
                }
            }
            
            way.Reverse();
            return way;
        }
        public List<string> GetWay(string startV, string finishV)
        {
            if (!adjacencyList.ContainsKey(startV) || !adjacencyList.ContainsKey(finishV))
                throw new InvalidDataException("В текущем графе не существует города с таким названием");

            List<string> way = new List<string>();
            if (finishV == startV)
                return null;

            string current = finishV;
            string prew = null;
            while (current != null)
            {
                way.Add(current);
                if (current == startV || !parent.ContainsKey(current)) break;
                current = parent[current];
            }

            way.Reverse();
            return way;
        }
        public List<string> GetTowns()
        {
            var towns = new List<string>();
            foreach (string t in adjacencyList.Keys) towns.Add(t);
            return towns;

        }
        public void Dijkstra(string startV)
        {
            if (!adjacencyList.ContainsKey(startV))
                throw new InvalidDataException("В текущем графе не существует города с таким названием");

            Dictionary<string, int> Distance = new Dictionary<string, int>();
            Dictionary<string, bool> Visited = new Dictionary<string, bool>();
            foreach (string V in adjacencyList.Keys)
            {
                Distance[V] = INF;
                Visited[V] = false;
            }
            Distance[startV] = 0;

            int MinD;
            do
            {
                MinD = INF;
                string MinV = null;
                foreach (string V in adjacencyList.Keys)
                {
                    if (Distance[V] < MinD && !Visited[V])
                    {
                        MinD = Distance[V];
                        MinV = V;
                    }
                }
                if (MinV == null) break;
                foreach (Edge E in adjacencyList[MinV])
                {
                    if (!Visited[E.To])
                    {
                        int newDist = Distance[MinV] + E.Weight;
                        if (newDist < Distance[E.To])
                        {
                            Distance[E.To] = newDist;
                            parent[E.To] = MinV;
                        }
                    }
                }
                Visited[MinV] = true;
            } while (MinD < INF);
        }
        //public List<List<string>> GetWays(string startV)
        //{
        //    var ways = new List<List<string>>();

        //    foreach (string V in adjacencyList.Keys)
        //    {
        //        if (startV == V) continue;
        //        ways.Add(GetWay(startV, V));
        //    }

        //    return ways;
        //}

    }
}
