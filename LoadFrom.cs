using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace long_bong_midterm.CustomForm
{
    public partial class LoadFrom : Form
    {

        private int progressValue = 0;
        private int colorIndex = 0;
        public LoadFrom()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue++;
                pgbLoad.Value = progressValue;
            }
            else
            {
                timer1.Stop();
                MainTaskForm mainTaskForm = new MainTaskForm();
                mainTaskForm.Show();
                this.Hide();
            }
            if (progressValue == 100)
            {

            }


        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnIn_MouseEnter(object sender, EventArgs e)
        {
            btnIn.Text = "Start";
            btnIn.BackColor = Color.PaleGreen;
        }

        private void btnIn_MouseLeave(object sender, EventArgs e)
        {
            btnIn.Text = "Exit";
            btnIn.BackColor = Color.LightCoral;
        }

        private void btnIn1_Click(object sender, EventArgs e)
        {
            btnIn_Click(sender, e);
        }

        private void LoadFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Nah, i'd let you in");
            e.Cancel = true;
            timer1.Start();
        }

       
    }
}
