using System.Diagnostics;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinForms
{
    public partial class ArticulationPoints_F : Form
    {
        private Menu_F menu;
        private Graph G;
        public ArticulationPoints_F(Menu_F parent, Graph graph)
        {
            InitializeComponent();
            menu = parent;
            G = graph;
        }

        //private void StartArticulationPoints_B_Click(object sender, EventArgs e)
        //{
        //    Stopwatch timer = new Stopwatch();
        //    timer.Start();
        //    var points = G.FindArticulationPoints();
        //    timer.Stop();
        //    MessageBox.Show($"Время выполнения алгоритма: {timer.ElapsedMilliseconds} мс");

        //    if (points.Count == 0)
        //        Result_L.Text = "Граф не имеет точек сочленения";
        //    else
        //        Result_L.Text = "Точки сочленения:\n" + string.Join(" , ", points);
        //}

        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void ArticulationPoints_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}
