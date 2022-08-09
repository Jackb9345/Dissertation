using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class MousePointer : Form
    {
        public MousePointer()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void mousePointerNavBar_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripMenuItem1.Click += new EventHandler(this.item1Clicked);
            toolStripMenuItem11.Click += new EventHandler(this.item2Clicked);
            toolStripMenuItem3.Click += new EventHandler(this.item3Clicked);
            toolStripMenuItem5.Click += new EventHandler(this.item5Clicked);
        }

        private void item1Clicked(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show(this);
            this.Hide();
        }
        private void item2Clicked(object sender, EventArgs e)
        {
            TextSize textChange = new TextSize();
            textChange.Show(this);
            this.Hide();
        }


        private void item3Clicked(object sender, EventArgs e)
        {
            TextCursor textCursorForm = new TextCursor();
            textCursorForm.Show();
            this.Hide();
        }

        private void item5Clicked(object sender, EventArgs e)
        {
            step1Label narratorForm = new step1Label();
            narratorForm.Show();
            this.Hide();
        }


        private void mousePointerNavBar_MouseHover(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
        }

        private void mousePointerNavBar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            menuStrip1.BringToFront();
            menuStrip1.Visible = true;
            
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        int pressVal2 = 1; 
        private void rightSlide_Click(object sender, EventArgs e)
        {

            string step1Label = " 1. Open the Windows Search box located in the bottom left corner. Search 'Mouse Pointer'.";
            string step2Label = " 2. Click the button shown that reads 'Change the mouse pointer display or speed. '";
            string step3Label = " 3. Adjust the options to fit your needs as shown ";


            pressVal2 = pressVal2 + 1;
            if (pressVal2 == 1)
            {
                step1.Show(); //GIF 1
                step2.Hide();
                step3.Hide();
                step1L.Show();
                step2L.Hide();
                step3L.Hide();
            }
            else if (pressVal2 == 2)
            {
                step1.Show();  //GIF 2
                step2.Show();
                step3.Hide();
                step1L.Hide();
                step2L.Show();
                step3L.Hide();
                mousePointerTut.AppendText(Environment.NewLine + Environment.NewLine + step2Label);
            }
            else if (pressVal2 == 3)
            {
                step1.Show(); //GIF 3
                step2.Show();
                step3.Show();
                step1L.Hide();
                step2L.Hide();
                step3L.Show();
                mousePointerTut.AppendText(Environment.NewLine + Environment.NewLine + step3Label);
            }
            if (pressVal2 == 4)
            {
                step1.Show(); //GIF 1
                step2.Hide();
                step3.Hide();
                step1L.Show();
                step2L.Hide();
                step3L.Hide();
                pressVal2 = 1;
                mousePointerTut.Text = step1Label;
            }
        }

        private void changeTextSize_Scroll(object sender, EventArgs e)
        {
            mousePointerTut.Font = new Font(mousePointerTut.Font.FontFamily, changeTextSize.Value);
        }
    }
}
