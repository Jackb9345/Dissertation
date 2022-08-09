using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class step1Label : Form
    {
        public step1Label()
        {
            InitializeComponent();
            narratorNav.BringToFront();

            this.Text = "A ssistantU - Narrator";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            narratorNav.Visible = false;
            openNav.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripMenuItem1.Click += new EventHandler(this.item1Clicked);
            toolStripMenuItem2.Click += new EventHandler(this.item2Clicked);
            toolStripMenuItem4.Click += new EventHandler(this.item4Clicked);
            toolStripMenuItem5.Click += new EventHandler(this.item5Clicked);
        }

        private void item1Clicked(object sender, EventArgs e)
        {
            HomeScreen recommendedForm = new HomeScreen();
            recommendedForm.Show(this);
            this.Hide();
        }

        private void item2Clicked(object sender, EventArgs e)
        {
            TextSize textSizeForm = new TextSize();
            textSizeForm.Show(this);
            this.Hide();
        }

        private void item4Clicked(object sender, EventArgs e)
        {
            TextCursor textCursorForm = new TextCursor();
            textCursorForm.Show();
            this.Hide();
        }

        private void item5Clicked(object sender, EventArgs e)
        {
            MousePointer mousePointerForm = new MousePointer();
            mousePointerForm.Show();
            this.Hide();
        }

        private void Narrator_Load(object sender, EventArgs e)
        {
            narratorNav.BringToFront();
            this.Text = "AssistantU - Narration";
        }

        private void openNav_MouseHover(object sender, EventArgs e)
        {
            narratorNav.Visible = true;
            narratorNav.BringToFront();
        }

        private void openNav_MouseLeave(object sender, EventArgs e)
        {
            //narratorNav.Visible = false;
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            narratorNav.Visible = true;
            narratorNav.BringToFront();
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            narratorNav.Visible = false;
        }

        int pressVal2 = 1;
        private void forwardSlide_Click(object sender, EventArgs e)
        {
            //Tutorial strings used in the explanation textbox
            string step1Tut = " - Open the Windows Search box located in the bottom right of your screen and type 'Narrator'";
            string step2Tut = " - Right click the button shown to open the Narrator application";
            string step3Tut = " - Right click on the QuickStart button to begin an overview on using the feature";

            pressVal2 = pressVal2 + 1;
            if (pressVal2 == 1)
            {
                step1.Show(); //GIF 1
                step2.Hide();
                step3.Hide();
                labelstep1.Show();
                step2Label.Hide();
                step3Label.Hide();

            }
            else if (pressVal2 == 2)
            {
                step1.Show(); //GIF 2
                step2.Show();
                step3.Hide();
                labelstep1.Show();
                step2Label.Show();
                step3Label.Hide();
                stepsInfo.AppendText(Environment.NewLine + Environment.NewLine + step2Tut);
            }
            else if (pressVal2 == 3)
            {
                step1.Show(); //GIF 3
                step2.Show();
                step3.Show();
                labelstep1.Hide();
                step2Label.Hide();
                step3Label.Show();
                stepsInfo.AppendText(Environment.NewLine + Environment.NewLine + step3Tut);
            }
            if (pressVal2 == 4)
            {
                step1.Show(); //GIF 1
                step2.Hide();
                step3.Hide();
                labelstep1.Show();
                step2Label.Hide();
                step3Label.Hide();
                stepsInfo.Text = step1Tut;
                pressVal2 = 1;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeTextSize_Scroll(object sender, EventArgs e)
        {
            stepsInfo.Font = new Font(stepsInfo.Font.FontFamily, changeTextSize.Value);
        }
    }
}
