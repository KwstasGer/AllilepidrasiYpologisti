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
    public partial class CasualShoes : Form
    {
        public CasualShoes()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void κατοικιδιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katoikidio kat = new Katoikidio();
            kat.ShowDialog();
            this.Close();
        }
    }
}
