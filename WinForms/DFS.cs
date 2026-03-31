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
    public partial class DFS : Form
    {
        private MenuF menu;
        private Graph G;
        public DFS(MenuF parent, Graph graph)
        {
            InitializeComponent();
            menu = parent;
            G = graph;
        }
        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
