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
    public partial class MOD_F : Form
    {
        private Menu_F menu;
        private Graph G;
        public MOD_F(Menu_F parent, Graph graph)
        {
            InitializeComponent();
            menu = parent;
            G = graph;
        }

        private void StartMOD_B_Click(object sender, EventArgs e)
        {
            try
            {
                var (edges, totalWeight) = G.PrimMST();

                StringBuilder result = new StringBuilder();
                result.AppendLine($"Суммарый вес дерева: {totalWeight} км\n");
                result.AppendLine("Рёбра остовного дерева:");

                result.Append(edges[0].From);
                foreach (var edge in edges)
                    result.Append($" → {edge.To}  ({edge.Weight} км)");

                Result_L.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void MOD_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}
