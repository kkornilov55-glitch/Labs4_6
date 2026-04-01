namespace WinForms
{
    partial class BFS_F
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
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            Menu_B = new Button();
            BFS_Result_L = new Label();
            Towns_CB = new ComboBox();
            StartDFS_B = new Button();
            ComponentsShow_B = new Button();
            Check_B = new Button();
            StartV_TB = new TextBox();
            EndV_TB = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(543, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 10);
            panel2.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Location = new Point(91, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 10);
            panel1.TabIndex = 19;
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
            label1.TabIndex = 18;
            label1.Text = "BFS (Поиск в ширину)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu_B
            // 
            Menu_B.BackColor = Color.White;
            Menu_B.BackgroundImage = Properties.Resources.Menu_B;
            Menu_B.BackgroundImageLayout = ImageLayout.Zoom;
            Menu_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Menu_B.Location = new Point(645, 333);
            Menu_B.Name = "Menu_B";
            Menu_B.Size = new Size(39, 34);
            Menu_B.TabIndex = 21;
            Menu_B.UseVisualStyleBackColor = false;
            Menu_B.Click += Menu_B_Click;
            // 
            // BFS_Result_L
            // 
            BFS_Result_L.BackColor = Color.Transparent;
            BFS_Result_L.BorderStyle = BorderStyle.Fixed3D;
            BFS_Result_L.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BFS_Result_L.ForeColor = SystemColors.ButtonFace;
            BFS_Result_L.Location = new Point(12, 97);
            BFS_Result_L.Name = "BFS_Result_L";
            BFS_Result_L.Size = new Size(672, 156);
            BFS_Result_L.TabIndex = 22;
            BFS_Result_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Towns_CB
            // 
            Towns_CB.FormattingEnabled = true;
            Towns_CB.Location = new Point(12, 266);
            Towns_CB.Name = "Towns_CB";
            Towns_CB.Size = new Size(151, 28);
            Towns_CB.Sorted = true;
            Towns_CB.TabIndex = 25;
            // 
            // StartDFS_B
            // 
            StartDFS_B.Font = new Font("MS Reference Sans Serif", 12F);
            StartDFS_B.Location = new Point(12, 300);
            StartDFS_B.Name = "StartDFS_B";
            StartDFS_B.Size = new Size(151, 38);
            StartDFS_B.TabIndex = 24;
            StartDFS_B.Text = "Старт";
            StartDFS_B.UseVisualStyleBackColor = true;
            StartDFS_B.Click += StartDFS_B_Click;
            // 
            // ComponentsShow_B
            // 
            ComponentsShow_B.Font = new Font("MS Reference Sans Serif", 12F);
            ComponentsShow_B.Location = new Point(527, 266);
            ComponentsShow_B.Name = "ComponentsShow_B";
            ComponentsShow_B.Size = new Size(157, 40);
            ComponentsShow_B.TabIndex = 26;
            ComponentsShow_B.Text = "Компоненты";
            ComponentsShow_B.UseVisualStyleBackColor = true;
            ComponentsShow_B.Click += ComponentsShow_B_Click_1;
            // 
            // Check_B
            // 
            Check_B.Font = new Font("MS Reference Sans Serif", 12F);
            Check_B.Location = new Point(219, 300);
            Check_B.Name = "Check_B";
            Check_B.Size = new Size(284, 38);
            Check_B.TabIndex = 27;
            Check_B.Text = "Проверить достижимость";
            Check_B.UseVisualStyleBackColor = true;
            Check_B.Click += Check_B_Click;
            // 
            // StartV_TB
            // 
            StartV_TB.Location = new Point(219, 266);
            StartV_TB.Multiline = true;
            StartV_TB.Name = "StartV_TB";
            StartV_TB.Size = new Size(121, 28);
            StartV_TB.TabIndex = 28;
            // 
            // EndV_TB
            // 
            EndV_TB.Location = new Point(382, 266);
            EndV_TB.Multiline = true;
            EndV_TB.Name = "EndV_TB";
            EndV_TB.Size = new Size(121, 28);
            EndV_TB.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(350, 269);
            label2.Name = "label2";
            label2.Size = new Size(25, 23);
            label2.TabIndex = 30;
            label2.Text = "→";
            // 
            // BFS_F
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(label2);
            Controls.Add(EndV_TB);
            Controls.Add(StartV_TB);
            Controls.Add(Check_B);
            Controls.Add(ComponentsShow_B);
            Controls.Add(Towns_CB);
            Controls.Add(StartDFS_B);
            Controls.Add(BFS_Result_L);
            Controls.Add(Menu_B);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "BFS_F";
            Text = "Поиск в ширину";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button Menu_B;
        private Label BFS_Result_L;
        private ComboBox Towns_CB;
        private Button StartDFS_B;
        private Button ComponentsShow_B;
        private Button Check_B;
        private TextBox StartV_TB;
        private TextBox EndV_TB;
        private Label label2;
    }
}