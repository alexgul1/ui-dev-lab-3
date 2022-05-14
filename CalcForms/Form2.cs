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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

            calcbtn.Enabled = false;
            savebtn.Enabled = false;
            int daysLeft = new DateTime(DateTime.Now.Year, 12, 31).DayOfYear;

            textBox4.Text = $"{daysLeft}";
        }
        public bool IsAllFieldsFiled()
        {
            return textBox1.Text != string.Empty
                   && textBox2.Text != string.Empty
                   && textBox3.Text != string.Empty
                   && textBox4.Text != string.Empty;
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
        private void CheckBorders()
        {
            if (textBox4.Focused != true)
                panel4.BorderStyle = BorderStyle.None;
            if (textBox3.Focused != true)
                panel3.BorderStyle = BorderStyle.None;
            if (textBox2.Focused != true)
                panel2.BorderStyle = BorderStyle.None;
            if (textBox1.Focused != true)
                panel1.BorderStyle = BorderStyle.None;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
            CheckButtons();
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

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
            CheckButtons();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            CheckButtons();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            CheckButtons();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only positive integer numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
            CheckButtons();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.WhiteSmoke;
            textBox4.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            CheckButtons();
            CheckBorders();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.WhiteSmoke;
            textBox4.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

            CheckButtons();
            CheckBorders();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.WhiteSmoke;

            CheckButtons();
            CheckBorders();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.WhiteSmoke;
            textBox4.BackColor = Color.White;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.White;

            CheckButtons();
            CheckBorders();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            CheckBorders();
            CheckButtons();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Enabled = true;
        }
        public void AllWhite()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.BackColor = Color.WhiteSmoke;
            textBox4.BackColor = Color.WhiteSmoke;

            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;

        }
        private void calcbtn_Click(object sender, EventArgs e)
        {
            AllWhite();
            CheckBorders();

            var p = double.Parse(textBox1.Text);
            var i = double.Parse(textBox2.Text);
            var t = double.Parse(textBox3.Text);
            var k = double.Parse(textBox4.Text);

            var s = ((p * i * t) / k) / 100;
            textBox5.Text = Math.Round(s, 2) + " ГРН";
        }

        public static void SaveStoke(double stoke)
        {
            string[] lines =
            {
                "З'ясувавши річну ставку, періоди та види нарахування відсотків, можна порахувати дохід за вкладом:", "Річна ставка = " + stoke +" ГРН"
            };

            File.WriteAllLines("Deposit.txt", lines);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            AllWhite();
            CheckBorders();

            var p = double.Parse(textBox1.Text);
            var i = double.Parse(textBox2.Text);
            var t = double.Parse(textBox3.Text);
            var k = double.Parse(textBox4.Text);

            var s = ((p * i * t) / k) / 100;

            SaveStoke(Math.Round(s, 2));
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
