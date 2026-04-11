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
    public partial class BFS_F : Form
    {
        private Menu_F menu;
        private Graph G;
        public BFS_F(Menu_F parent, Graph graph)
        {
            InitializeComponent();
            menu = parent;
            G = graph;

            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            Towns_CB.Items.Clear();
            Towns_CB.Items.AddRange(G.GetTowns().ToArray());
            Towns_CB.SelectedIndex = 0;
        }
        private void ComponentsShow_B_Click_1(object sender, EventArgs e)
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
            BFS_Result_L.Text = components[..^4] + '.';
            MessageBox.Show($"В графе {CountComps} компонент(а) связности!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Check_B_Click(object sender, EventArgs e)
        {
            string from = StartV_TB.Text, to = EndV_TB.Text;
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to)) return;

            bool isReachable;
            try
            {
                isReachable = G.IsReachable(from, to);
            }
            catch (InvalidDataException)
            {
                MessageBox.Show($"Указан неизвестный город(а)!", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isReachable)
            {
                MessageBox.Show($"{to} достижим(а) из города {from}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var way = G.GetWay(from, to);
                BFS_Result_L.Text = string.Empty;
                for (int i = 0; i < way.Count; i++)
                {
                    if (i != way.Count - 1)
                        BFS_Result_L.Text += way[i] + " → ";
                    else
                        BFS_Result_L.Text += way[i];
                }
            }
            else
            {
                MessageBox.Show($"{to} не достижим(а) из города {from} :(", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StartDFS_B_Click(object sender, EventArgs e)
        {
            var selectedStartTown = Towns_CB.SelectedItem?.ToString();
            var way = G.BFS(selectedStartTown);

            string wayToPrint = string.Empty;
            foreach (var node in way) wayToPrint += node + ", ";
            BFS_Result_L.Text = wayToPrint[..^2] + '.';
        }

        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void BFS_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}
