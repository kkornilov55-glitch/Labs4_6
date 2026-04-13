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
            From_CB = new ComboBox();
            StartDijkstra_B = new Button();
            Menu_B = new Button();
            To_CB = new ComboBox();
            label2 = new Label();
            WayLength_L = new Label();
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
            Dijkstra_Result_L.Size = new Size(672, 131);
            Dijkstra_Result_L.TabIndex = 22;
            Dijkstra_Result_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // From_CB
            // 
            From_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            From_CB.FormattingEnabled = true;
            From_CB.Location = new Point(12, 227);
            From_CB.Name = "From_CB";
            From_CB.Size = new Size(135, 28);
            From_CB.Sorted = true;
            From_CB.TabIndex = 25;
            // 
            // StartDijkstra_B
            // 
            StartDijkstra_B.Font = new Font("MS Reference Sans Serif", 12F);
            StartDijkstra_B.Location = new Point(12, 261);
            StartDijkstra_B.Name = "StartDijkstra_B";
            StartDijkstra_B.Size = new Size(330, 39);
            StartDijkstra_B.TabIndex = 24;
            StartDijkstra_B.Text = "Старт";
            StartDijkstra_B.UseVisualStyleBackColor = true;
            StartDijkstra_B.Click += StartDijkstra_B_Click;
            // 
            // Menu_B
            // 
            Menu_B.BackColor = Color.White;
            Menu_B.BackgroundImage = Properties.Resources.Menu_B;
            Menu_B.BackgroundImageLayout = ImageLayout.Zoom;
            Menu_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Menu_B.Location = new Point(324, 321);
            Menu_B.Name = "Menu_B";
            Menu_B.Size = new Size(39, 34);
            Menu_B.TabIndex = 26;
            Menu_B.UseVisualStyleBackColor = false;
            Menu_B.Click += Menu_B_Click;
            // 
            // To_CB
            // 
            To_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            To_CB.FormattingEnabled = true;
            To_CB.Location = new Point(212, 227);
            To_CB.Name = "To_CB";
            To_CB.Size = new Size(130, 28);
            To_CB.Sorted = true;
            To_CB.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(159, 221);
            label2.Name = "label2";
            label2.Size = new Size(41, 38);
            label2.TabIndex = 31;
            label2.Text = "→";
            // 
            // WayLength_L
            // 
            WayLength_L.BackColor = Color.Transparent;
            WayLength_L.BorderStyle = BorderStyle.Fixed3D;
            WayLength_L.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WayLength_L.ForeColor = SystemColors.ButtonFace;
            WayLength_L.Location = new Point(348, 227);
            WayLength_L.Name = "WayLength_L";
            WayLength_L.Size = new Size(336, 73);
            WayLength_L.TabIndex = 32;
            WayLength_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DijkstraF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(WayLength_L);
            Controls.Add(label2);
            Controls.Add(To_CB);
            Controls.Add(Menu_B);
            Controls.Add(From_CB);
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
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Label Dijkstra_Result_L;
        private ComboBox From_CB;
        private Button StartDijkstra_B;
        private Button Menu_B;
        private ComboBox To_CB;
        private Label label2;
        private Label WayLength_L;
    }
}