namespace long_bong_midterm.CustomForm
{
    partial class LoadFrom
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
            components = new System.ComponentModel.Container();
            lblAppTitle = new Label();
            pgbLoad = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            btnIn = new Button();
            btnIn1 = new Button();
            SuspendLayout();
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppTitle.Location = new Point(12, 9);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(374, 46);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Welcome to ToDo List!";
            // 
            // pgbLoad
            // 
            pgbLoad.Location = new Point(37, 70);
            pgbLoad.Name = "pgbLoad";
            pgbLoad.Size = new Size(300, 30);
            pgbLoad.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.LightCoral;
            btnIn.Location = new Point(61, 118);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 29);
            btnIn.TabIndex = 2;
            btnIn.Text = "Exit";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            btnIn.MouseEnter += btnIn_MouseEnter;
            btnIn.MouseLeave += btnIn_MouseLeave;
            // 
            // btnIn1
            // 
            btnIn1.BackColor = Color.PaleGreen;
            btnIn1.Location = new Point(212, 118);
            btnIn1.Name = "btnIn1";
            btnIn1.Size = new Size(94, 29);
            btnIn1.TabIndex = 2;
            btnIn1.Text = "Start";
            btnIn1.UseVisualStyleBackColor = false;
            btnIn1.Click += btnIn1_Click;
            // 
            // LoadFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 153);
            Controls.Add(btnIn1);
            Controls.Add(btnIn);
            Controls.Add(pgbLoad);
            Controls.Add(lblAppTitle);
            Name = "LoadFrom";
            Text = "LoadFrom";
            FormClosing += LoadFrom_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppTitle;
        private ProgressBar pgbLoad;
        private System.Windows.Forms.Timer timer1;
        private Button btnIn;
        private Button btnIn1;
    }
}