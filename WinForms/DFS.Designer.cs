namespace WinForms
{
    partial class DFS
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
            Menu_B = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            StartDFS_B = new Button();
            DFS_Result_L = new Label();
            ComponentsShow_B = new Button();
            Towns_CB = new ComboBox();
            SuspendLayout();
            // 
            // Menu_B
            // 
            Menu_B.BackColor = Color.White;
            Menu_B.BackgroundImage = Properties.Resources.Menu_B;
            Menu_B.BackgroundImageLayout = ImageLayout.Zoom;
            Menu_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Menu_B.Location = new Point(327, 333);
            Menu_B.Name = "Menu_B";
            Menu_B.Size = new Size(39, 34);
            Menu_B.TabIndex = 12;
            Menu_B.UseVisualStyleBackColor = false;
            Menu_B.Click += Menu_B_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(547, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 10);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Location = new Point(89, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 10);
            panel1.TabIndex = 16;
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
            label1.TabIndex = 15;
            label1.Text = "DFS (Поиск в глубину)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartDFS_B
            // 
            StartDFS_B.Font = new Font("MS Reference Sans Serif", 12F);
            StartDFS_B.Location = new Point(12, 298);
            StartDFS_B.Name = "StartDFS_B";
            StartDFS_B.Size = new Size(151, 39);
            StartDFS_B.TabIndex = 19;
            StartDFS_B.Text = "Старт";
            StartDFS_B.UseVisualStyleBackColor = true;
            StartDFS_B.Click += StartDFS_B_Click;
            // 
            // DFS_Result_L
            // 
            DFS_Result_L.BackColor = Color.Transparent;
            DFS_Result_L.BorderStyle = BorderStyle.Fixed3D;
            DFS_Result_L.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DFS_Result_L.ForeColor = SystemColors.ButtonFace;
            DFS_Result_L.Location = new Point(12, 93);
            DFS_Result_L.Name = "DFS_Result_L";
            DFS_Result_L.Size = new Size(672, 156);
            DFS_Result_L.TabIndex = 21;
            DFS_Result_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComponentsShow_B
            // 
            ComponentsShow_B.Font = new Font("MS Reference Sans Serif", 12F);
            ComponentsShow_B.Location = new Point(527, 273);
            ComponentsShow_B.Name = "ComponentsShow_B";
            ComponentsShow_B.Size = new Size(157, 48);
            ComponentsShow_B.TabIndex = 22;
            ComponentsShow_B.Text = "Компоненты";
            ComponentsShow_B.UseVisualStyleBackColor = true;
            ComponentsShow_B.Click += ComponentsShow_B_Click;
            // 
            // Towns_CB
            // 
            Towns_CB.FormattingEnabled = true;
            Towns_CB.Location = new Point(12, 264);
            Towns_CB.Name = "Towns_CB";
            Towns_CB.Size = new Size(151, 28);
            Towns_CB.Sorted = true;
            Towns_CB.TabIndex = 23;
            // 
            // DFS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(Towns_CB);
            Controls.Add(ComponentsShow_B);
            Controls.Add(DFS_Result_L);
            Controls.Add(StartDFS_B);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Menu_B);
            DoubleBuffered = true;
            Name = "DFS";
            Text = "Поиск в глубину";
            ResumeLayout(false);
        }

        #endregion

        private Button Menu_B;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button StartDFS_B;
        private Label DFS_Result_L;
        private Button ComponentsShow_B;
        private ComboBox Towns_CB;
    }
}