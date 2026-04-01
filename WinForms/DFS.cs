using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class DFS_F : Form
    {
        private MenuF menu;
        private Graph G;
        public DFS_F(MenuF parent, Graph graph)
        {
            InitializeComponent();
            menu = parent;
            G = graph;

            InitializeComboBox();
        }
        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void StartDFS_B_Click(object sender, EventArgs e)
        {
            var selectedStartTown = Towns_CB.SelectedItem?.ToString();
            var way = G.DFS(selectedStartTown);

            string wayToPrint = string.Empty;
            foreach (var node in way) wayToPrint += node + ", ";
            DFS_Result_L.Text = wayToPrint[..^2] + '.';
        }

        private void ComponentsShow_B_Click(object sender, EventArgs e)
        {
            List<List<string>> comps = G.FindComponents();
            int CountComps = comps.Count;

            string components = string.Empty;
            for (int i = 0; i < CountComps; i++)
            {
                components += $"{i + 1} компонента: ";
                foreach (string V in comps[i]) components += V + ", ";
                components += "\n\n";
            }
            DFS_Result_L.Text = components[..^4] + '.';
            MessageBox.Show($"В графе {CountComps} компонент(а) связности!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InitializeComboBox()
        {
            Towns_CB.Items.Clear();
            Towns_CB.Items.AddRange(G.GetTowns().ToArray());
            Towns_CB.SelectedIndex = 0;
        }

        private void DFS_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}
