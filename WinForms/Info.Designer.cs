namespace WinForms
{
    partial class Info_F
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
            Info_RTB = new RichTextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            SuspendLayout();
            // 
            // Menu_B
            // 
            Menu_B.BackColor = Color.White;
            Menu_B.BackgroundImage = Properties.Resources.Menu_B;
            Menu_B.BackgroundImageLayout = ImageLayout.Zoom;
            Menu_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Menu_B.Location = new Point(207, 407);
            Menu_B.Name = "Menu_B";
            Menu_B.Size = new Size(39, 34);
            Menu_B.TabIndex = 13;
            Menu_B.UseVisualStyleBackColor = false;
            Menu_B.Click += Menu_B_Click;
            // 
            // Info_RTB
            // 
            Info_RTB.Font = new Font("MS Reference Sans Serif", 9F);
            Info_RTB.Location = new Point(34, 80);
            Info_RTB.Name = "Info_RTB";
            Info_RTB.Size = new Size(383, 321);
            Info_RTB.TabIndex = 14;
            Info_RTB.Text = "";
            // 
            // panel2
            // 
            panel2.Location = new Point(483, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 10);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Location = new Point(62, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(43, 10);
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
            label1.Size = new Size(448, 69);
            label1.TabIndex = 15;
            label1.Text = "Информация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Location = new Point(338, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(43, 10);
            panel3.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Location = new Point(18, 382);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 35);
            panel5.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Location = new Point(22, 407);
            panel4.Name = "panel4";
            panel4.Size = new Size(39, 10);
            panel4.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.Location = new Point(423, 382);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 35);
            panel6.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.Location = new Point(391, 407);
            panel7.Name = "panel7";
            panel7.Size = new Size(39, 10);
            panel7.TabIndex = 21;
            // 
            // Info_F
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back_mini;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(448, 450);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Info_RTB);
            Controls.Add(Menu_B);
            DoubleBuffered = true;
            Name = "Info_F";
            Text = "Информация";
            FormClosed += Info_F_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Button Menu_B;
        private RichTextBox Info_RTB;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
    }
}