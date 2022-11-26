using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgasiaAllilepidrasiYpologisti
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeekendProgram form1 = new WeekendProgram();
            form1.ShowDialog();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormalShoes formal = new FormalShoes();
            formal.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox2.Show();
            pictureBox2.Image = Image.FromFile(@"LightOn.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CasualShoes casual = new CasualShoes();
            casual.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox2.Show();
            pictureBox2.Image = Image.FromFile(@"LightOff.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            pictureBox3.Show();
            pictureBox3.Image = Image.FromFile(@"Warm.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            pictureBox3.Show();
            pictureBox3.Image = Image.FromFile(@"LightOff.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.ShowDialog();
            this.Close();
        }

        private void εβδομαδιαίοΠρόγραμμαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeekendProgram weekprog = new WeekendProgram();
            weekprog.ShowDialog();
            this.Close();
        }

        private void επίσημαΠαπούτσιαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormalShoes formalshoe = new FormalShoes();
            formalshoe.ShowDialog();
            this.Close();
        }

        private void αθλητικάΠαπούτσιαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CasualShoes casualshoe = new CasualShoes();
            casualshoe.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katoikidio kat = new Katoikidio();
            kat.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεν έχετε αθλητικά παπούτσια!");
            {
                if (MessageBox.Show("Θέλετε να αγοράσετε αθλητικά παπούτσια?", "Αθλητικα παπούτσια", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    Process.Start("https://www.nike.com/gr/w/running-shoes-37v7jzy7ok");            

                }
             }
        }

        private void κατοικίδιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katoikidio kat = new Katoikidio();
            kat.ShowDialog();
            this.Close();
        }

        private void αθλητικάΠαπούτσιαToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεν έχετε αθλητικά παπούτσια!");
            {
                if (MessageBox.Show("Θέλετε να αγοράσετε αθλητικά παπούτσια?", "Αθλητικα παπούτσια", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.nike.com/gr/w/running-shoes-37v7jzy7ok");

                }
            }
        }
    }
}
