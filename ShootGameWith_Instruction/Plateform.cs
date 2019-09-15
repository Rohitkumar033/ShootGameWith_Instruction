using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootGameWith_Instruction
{
    public partial class Plateform : Form
    {
        int stages = 0,first_Fire=0,secnd_Fire=0,shoot_click=0,shotAway_click=0;
        
        Random rd = new Random();

        public Plateform()
        {
            InitializeComponent();
            //calling the method of the first fire to fire the first bullet
            firstFire();
            secndFire();
        }
        //this code is used to fetch the trigger count when the bullet fire sound will be hear
        public int firstFire() {
            first_Fire = rd.Next(1, 6);
            return first_Fire;
        }
        //this code is used to fetch the trigger count when the bullet fire sound will be hear
        public int secndFire()
        {
            secnd_Fire = rd.Next(6, 12);
            return secnd_Fire;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //this is The first step of the game after that we can load the gun woth bullet
            stages=1;

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ShootGameWith_Instruction.Resources.first.jpg");
            Bitmap bmp = new Bitmap(myStream);
            pictureBox1.Image = bmp;
            
        }

        private void again_Click(object sender, EventArgs e)
        {
            //code to restart the game once again
            stages = 0; first_Fire = 0; secnd_Fire = 0; shoot_click = 0; shotAway_click = 0;
            firstFire();
            secndFire();
            again.Visible = false;
            ShtAway.Enabled = true;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ShtAway_Click(object sender, EventArgs e)
        {
            // this is the forth stage of the game here we have only 2 chance to fire and can have 2 click 
            if (stages==4) {
                shotAway_click++;
                if (shotAway_click>=1) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(ShootGameWith_Instruction.Properties.Resources.fire);
                    player.Play();
                    
                    
                    stages = 5;
                    shotAway_click = 2;
                        MessageBox.Show("You are the winner of the game");
                    ShtAway.Enabled = false;

                    again.Visible = true;
                }
                if (shotAway_click==3) {
                    stages = 5;
                    shotAway_click = 3;
                    MessageBox.Show("you won 100 dollar ");
                    ShtAway.Enabled = false;
                    again.Visible = true;
                }
                if (shotAway_click>4) {
                    MessageBox.Show("your game is over click on try again to play the game once again ");
                    ShtAway.Enabled = false;
                }

            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (stages == 1)
            {
                //this is the 2nd step of the source code in this code the gun load the bullet 

                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream("ShootGameWith_Instruction.Resources.2nd.jpg");
                Bitmap bmp = new Bitmap(myStream);
                pictureBox1.Image = bmp;
                
                stages=2;
            }
            else {
                MessageBox.Show("follow the instruction to play the game ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stages == 2)
            {
                // this is the 3rd stages of the game in this after loading the bullet in the gun spin the roller of the gun
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream("ShootGameWith_Instruction.Resources.spin.jpg");
                Bitmap bmp = new Bitmap(myStream);
                pictureBox1.Image = bmp;

                stages=3;
            }
            else {
                MessageBox.Show("follow the instruction to play the game ");
            }
        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            //this is the 4 stage of the game where we can click 12 times and have 2 bullet to fire 
            if (stages == 3)
            {

                shoot_click++;

                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream("ShootGameWith_Instruction.Resources.third.jpg");
                Bitmap bmp = new Bitmap(myStream);
                pictureBox1.Image = bmp;
                
                if (shoot_click == first_Fire)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(ShootGameWith_Instruction.Properties.Resources.shootsd);
                    player.Play();
                }
                else if(shoot_click<=6){
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(ShootGameWith_Instruction.Properties.Resources.shootsd);
                    player.Play();
                }
                if (secnd_Fire == shoot_click) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(ShootGameWith_Instruction.Properties.Resources.shootsd);
                    player.Play();
                } else if (shoot_click>6 && shoot_click<=6) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(ShootGameWith_Instruction.Properties.Resources.shootsd);
                    player.Play();
                }
                if (shoot_click>=6) {
                    stages = 4;
                    MessageBox.Show("you lose the game");
                }
                
            }
            else {
                MessageBox.Show("follow the instruction to play the game ");
            }
        }
    }
}
