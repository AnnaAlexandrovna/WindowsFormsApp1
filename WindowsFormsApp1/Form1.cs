﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }
    }
}
