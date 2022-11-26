using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgasiaAllilepidrasiYpologisti
{
    public partial class Katoikidio : Form
    {
        private int maxtime;
        private int fagito = 4;
        private int nero = 2;

        public Katoikidio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Πειναω");
            //MessageBox.Show("Δειψάω");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //maxtime = 0;

            if (timer1.Enabled == true)
            {
                SoundPlayer player = new SoundPlayer("GAV.wav");
                player.Play();
            }
            MessageBox.Show("Δειψάω και Πεινάω");
           

            //maxtime += 1;
            //if (maxtime == 4);
            //MessageBox.Show("Πεινάω");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void Katoikidio_Load(object sender, EventArgs e)
        {

        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (timer1.Enabled == false)
            {
                SoundPlayer player = new SoundPlayer("GAV.wav");
                player.Stop();

            }
            MessageBox.Show("Κάθε 2 ώρες βάλε φαγητό στο σκύλο");
            fagito -= 1;
            if (fagito == 0)
            {
                MessageBox.Show("Το φαγητό του σκύλου τελείωσε \n \n Βάλε φαγητό στον σκύλο!");
                fagito = 4;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (timer1.Enabled == false)
            {
                SoundPlayer player = new SoundPlayer("GAV.wav");
                player.Stop();
            }
            MessageBox.Show("Κάθε μισή ώρα βάλε νερό στο σκύλο");
            nero -= 1;
            if (nero == 0)
            {
                MessageBox.Show("Το νερό του σκύλου τελείωσε \n \n Βάλε νερό στον σκύλο!");
                nero = 4;
            }
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
            SoundPlayer player = new SoundPlayer("GAV.wav");
            player.Stop();
        }

        private void κατοικίδιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katoikidio kat = new Katoikidio();
            kat.ShowDialog();
            this.Close();
        }

        private void επίσημαΠαπούτσιαToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormalShoes formalshoe = new FormalShoes();
            formalshoe.ShowDialog();
            this.Close();
            
        }

        private void παπουτσοθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void αθλητικάΠαπούτσιαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("GAV.wav");
            player.Stop();
            this.Hide();
            CasualShoes casualshoe = new CasualShoes();
            casualshoe.ShowDialog();
            this.Close();
            
        }

        private void εβδομαδιαίοΠρόγραμμαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("GAV.wav");
            player.Stop();
            this.Hide();
            WeekendProgram form1 = new WeekendProgram();
            form1.ShowDialog();
            this.Close();
            
        }
    }
}
