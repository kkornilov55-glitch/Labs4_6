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
    public partial class Info_F : Form
    {
        private Menu_F menu;
        public Info_F(Menu_F parent)
        {
            InitializeComponent();
            WhiteInfoText();
            menu = parent;

        }

        private void Menu_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
        private void WhiteInfoText()
        {
            Info_RTB.Text =
                @"
📌ЛАБОРАТОРНАЯ РАБОТА #4
«Построение графа. Алгоритмы обхода»

🔹 Вариант: 14 — Схема речной системы
🔹 Предметная область: Навигация по речной сети региона.
🔹 Вершины графа: Города и населённые пункты, расположенные на реках.
🔹 Рёбра графа: Судоходные участки рек (вес = расстояние в км).
🔹 Тип графа: Неориентированный, взвешенный.

✅ Реализованные требования ЛР №4:
1. Загрузка графа из текстового файла в структуру «список смежности».
2. Обход графа в глубину (DFS) с выводом порядка посещения вершин.
3. Обход графа в ширину (BFS) с выводом порядка посещения вершин.
4. Проверка достижимости конечного города из начального (на базе BFS).
5. Поиск и визуализация компонент связности речной сети.

📊 Формат входных данных (river_graph.txt):
ГородА;ГородБ;Расстояние_в_км
(минимум 15 вершин, 20 рёбер)
";
        }

        private void Info_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}
