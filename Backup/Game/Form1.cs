﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            title.Left = (background.Width / 2) - (title.Width / 2);
            title.Top = (background.Height / 2) - (title.Height / 2);
            button1.Top = title.Bottom + 10;
            button1.Left = 450;
            button2.Left = button1.Right + 50;
            button2.Top = button1.Top;
            button3.Top = button1.Bottom + 30;
            button3.Left = button2.Left - 75;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}
