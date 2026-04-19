using ClassLibrary;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class Dijkstra_F : Form
    {
        private Form menu;
        private Graph G;

        public Dijkstra_F(Form parent, Graph graph)
        {
            InitializeComponent();
            menu = parent;
            G = graph;

            InitializeComboBox();
        }

        private void DijkstraF_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }

        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
        private void InitializeComboBox()
        {
            From_CB.Items.Clear();
            From_CB.Items.AddRange(G.GetTowns().ToArray());
            From_CB.SelectedIndex = 0;

            To_CB.Items.Clear();
            To_CB.Items.AddRange(G.GetTowns().ToArray());
            To_CB.SelectedIndex = 1;
        }

        private void StartDijkstra_B_Click(object sender, EventArgs e)
        {
            var from = From_CB.SelectedItem?.ToString();
            var to = To_CB.SelectedItem?.ToString();

            // Создаем буфер для логов
            StringBuilder sb = new StringBuilder();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Вызываем алгоритм, передавая буфер
            G.Dijkstra(from, sb);

            timer.Stop();
            MessageBox.Show($"Время выполнения алгоритма: {timer.ElapsedMilliseconds} мс");

            try
            {
                List<string> way = G.GetWay(from, to, out int wayLength);

                Dijkstra_Result_L.Text = string.Join(" -> ", way);
                WayLength_L.Text = $"{wayLength} км";

                string filePath = "Dijkstra_Log.txt"; // Имя файла
                File.WriteAllText(filePath, sb.ToString()); // Записать текст
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true }); // Открыть файл в блокноте
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
