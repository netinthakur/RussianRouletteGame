using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace RussianRouletteGame
{

    public partial class Game : Form
    {
       int mFireCount = 6;
       int nextNumber;
       int HeadShot = 0;
       Random randomBullet = new Random();
       public static int score = 0;

        public Game()
        {
            InitializeComponent();
            

        }

        
        
        // Reversing image (based upon radio button)
        
        private void rbHead_CheckedChanged(object sender, EventArgs e)
        {
            pbPistol.Image = Properties.Resources.pistol;
            btnFire.Enabled = true;
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pbPistol.Image = Properties.Resources.colt_revolver_pistol;
            btnFire.Enabled = true;
           
        }

        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            btnSpin.Enabled = true;

            // Soundplayer to perform audio actions 
            System.IO.Stream str = Properties.Resources.Gun_Cocking_Slow_Mike_Koenig_1019236976;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit Event
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath); 
            Application.Exit(); 
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            
            rbHead.Enabled = true;
            rbAway.Enabled = true;

            // Soundplayer to perform audio actions
            System.IO.Stream str = Properties.Resources.RevolverSpin;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            // Generates random number between 1 and 7 
            nextNumber= randomBullet.Next(1, 7);
           
        }

        
        private void btnFire_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.pistol_shot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();


            btnSpin.Enabled = false;
            btnLoad.Enabled = false;

            mFireCount = mFireCount - 1;

            if (mFireCount == 5)
            {
                pb1.Visible = !pb1.Visible;

            }
            else if (mFireCount == 4)
            {
                pb2.Visible = !pb2.Visible;
            }
            else if (mFireCount == 3)
            {
                pb3.Visible = !pb3.Visible;
            }
            else if (mFireCount == 2)
            {
                pb4.Visible = !pb4.Visible;
            }
            else if (mFireCount == 1)
            {
                pb5.Visible = !pb5.Visible;
            }
            else if (mFireCount == 0)
            {
                pb6.Visible = !pb6.Visible;
                                          

            }

            if (rbHead.Checked)
            {
               HeadShot = HeadShot + 1;              
            }
            if (HeadShot == 2)
            {
                rbHead.Enabled = false;
                rbAway.Checked = true;
            }

            if (nextNumber == mFireCount && rbAway.Checked)
            {

                MessageBox.Show("Oops! You Lost.");

                // Play again messageBox
                if (MessageBox.Show("Do you want to play another round?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
     
                    Fresh();
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    Application.Exit();
                }

            }
            else if (nextNumber == mFireCount && rbHead.Checked)
            {
                score = score + 1;

                MessageBox.Show("Congratulations! You have won this round.");

                // Play again messageBox
                if (MessageBox.Show("Play again?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // If yes is clicked
                    // Calls function                   
                   Fresh();
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); //Start new instance of app
                    Application.Exit(); //Turn off current app 
                }

            }

           
            
            

           












        }

        
        private void Game_Load(object sender, EventArgs e)
        {
            // Disabled buttons on form load
            btnSpin.Enabled = false;
            rbHead.Enabled = false;
            rbAway.Enabled = false;
            btnFire.Enabled = false;
        }

        public void Fresh()
        {
            mFireCount = 6;
            HeadShot = 0;                      
            btnLoad.Enabled = true;
            rbAway.Enabled = true;
            rbHead.Enabled = true;
            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb4.Visible = true;
            pb5.Visible = true;
            pb6.Visible = true;
            rbHead.Enabled = false;
            rbAway.Enabled = false;
        }

    }
}
