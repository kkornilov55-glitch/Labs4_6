using ClassLibrary;

namespace WinForms
{
    public partial class MenuF : Form
    {
        public MenuF()
        {
            InitializeComponent();
            ReadGraph_GB.Location = new Point(280, 109);
        }

        private void ReadGraphB_Click(object sender, EventArgs e)
        {
            var G = new Graph();
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
    }
}
