using System.Text;

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
            if (way[0] != startV)
            {
                wayLength = INF;
                return null;
            }
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

        public void Dijkstra(string startV, System.Text.StringBuilder sb = null)
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
            parent[startV] = null;

            // Заголовок лога
            if (sb != null)
            {
                sb.AppendLine("=== АЛГОРИТМ ДЕЙКСТРЫ ===");
                sb.AppendLine($"Начальная вершина: {startV}\n");
            }

            var pq = new PriorityQueue<string, int>();
            pq.Enqueue(startV, 0);

            while (pq.Count > 0)
            {
                string MinV = pq.Dequeue();

                // Если вершина уже обработана, пропускаем
                if (Visited[MinV])
                {
                    if (sb != null) sb.AppendLine($"Шаг: Вершина {MinV} уже посещена (пропуск)");
                    continue;
                }
                Visited[MinV] = true;

                if (sb != null) sb.AppendLine($">>> Обрабатываем вершину {MinV} (текущее расстояние = {Distance[MinV]})");

                foreach (Edge E in adjacencyList[MinV])
                {
                    string neighbor = E.To;

                    if (!Visited[neighbor])
                    {
                        int newDist = Distance[MinV] + E.Weight;

                        if (sb != null) sb.AppendLine($" -> Сосед {neighbor}: путь через {MinV} = {Distance[MinV]} + {E.Weight} = {newDist}");

                        if (newDist < Distance[neighbor])
                        {
                            Distance[neighbor] = newDist;
                            parent[neighbor] = MinV;
                            pq.Enqueue(neighbor, newDist);

                            if (sb != null) sb.AppendLine($"ОБНОВЛЕНО: расстояние до {neighbor} уменьшено до {newDist}");
                        }
                        else
                        {
                            if (sb != null) sb.AppendLine($"Пропуск: текущее расстояние ({Distance[neighbor]}) лучше");
                        }
                    }
                }
                if (sb != null) sb.AppendLine("");
            }
        }
        /// <summary>
        /// Построение минимального остовного дерева алгоритмом Прима (с логом)
        /// </summary>
        public (List<(string From, string To, int Weight)> mstEdges, int totalWeight, string log) PrimMST(StringBuilder log = null)
        {
            if (log != null) log.AppendLine("=== АЛГОРИТМ ПРИМА ===\n");

            if (adjacencyList.Count == 0)
                return (new List<(string, string, int)>(), 0, "");

            var mstEdges = new List<(string, string, int)>();
            var visited = new HashSet<string>();
            var pq = new PriorityQueue<(string from, string to, int weight), int>();

            int totalWeight = 0;
            string start = adjacencyList.Keys.First();
            visited.Add(start);

            if (log != null) log.AppendLine($"1. Начинаем с вершины: {start}");

            foreach (var edge in adjacencyList[start])
                pq.Enqueue((start, edge.To, edge.Weight), edge.Weight);

            int step = 1;
            while (pq.Count > 0 && visited.Count < adjacencyList.Count)
            {
                var (from, to, weight) = pq.Dequeue();

                if (visited.Contains(to))
                {
                    if (log != null) log.AppendLine($"   Шаг {step}: {from}→{to} ({weight}) - ПРОПУСК (вершина уже в дереве)");
                    step++;
                    continue;
                }

                if (log != null)
                {
                    log.AppendLine($"   Шаг {step}: {from}→{to} ({weight}) - ДОБАВЛЕНО");
                    log.AppendLine($"          Вершины в дереве: {string.Join(", ", visited)} → {to}");
                }

                visited.Add(to);
                mstEdges.Add((from, to, weight));
                totalWeight += weight;

                foreach (var edge in adjacencyList[to])
                {
                    if (!visited.Contains(edge.To))
                        pq.Enqueue((to, edge.To, edge.Weight), edge.Weight);
                }

                step++;
            }

            if (log != null) log.AppendLine($"\nИТОГО: вес = {totalWeight}");

            return (mstEdges, totalWeight, log?.ToString() ?? "");
        }

        /// <summary>
        /// Поиск всех точек сочленения (с логом)
        /// </summary>
        public (List<string> points, string log) FindArticulationPoints(StringBuilder sb = null)
        {
            if (sb != null) sb.AppendLine("=== ТОЧКИ СОЧЛЕНЕНИЯ ===\n");

            List<string> articulationPoints = new List<string>();
            Dictionary<string, int> tin = new Dictionary<string, int>();
            Dictionary<string, int> low = new Dictionary<string, int>();
            Dictionary<string, string> parent = new Dictionary<string, string>();
            int timer = 0;

            foreach (var vertex in adjacencyList.Keys)
            {
                if (!tin.ContainsKey(vertex))
                {
                    if (sb != null) sb.AppendLine($"Запуск поиска с вершины: {vertex}\n");
                    DFS_Articulation(vertex, null, ref timer, tin, low, parent, articulationPoints, sb);
                }
            }

            return (articulationPoints, sb?.ToString() ?? "");
        }

        private void DFS_Articulation(string u, string p, ref int timer,
                                      Dictionary<string, int> tin, Dictionary<string, int> low,
                                      Dictionary<string, string> parentDict, List<string> ap,
                                      StringBuilder sb = null)
        {
            tin[u] = low[u] = timer++;
            int children = 0;

            if (sb != null) sb.Append($" → {u}");

            foreach (var edge in adjacencyList[u])
            {
                string v = edge.To;

                if (v == p) continue;

                if (tin.ContainsKey(v))
                {
                    // Обратное ребро
                    low[u] = Math.Min(low[u], tin[v]);
                }
                else
                {
                    children++;
                    parentDict[v] = u;
                    DFS_Articulation(v, u, ref timer, tin, low, parentDict, ap, sb);

                    low[u] = Math.Min(low[u], low[v]);

                    // Проверка на точку сочленения
                    if (p != null && low[v] >= tin[u] && !ap.Contains(u))
                    {
                        if (sb != null) sb.Append($"\n !!! {u} - ТОЧКА СОЧЛЕНЕНИЯ (разрывает связь с городом \"{v}\")");
                        ap.Add(u);
                    }
                }
            }

            // Проверка для корня
            if (p == null && children > 1 && !ap.Contains(u))
            {
                if (sb != null) sb.Append($"\n !!! {u} - ТОЧКА СОЧЛЕНЕНИЯ (корень с {children} поддеревьями)");
                ap.Add(u);
            }
        }
    }
}
