namespace WinForms
{
    partial class MOD_F
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
            panel1 = new Panel();
            label1 = new Label();
            Menu_B = new Button();
            StartMOD_B = new Button();
            panel2 = new Panel();
            Result_L = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 10);
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
            label1.Text = "МОД";
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
            // StartMOD_B
            // 
            StartMOD_B.Font = new Font("MS Reference Sans Serif", 12F);
            StartMOD_B.Location = new Point(12, 274);
            StartMOD_B.Name = "StartMOD_B";
            StartMOD_B.Size = new Size(189, 38);
            StartMOD_B.TabIndex = 24;
            StartMOD_B.Text = "Старт";
            StartMOD_B.UseVisualStyleBackColor = true;
            StartMOD_B.Click += StartMOD_B_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(501, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 10);
            panel2.TabIndex = 31;
            // 
            // Result_L
            // 
            Result_L.BackColor = Color.Transparent;
            Result_L.BorderStyle = BorderStyle.Fixed3D;
            Result_L.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Result_L.ForeColor = SystemColors.ButtonFace;
            Result_L.Location = new Point(12, 88);
            Result_L.Name = "Result_L";
            Result_L.Size = new Size(672, 171);
            Result_L.TabIndex = 32;
            Result_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MOD_F
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(Result_L);
            Controls.Add(panel2);
            Controls.Add(StartMOD_B);
            Controls.Add(Menu_B);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MOD_F";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск в ширину";
            FormClosed += MOD_F_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button Menu_B;
        private Button StartMOD_B;
        private Panel panel2;
        private Label Result_L;
    }
}