using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class DijkstraF : Form
    {
        private Form menu;
        private Graph G;

        public DijkstraF(Form parent, Graph graph)
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
            Towns_CB.Items.Clear();
            Towns_CB.Items.AddRange(G.GetTowns().ToArray());
            Towns_CB.SelectedIndex = 0;
        }
    }
}
