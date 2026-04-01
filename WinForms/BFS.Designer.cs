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
            DFS_Result_L = new Label();
            Towns_CB = new ComboBox();
            StartDFS_B = new Button();
            ComponentsShow_B = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // 
            // DFS_Result_L
            // 
            DFS_Result_L.BackColor = Color.Transparent;
            DFS_Result_L.BorderStyle = BorderStyle.Fixed3D;
            DFS_Result_L.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DFS_Result_L.ForeColor = SystemColors.ButtonFace;
            DFS_Result_L.Location = new Point(12, 97);
            DFS_Result_L.Name = "DFS_Result_L";
            DFS_Result_L.Size = new Size(672, 156);
            DFS_Result_L.TabIndex = 22;
            DFS_Result_L.TextAlign = ContentAlignment.MiddleCenter;
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
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 12F);
            button1.Location = new Point(219, 300);
            button1.Name = "button1";
            button1.Size = new Size(284, 38);
            button1.TabIndex = 27;
            button1.Text = "Проверить достижимость";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 266);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 28);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 266);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 28);
            textBox2.TabIndex = 29;
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(ComponentsShow_B);
            Controls.Add(Towns_CB);
            Controls.Add(StartDFS_B);
            Controls.Add(DFS_Result_L);
            Controls.Add(Menu_B);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
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
        private Label DFS_Result_L;
        private ComboBox Towns_CB;
        private Button StartDFS_B;
        private Button ComponentsShow_B;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}