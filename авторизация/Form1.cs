using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace авторизация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Пайдаланушы атын енгізіңіз";
                    return;
                }
                textBox1.ForeColor = Color.White;
                panel5.Visible = false;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "Құпия сөзді енгізіңіз")
                {
                    return;
                }
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "Пайдаланушы атын енгізіңіз")
            {
                panel5.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "Құпия сөзді енгізіңіз")
            {
                panel7.Visible = true;
                textBox2.Focus();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.Lime;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Lime;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Пайдаланушы атын енгізіңіз")
            {
                pnlUsername.Visible = true;
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }
                if (textBox4.Text == "Байланыс нөмерін енгізіңіз")
                {
                    pnlContact.Visible = true;
                    textBox4.Focus();
                    textBox4.SelectAll();
                return;
                }
                if (textBox5.Text == "Құпия сөзді енгізіңіз")
                {
                    pnlPassword.Visible = true;
                    textBox5.Focus();
                    textBox5.SelectAll();
                return;
                }
                if (textBox6.Text == "Құпия сөзді қайталаңыз")
                {
                    pnlCPassword.Visible = true;
                    textBox6.Focus();
                    textBox6.SelectAll();
                return;
                }
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
            button3.BackColor = Color.Green;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Dock = DockStyle.Fill;
            pnlSignup.Visible = false;
            pnlLogo.Dock = DockStyle.Left;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
            pnlSignup.Visible = true;

            pnlSignup.Dock = DockStyle.Fill;
            pnlLogo.Dock = DockStyle.Right;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }
