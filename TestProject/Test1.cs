using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class GraphTests
    {
        private Graph graph;

        [TestInitialize]
        public void Setup()
        {
            graph = new Graph();
            // Файл уже скопирован в выходную папку благодаря настройкам проекта
            graph.ReadGraph("river_graph.txt");
        }

        [TestMethod]
        public void GetTowns_ShouldReturnAllVertices()
        {
            var towns = graph.GetTowns();
            Assert.AreEqual(6, towns.Count);
            CollectionAssert.AreEquivalent(new[] { "A", "B", "C", "D", "E", "F" }, towns);
        }

        [TestMethod]
        public void DFS_ShouldReturnAllReachableVertices()
        {
            var result = graph.DFS("A");
            Assert.AreEqual(4, result.Count);
            CollectionAssert.AreEquivalent(new[] { "A", "B", "C", "D" }, result);
        }

        [TestMethod]
        public void BFS_ShouldReturnAllReachableVertices()
        {
            var result = graph.BFS("A");
            Assert.AreEqual(4, result.Count);
            CollectionAssert.AreEquivalent(new[] { "A", "B", "C", "D" }, result);
        }

        [TestMethod]
        public void DFS_InvalidVertex_ShouldThrowInvalidDataException()
        {
            bool correctResult = false;
            try
            {
                graph.DFS("NonExistent");
            }
            catch (InvalidDataException)
            {
                correctResult = true;
            }
            catch
            {
                correctResult = false;
            }

            Assert.IsTrue(correctResult);
        }

        [TestMethod]
        public void FindComponents_ShouldReturnCorrectDisconnectedComponents()
        {
            var components = graph.FindComponents();
            Assert.AreEqual(2, components.Count);

            var compA = components.FirstOrDefault(c => c.Contains("A"));
            var compE = components.FirstOrDefault(c => c.Contains("E"));

            CollectionAssert.AreEquivalent(new[] { "A", "B", "C", "D" }, compA);
            CollectionAssert.AreEquivalent(new[] { "E", "F" }, compE);
        }

        [TestMethod]
        public void IsReachable_WhenConnected_ShouldReturnTrue()
        {
            Assert.IsTrue(graph.IsReachable("A", "D"));
        }

        [TestMethod]
        public void IsReachable_WhenDisconnected_ShouldReturnFalse()
        {
            Assert.IsFalse(graph.IsReachable("A", "E"));
        }

        [TestMethod]
        public void GetWay_ShouldReturnCorrectPath()
        {
            graph.BFS("A"); // Инициализирует словарь parent
            var path = graph.GetWay("A", "D");

            Assert.IsNotNull(path);
            Assert.AreEqual(4, path.Count);
            Assert.AreEqual("A", path[0]);
            Assert.AreEqual("B", path[1]);
            Assert.AreEqual("C", path[2]);
            Assert.AreEqual("D", path[3]);
        }

        [TestMethod]
        public void GetWay_WhenStartEqualsFinish_ShouldReturnNull()
        {
            graph.BFS("A");
            Assert.IsNull(graph.GetWay("A", "A"));
        }

        [TestMethod]
        public void GetWay_InvalidVertex_ShouldThrowInvalidDataException()
        {
            bool correctResult = false;
            try
            {
                graph.GetWay("A", "Z");
            }
            catch (InvalidDataException)
            {
                correctResult = true;
            }
            catch
            {
                correctResult = false;
            }

            Assert.IsTrue(correctResult);
        }
        [TestMethod]
        public void Dijkstra_ShouldCalculateCorrectTotalDistance()
        {
            // Путь A -> B (10) -> C (20) -> D (30)
            graph.Dijkstra("A");
            var path = graph.GetWay("A", "D", out int distance);

            Assert.IsNotNull(path);
            Assert.AreEqual(60, distance); // 10 + 20 + 30
        }
        [TestMethod]
        public void GetWay_ShouldReturnCorrectPathAndWeightForMidPoint()
        {
            graph.Dijkstra("A");
            List<string> path = graph.GetWay("A", "C", out int totalWeight);

            // Ожидаем путь A, B, C
            Assert.AreEqual(3, path.Count);
            CollectionAssert.AreEqual(new[] { "A", "B", "C" }, path);
            // Ожидаем вес 10 + 20 = 30
            Assert.AreEqual(30, totalWeight);
        }
        [TestMethod]
        public void GetWay_ToDisconnectedComponent_ShouldReturnNull()
        {
            graph.Dijkstra("A");
            var path = graph.GetWay("A", "E", out int distance);

            Assert.IsNull(path);
            Assert.IsTrue(distance >= 1000000, "Расстояние до недостижимой вершины должно быть INF");
        }
        [TestMethod]
        public void Dijkstra_InSmallComponent_ShouldWork()
        {
            // Путь E -> F с весом 40
            graph.Dijkstra("E");
            graph.GetWay("E", "F", out int distance);

            Assert.AreEqual(40, distance);
        }
    }

    [TestClass]
    public class EdgeTests
    {
        [TestMethod]
        public void Edge_Constructor_ShouldInitializeProperties()
        {
            var edge = new Edge("CityB", 150);
            Assert.AreEqual("CityB", edge.To);
            Assert.AreEqual(150, edge.Weight);
        }
    }
}
