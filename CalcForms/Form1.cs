using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForms
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            var form2 = new Form2();
            form2.Show(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;

            CheckButtons();
            CheckBorders();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckBorders()
        {
            if (textBox3.Focused != true)
                panel3.BorderStyle = BorderStyle.None;
            if (textBox2.Focused != true)
                panel2.BorderStyle = BorderStyle.None;
            if (textBox1.Focused != true)
                panel1.BorderStyle = BorderStyle.None;
        }


        private void Deposit_MouseMove(object sender, MouseEventArgs e)
        {
            if (textBox3.Focused != true)
                panel3.BorderStyle = BorderStyle.None;
            if (textBox2.Focused != true)
                panel2.BorderStyle = BorderStyle.None;
            if (textBox1.Focused != true)
                panel1.BorderStyle = BorderStyle.None;

            CheckButtons();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox3.Text = textBox1.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.WhiteSmoke;
          
            CheckButtons();
            CheckBorders();
        }
        public bool IsAllFieldsFiled()
        {
            return textBox1.Text != string.Empty
                   && textBox2.Text != string.Empty
                   && textBox3.Text != string.Empty;
        }
        public void CheckButtons()
        {
            if (IsAllFieldsFiled())
            {
                calcbtn.Enabled = true;
                savebtn.Enabled = true;
            }
            else
            {
                calcbtn.Enabled = false;
                savebtn.Enabled = false;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = true;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Enabled = true;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.White;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.White;

            CheckButtons();
            CheckBorders();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void AllWhite()
        {
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
        }
        private void calcbtn_Click(object sender, EventArgs e)
        {
            AllWhite();
            CheckBorders();

            var s = double.Parse(textBox1.Text);
            var p = double.Parse(textBox2.Text);
            var n = double.Parse(textBox3.Text);
            p /= 1200;

            var x = s * ((p * Math.Pow((1 + p), n)) / (Math.Pow((1 + p), n) - 1));

            textBox4.Text = Math.Round(x, 2) + " ГРН";
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
        }
        public static void SaveStoke(double pay)
        {
            string[] lines =
            {
                "Розрахувати відсотки:", "Розмір платежу за перший місяць = " + Math.Round(pay, 2) +" ГРН"
            };

            File.WriteAllLines("Credit.txt", lines);
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            AllWhite();
            CheckBorders();
            var s = double.Parse(textBox1.Text);
            var p = double.Parse(textBox2.Text);
            var n = double.Parse(textBox3.Text);
            p /= 1200;

            var x = s * ((p * Math.Pow((1 + p), n)) / (Math.Pow((1 + p), n) - 1));

            SaveStoke(x);
        }

        private void Deposit_Leave(object sender, EventArgs e)
        {
        }

        private void Deposit_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
