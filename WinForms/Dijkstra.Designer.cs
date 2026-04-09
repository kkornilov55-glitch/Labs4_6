namespace WinForms
{
    partial class DijkstraF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            Dijkstra_Result_L = new Label();
            Towns_CB = new ComboBox();
            StartDijkstra_B = new Button();
            Menu_B = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(696, 69);
            label1.TabIndex = 16;
            label1.Text = "Дейкстра";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Location = new Point(494, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 10);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Location = new Point(145, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 10);
            panel1.TabIndex = 18;
            // 
            // Dijkstra_Result_L
            // 
            Dijkstra_Result_L.BackColor = Color.Transparent;
            Dijkstra_Result_L.BorderStyle = BorderStyle.Fixed3D;
            Dijkstra_Result_L.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Dijkstra_Result_L.ForeColor = SystemColors.ButtonFace;
            Dijkstra_Result_L.Location = new Point(12, 90);
            Dijkstra_Result_L.Name = "Dijkstra_Result_L";
            Dijkstra_Result_L.Size = new Size(672, 156);
            Dijkstra_Result_L.TabIndex = 22;
            Dijkstra_Result_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Towns_CB
            // 
            Towns_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            Towns_CB.FormattingEnabled = true;
            Towns_CB.Location = new Point(12, 266);
            Towns_CB.Name = "Towns_CB";
            Towns_CB.Size = new Size(151, 28);
            Towns_CB.Sorted = true;
            Towns_CB.TabIndex = 25;
            // 
            // StartDijkstra_B
            // 
            StartDijkstra_B.Font = new Font("MS Reference Sans Serif", 12F);
            StartDijkstra_B.Location = new Point(12, 300);
            StartDijkstra_B.Name = "StartDijkstra_B";
            StartDijkstra_B.Size = new Size(151, 39);
            StartDijkstra_B.TabIndex = 24;
            StartDijkstra_B.Text = "Старт";
            StartDijkstra_B.UseVisualStyleBackColor = true;
            // 
            // Menu_B
            // 
            Menu_B.BackColor = Color.White;
            Menu_B.BackgroundImage = Properties.Resources.Menu_B;
            Menu_B.BackgroundImageLayout = ImageLayout.Zoom;
            Menu_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Menu_B.Location = new Point(324, 333);
            Menu_B.Name = "Menu_B";
            Menu_B.Size = new Size(39, 34);
            Menu_B.TabIndex = 26;
            Menu_B.UseVisualStyleBackColor = false;
            Menu_B.Click += Menu_B_Click;
            // 
            // DijkstraF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(Menu_B);
            Controls.Add(Towns_CB);
            Controls.Add(StartDijkstra_B);
            Controls.Add(Dijkstra_Result_L);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DijkstraF";
            Text = "Алгоритм Дейкстры";
            FormClosed += DijkstraF_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Label Dijkstra_Result_L;
        private ComboBox Towns_CB;
        private Button StartDijkstra_B;
        private Button Menu_B;
    }
}