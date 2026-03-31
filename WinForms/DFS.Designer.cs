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
            SuspendLayout();
            // 
            // Menu_B
            // 
            Menu_B.BackColor = Color.White;
            Menu_B.BackgroundImage = Properties.Resources.Menu_B;
            Menu_B.BackgroundImageLayout = ImageLayout.Zoom;
            Menu_B.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Menu_B.Location = new Point(651, 335);
            Menu_B.Name = "Menu_B";
            Menu_B.Size = new Size(39, 34);
            Menu_B.TabIndex = 12;
            Menu_B.UseVisualStyleBackColor = false;
            Menu_B.Click += Menu_B_Click;
            // 
            // DFS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1qlwtx1qlwtx1qlw_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 379);
            Controls.Add(Menu_B);
            DoubleBuffered = true;
            Name = "DFS";
            Text = "Поиск в глубину";
            ResumeLayout(false);
        }

        #endregion

        private Button Menu_B;
    }
}