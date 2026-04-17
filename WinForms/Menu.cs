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
        private Form MOD_F;
        private Form ArticulationPoints_F;

        public Menu_F()
        {
            InitializeComponent();
            //ReadGraph_GB.Location = new Point(280, 109);
        }

        private void ReadGraphB_Click(object sender, EventArgs e)
        {
            try
            {
                //G.ReadGraph();
                var OFD = new OpenFileDialog
                {
                    Title = "Выберите текстовый файл",
                    Filter = "Текстовые файлы (*.txt)|*.txt",
                    FilterIndex = 1,
                    RestoreDirectory = true,
                    CheckFileExists = true
                };
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string filePath = OFD.FileName;
                    string ext = Path.GetExtension(filePath);
                    if (ext != ".txt")
                    {
                        MessageBox.Show("Чтение расширения выбранного файла не поддерживается!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    G.ReadGraph(filePath);
                    MessageBox.Show($"Выбран файл: {FileName(filePath)}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка, файл с графом не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show("Граф успешно прочитан!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadGraph_GB.Location = new Point(23, 199);
            DFS_GB.Visible = true;
            BFS_GB.Visible = true;
            Dijekstra_GB.Visible = true;
            MOD_GB.Visible = true;
            TaskInfo_B.Visible = true;
            ArticulationPoints_GB.Visible = true;
            label7.Visible = true;
        }
        private string FileName(string PathFile)
        {
            List<char> name = new List<char>();
            for (int i = PathFile.Length - 1; i >= 0; i--)
            {
                if (PathFile[i] == '\\') break;
                name.Insert(0, PathFile[i]);
            }
            return string.Join("", name);
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

            if (MOD_F == null) MOD_F = new MOD_F(this, G);
            MOD_F.StartPosition = FormStartPosition.Manual;
            MOD_F.Location = this.Location;

            this.Hide();
            MOD_F.Show();
        }

        private void MOD_B_Click(object sender, EventArgs e)
        {
            if (G == null) return;

            if (MOD_F == null) MOD_F = new MOD_F(this, G);
            MOD_F.StartPosition = FormStartPosition.Manual;
            MOD_F.Location = this.Location;

            this.Hide();
            MOD_F.Show();
        }
    }
}
