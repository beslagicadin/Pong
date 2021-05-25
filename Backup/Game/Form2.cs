using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        Random r = new Random();

        public Form2()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 10);

            gameover.Left = (playground.Width / 2) - (gameover.Width / 2);
            gameover.Top = (playground.Height / 2) - (gameover.Height / 2);
            gameover.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bounds.IntersectsWith(racket.Bounds))
            {
                speed_top += 1;
                speed_left += 1;
                speed_left = r.Next(-6, 6);
                speed_top = -speed_top;
                point += 1;
                points.Text = point.ToString();
            }

            if (ball.Left <= playground.Left) { speed_left = -speed_left; }
            if (ball.Right >= playground.Right) { speed_left = -speed_left; }
            if (ball.Top <= playground.Top) { speed_top = -speed_top; }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Cursor.Show();
            }

            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points.Text = "0";
                point = 0;
                timer1.Enabled = true;
                gameover.Visible = false;
            }
                
        }




    }
}
