using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Invaders : Form {

        Invader[] invaders = new Invader[6];
        PictureBox[] pictureBoxes;

        private int aantalSteden;
        private int invaderLevens;
        private int aantalInvaders = 6;
        private int invaderSnelheid;

        Random random = new Random();

        public Invaders() {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            numericUpDownAantalSteden.Enabled = false;
            numericUpDownInvaderLevens.Enabled = false;
            numericUpDownInvaderSnelheid.Enabled = false;

            invaderLevens = Convert.ToInt32(numericUpDownInvaderLevens.Value);
            invaderSnelheid = Convert.ToInt32(numericUpDownInvaderSnelheid.Value);
            aantalSteden = Convert.ToInt32(numericUpDownAantalSteden.Value);

            labelAantalStedenValue.Text = aantalSteden.ToString();

            for (int i = 0; i < invaders.Length; i++)
            {
                invaders[i] = new Invader(invaderLevens);
                foreach (PictureBox invaderBox in pictureBoxes)
                {
                    invaderBox.Visible = true;
                }
            }

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Invader invader in invaders)
            {
                int welOfNiet = random.Next(0, 2);

                if (invader.Positie < groupBoxInvaders.Height)
                {
                    if (welOfNiet == 1)
                    {
                        invader.beweegInvader(invaderSnelheid);
                        int id = invader.Id;
                        pictureBoxes[id].Location = new Point(pictureBoxes[id].Location.X, invader.Positie);
                        pictureBoxes[id].Update();
                    }
                }
                else
                {
                    aantalSteden--;
                    labelAantalStedenValue.Text = aantalSteden.ToString();

                    if (aantalSteden <= 0)
                    {
                        timer1.Stop();
                        MessageBox.Show("Helaas, je hebt verloren... Je steden zijn verwoest.");
                        this.Close();
                    }
                }
            }
        }

        private void processSelectedInvader(object sender) {
            PictureBox pictureBox = (PictureBox)sender;
            string pictureBoxName = ((PictureBox)sender).Name;
            int pictureBoxNameIndex = Convert.ToInt32(pictureBoxName.Remove(0, 10)) - 1;
            try
            {
                if (invaders[pictureBoxNameIndex].Levens > 0) {
                    invaders[pictureBoxNameIndex].verlaagLeven();
                } else {
                    pictureBox.Visible = false;
                    aantalInvaders--;
                    labelAantalInvadersValue.Text = aantalInvaders.ToString();

                    if (aantalInvaders == 0)
                    {
                        MessageBox.Show("Je hebt gewonnen! Gefeliciteerd!");
                        Close();
                    }
                }
            }
            catch (IndexOutOfRangeException) {
                MessageBox.Show("Er is een verkeerde waarde uitgekomen. Sluit het programma en probeer het opnieuw.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            processSelectedInvader(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            processSelectedInvader(sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e) {
            processSelectedInvader(sender);
        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            processSelectedInvader(sender);
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            processSelectedInvader(sender);
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            processSelectedInvader(sender);
        }

        private void Invaders_Load(object sender, EventArgs e)
        {
            pictureBoxes = new PictureBox[6] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = false;
            }
        }
    }
}