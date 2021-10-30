using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace simpleRPGv22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.MouseEnter += new EventHandler(btnStart_MouseEnter);
            btnStart.MouseLeave += new EventHandler(btnStart_MouseLeave);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Write("Robie zmiane");
            btnStart.BackgroundImage = simpleRPGv22.Properties.Resources.btnStart_not_pressedv5;
            btnExit.BackgroundImage = simpleRPGv22.Properties.Resources.btnExit_not_pressed;

           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            

                lblHp.Text = "500";

                lblMp.Text = "100";

                lblStr.Text = "10";

                lblDex.Text = "7";

                lblInt.Text = "4";

            pnlCreator.Visible = true;






        }

        private void btnQuit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = simpleRPGv22.Properties.Resources.btnStart_not_pressedv5;
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = simpleRPGv22.Properties.Resources.btnStart_pressed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = simpleRPGv22.Properties.Resources.btnExit_not_pressed;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = simpleRPGv22.Properties.Resources.btnExit_pressed;
        }

        private void btnArrowLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            if (imgAvatarWarrior.Visible)
            {
                

                imgAvatarMage.Visible = true;

                imgAvatarWarrior.Visible = false;


                lblHp.Text = "250";

               

                lblMp.Text = "350";

                
                lblStr.Text = "4";
                


                lblDex.Text = "7";
                


                lblInt.Text = "10";

                

            }
            else if (imgAvatarMage.Visible)
            {
                imgAvatarWarrior.Visible = true;

                imgAvatarMage.Visible = false;

                
                lblHp.Text = "500";

                

                lblMp.Text = "100";

                

                lblStr.Text = "10";

                

                lblDex.Text = "7";

                

                lblInt.Text = "4";
               

            }
        }

        private void pnlCreator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHp_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnArrowLeft_MouseEnter(object sender, EventArgs e)
        {
            btnArrowLeft.Image = simpleRPGv22.Properties.Resources.btnArrowLeftPressed;
        }

        private void btnArrowLeft_MouseLeave(object sender, EventArgs e)
        {
            btnArrowLeft.Image = simpleRPGv22.Properties.Resources.imgChooseArrow;
        }

        private void btnArrowRight_MouseEnter(object sender, EventArgs e)
        {
            btnArrowRight.Image = simpleRPGv22.Properties.Resources.btnArrowRightPressed;
        }

        private void btnArrowRight_MouseLeave(object sender, EventArgs e)
        {
            btnArrowRight.Image = simpleRPGv22.Properties.Resources.imgChooseArrowRight;
        }

        private void lblMp_paint(object sender, EventArgs e)
        {

        }

        private void lblMp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void imgHP_Click(object sender, EventArgs e)
        {

        }
    }
}
