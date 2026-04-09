namespace WinForms
{
    partial class MenuF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ReadGraphB = new Button();
            label2 = new Label();
            TaskInfo_B = new Button();
            ReadGraph_GB = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            DFS_GB = new GroupBox();
            DFS_B = new Button();
            label3 = new Label();
            BFS_GB = new GroupBox();
            BFS_B = new Button();
            label4 = new Label();
            Dijekstra_GB = new GroupBox();
            Dijkstra_B = new Button();
            label5 = new Label();
            MOD_GB = new GroupBox();
            button4 = new Button();
            label6 = new Label();
            ReadGraph_GB.SuspendLayout();
            DFS_GB.SuspendLayout();
            BFS_GB.SuspendLayout();
            Dijekstra_GB.SuspendLayout();
            MOD_GB.SuspendLayout();
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
            label1.TabIndex = 0;
            label1.Text = "Меню управления графом";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReadGraphB
            // 
            ReadGraphB.BackgroundImage = Properties.Resources.ReadGraphB;
            ReadGraphB.BackgroundImageLayout = ImageLayout.Zoom;
            ReadGraphB.Location = new Point(6, 15);
            ReadGraphB.Name = "ReadGraphB";
            ReadGraphB.Size = new Size(125, 125);
            ReadGraphB.TabIndex = 1;
            ReadGraphB.UseVisualStyleBackColor = true;
            ReadGraphB.Click += ReadGraphB_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(6, 143);
            label2.Name = "label2";
            label2.Size = new Size(125, 46);
            label2.TabIndex = 6;
            label2.Text = "Загрузить\r\nграф\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskInfo_B
            // 
            TaskInfo_B.BackColor = Color.White;
            TaskInfo_B.BackgroundImage = Properties.Resources.free_icon_open_book_171322;
            TaskInfo_B.BackgroundImageLayout = ImageLayout.Zoom;
            TaskInfo_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TaskInfo_B.Location = new Point(651, 335);
            TaskInfo_B.Name = "TaskInfo_B";
            TaskInfo_B.Size = new Size(39, 34);
            TaskInfo_B.TabIndex = 11;
            TaskInfo_B.UseVisualStyleBackColor = false;
            TaskInfo_B.Click += TaskInfo_B_Click;
            // 
            // ReadGraph_GB
            // 
            ReadGraph_GB.BackColor = Color.Transparent;
            ReadGraph_GB.Controls.Add(ReadGraphB);
            ReadGraph_GB.Controls.Add(label2);
            ReadGraph_GB.Location = new Point(6, 109);
            ReadGraph_GB.Name = "ReadGraph_GB";
            ReadGraph_GB.Size = new Size(136, 191);
            ReadGraph_GB.TabIndex = 12;
            ReadGraph_GB.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(58, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 10);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Location = new Point(573, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 10);
            panel2.TabIndex = 14;
            // 
            // DFS_GB
            // 
            DFS_GB.BackColor = Color.Transparent;
            DFS_GB.Controls.Add(DFS_B);
            DFS_GB.Controls.Add(label3);
            DFS_GB.Location = new Point(143, 109);
            DFS_GB.Name = "DFS_GB";
            DFS_GB.Size = new Size(136, 191);
            DFS_GB.TabIndex = 15;
            DFS_GB.TabStop = false;
            DFS_GB.Visible = false;
            // 
            // DFS_B
            // 
            DFS_B.BackgroundImage = Properties.Resources.DFS_B;
            DFS_B.BackgroundImageLayout = ImageLayout.Zoom;
            DFS_B.Location = new Point(6, 15);
            DFS_B.Name = "DFS_B";
            DFS_B.Size = new Size(125, 125);
            DFS_B.TabIndex = 1;
            DFS_B.UseVisualStyleBackColor = true;
            DFS_B.Click += DFS_B_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(125, 46);
            label3.TabIndex = 6;
            label3.Text = "DFS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BFS_GB
            // 
            BFS_GB.BackColor = Color.Transparent;
            BFS_GB.Controls.Add(BFS_B);
            BFS_GB.Controls.Add(label4);
            BFS_GB.Location = new Point(280, 109);
            BFS_GB.Name = "BFS_GB";
            BFS_GB.Size = new Size(136, 191);
            BFS_GB.TabIndex = 16;
            BFS_GB.TabStop = false;
            BFS_GB.Visible = false;
            // 
            // BFS_B
            // 
            BFS_B.BackgroundImage = Properties.Resources.BFS_B;
            BFS_B.BackgroundImageLayout = ImageLayout.Zoom;
            BFS_B.Location = new Point(6, 15);
            BFS_B.Name = "BFS_B";
            BFS_B.Size = new Size(125, 125);
            BFS_B.TabIndex = 1;
            BFS_B.UseVisualStyleBackColor = true;
            BFS_B.Click += BFS_B_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(6, 143);
            label4.Name = "label4";
            label4.Size = new Size(125, 46);
            label4.TabIndex = 6;
            label4.Text = "BFS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dijekstra_GB
            // 
            Dijekstra_GB.BackColor = Color.Transparent;
            Dijekstra_GB.Controls.Add(Dijkstra_B);
            Dijekstra_GB.Controls.Add(label5);
            Dijekstra_GB.Location = new Point(417, 109);
            Dijekstra_GB.Name = "Dijekstra_GB";
            Dijekstra_GB.Size = new Size(136, 191);
            Dijekstra_GB.TabIndex = 17;
            Dijekstra_GB.TabStop = false;
            Dijekstra_GB.Visible = false;
            // 
            // Dijkstra_B
            // 
            Dijkstra_B.BackgroundImage = Properties.Resources.Dijkstra_B;
            Dijkstra_B.BackgroundImageLayout = ImageLayout.Zoom;
            Dijkstra_B.Location = new Point(6, 15);
            Dijkstra_B.Name = "Dijkstra_B";
            Dijkstra_B.Size = new Size(125, 125);
            Dijkstra_B.TabIndex = 1;
            Dijkstra_B.UseVisualStyleBackColor = true;
            Dijkstra_B.Click += Dijkstra_B_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(125, 46);
            label5.TabIndex = 6;
            label5.Text = "Дейкстра";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MOD_GB
            // 
            MOD_GB.BackColor = Color.Transparent;
            MOD_GB.Controls.Add(button4);
            MOD_GB.Controls.Add(label6);
            MOD_GB.Location = new Point(554, 109);
            MOD_GB.Name = "MOD_GB";
            MOD_GB.Size = new Size(136, 191);
            MOD_GB.TabIndex = 18;
            MOD_GB.TabStop = false;
            MOD_GB.Visible = false;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.MOD_B;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(6, 15);
            button4.Name = "button4";
            button4.Size = new Size(125, 125);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(6, 143);
            label6.Name = "label6";
            label6.Size = new Size(125, 46);
            label6.TabIndex = 6;
            label6.Text = "МОД";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(MOD_GB);
            Controls.Add(Dijekstra_GB);
            Controls.Add(BFS_GB);
            Controls.Add(DFS_GB);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ReadGraph_GB);
            Controls.Add(TaskInfo_B);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuF";
            Text = "Меню";
            ReadGraph_GB.ResumeLayout(false);
            DFS_GB.ResumeLayout(false);
            BFS_GB.ResumeLayout(false);
            Dijekstra_GB.ResumeLayout(false);
            MOD_GB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ReadGraphB;
        private Label label2;
        private Button TaskInfo_B;
        private GroupBox ReadGraph_GB;
        private Panel panel1;
        private Panel panel2;
        private GroupBox DFS_GB;
        private Button DFS_B;
        private Label label3;
        private GroupBox BFS_GB;
        private Button BFS_B;
        private Label label4;
        private GroupBox Dijekstra_GB;
        private Button Dijkstra_B;
        private Label label5;
        private GroupBox MOD_GB;
        private Button button4;
        private Label label6;
    }
}
