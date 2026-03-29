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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button6 = new Button();
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
            label1.Size = new Size(692, 69);
            label1.TabIndex = 0;
            label1.Text = "Меню управления графом";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReadGraphB
            // 
            ReadGraphB.BackgroundImage = Properties.Resources.ReadGraphB;
            ReadGraphB.BackgroundImageLayout = ImageLayout.Zoom;
            ReadGraphB.Location = new Point(12, 126);
            ReadGraphB.Name = "ReadGraphB";
            ReadGraphB.Size = new Size(125, 125);
            ReadGraphB.TabIndex = 1;
            ReadGraphB.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Dijkstra_B;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(420, 126);
            button2.Name = "button2";
            button2.Size = new Size(125, 125);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.DFS_B;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(148, 126);
            button3.Name = "button3";
            button3.Size = new Size(125, 125);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.BFS_B;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(283, 126);
            button4.Name = "button4";
            button4.Size = new Size(125, 125);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.MOD_B;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(555, 126);
            button5.Name = "button5";
            button5.Size = new Size(125, 125);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 254);
            label2.Name = "label2";
            label2.Size = new Size(125, 46);
            label2.TabIndex = 6;
            label2.Text = "Загрузить\r\nграф\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(148, 254);
            label3.Name = "label3";
            label3.Size = new Size(125, 46);
            label3.TabIndex = 7;
            label3.Text = "DFS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(283, 254);
            label4.Name = "label4";
            label4.Size = new Size(125, 46);
            label4.TabIndex = 8;
            label4.Text = "BFS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(420, 254);
            label5.Name = "label5";
            label5.Size = new Size(125, 46);
            label5.TabIndex = 9;
            label5.Text = "Дейкстра";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(551, 254);
            label6.Name = "label6";
            label6.Size = new Size(125, 46);
            label6.TabIndex = 10;
            label6.Text = "МОД";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.BackgroundImage = Properties.Resources.free_icon_open_book_171322;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button6.Location = new Point(645, 335);
            button6.Name = "button6";
            button6.Size = new Size(39, 34);
            button6.TabIndex = 11;
            button6.UseVisualStyleBackColor = false;
            // 
            // MenuF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(692, 378);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ReadGraphB);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "MenuF";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ReadGraphB;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button6;
    }
}
