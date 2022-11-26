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
    public partial class WeekendProgram : Form
    {
        public WeekendProgram()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Θέλετε να πάτε στο γυμναστήριο?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e2");
                    //Process.Start("https://goo.gl/maps/seyrGs95sQwVZCe48");
                }
            }
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

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

        private void label34_Click(object sender, EventArgs e)
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

        private void κατοικίδιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katoikidio kat = new Katoikidio();
            kat.ShowDialog();
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
           
            {
                if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                    Process.Start("https://goo.gl/maps/3eYrPYgVb8o3P1Zc6");
                    //Process.Start("<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3146.5255210610617!2d23.650679415152478!3d37.94151367972935!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a1bbe5bb8515a1%3A0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!5e0!3m2!1sel!2sgr!4v1669424721100!5m2!1sel!2sgr" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>")
                }
            }
        }
    }
}
