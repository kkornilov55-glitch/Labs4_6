using ClassLibrary;

namespace WinForms
{
    public partial class Menu_F : Form
    {
        private Graph G = new Graph();
        private Form DFS_F;
        private Form BFS_F;
        private Form Info_F;
        private Form Dijkstra_F;

        public Menu_F()
        {
            InitializeComponent();
            ReadGraph_GB.Location = new Point(280, 109);
        }

        private void ReadGraphB_Click(object sender, EventArgs e)
        {
            try
            {
                G.ReadGraph();
            }
            catch
            {
                MessageBox.Show("Ошибка, файл с графом не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Граф успешно прочитан!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadGraph_GB.Location = new Point(6, 109);
            DFS_GB.Visible = true;
            BFS_GB.Visible = true;
            Dijekstra_GB.Visible = true;
            MOD_GB.Visible = true;
        }
        private void DFS_B_Click(object sender, EventArgs e)
        {
            if (G == null) return;

            if (DFS_F == null) DFS_F = new DFS_F(this, G);
            DFS_F.StartPosition = FormStartPosition.Manual;
            DFS_F.Location = this.Location;

            this.Hide();
            DFS_F.Show();
        }

        private void BFS_B_Click(object sender, EventArgs e)
        {
            if (G == null) return;

            if (BFS_F == null) BFS_F = new BFS_F(this, G);
            BFS_F.StartPosition = FormStartPosition.Manual;
            BFS_F.Location = this.Location;

            this.Hide();
            BFS_F.Show();
        }

        private void TaskInfo_B_Click(object sender, EventArgs e)
        {
            if (Info_F == null) Info_F = new Info_F(this);
            Info_F.StartPosition = FormStartPosition.Manual;
            Info_F.Location = this.Location;

            this.Hide();
            Info_F.Show();
        }

        private void Dijkstra_B_Click(object sender, EventArgs e)
        {
            if (G == null) return;

            if (Dijkstra_F == null) Dijkstra_F = new DijkstraF(this, G);
            Dijkstra_F.StartPosition = FormStartPosition.Manual;
            Dijkstra_F.Location = this.Location;

            this.Hide();
            Dijkstra_F.Show();
        }
    }
}
