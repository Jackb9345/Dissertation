using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class TextCursor : Form
    {
        public TextCursor()
        {
            InitializeComponent();
            this.Text = "AssistantU - Text Cursor Options";
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripMenuItem1.Click += new EventHandler(this.item1Clicked);
            toolStripMenuItem2.Click += new EventHandler(this.item2Clicked);
            toolStripMenuItem5.Click += new EventHandler(this.item5Clicked);
            toolStripMenuItem6.Click += new EventHandler(this.item6Clicked);
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

        private void item5Clicked(object sender, EventArgs e)
        {
            MousePointer mousePointerForm = new MousePointer();
            mousePointerForm.Show();
            this.Hide();
        }

        private void item6Clicked(object sender, EventArgs e)
        {
            step1Label narratorForm = new step1Label();
            narratorForm.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            navBar.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void TextCursor_Load(object sender, EventArgs e)
        {
            step2Label.BringToFront();
            navBar.BringToFront();
        }

        private void navBar_MouseHover(object sender, EventArgs e)
        {
            navBar.Visible = true;
        }

        private void navBar_MouseLeave(object sender, EventArgs e)
        {
            navBar.Visible = false;
        }

        int pressVal2 = 1;
        private void forwardSlide_Click(object sender, EventArgs e)
        {
            string step1L = " 1. Open the Windows Search Box located in the bottom left hand corner. Search 'Text Cursor'.";
            string step2L = " 2. Right click the button shown which says 'change cursor thickness' ";
            string step3L = " 3. Change the settings shown in step 3 to your needs ";

            pressVal2 = pressVal2 + 1;
            if (pressVal2 == 1)
            {
                step1.Show(); //GIF 1
                step2.Hide();
                step3.Hide();
                step1Label.Show();
                step2Label.Hide();
                step3Label.Hide();
            }
            else if (pressVal2 == 2)
            {
                //backPressed = true; //GIF 2
                step1.Show();
                step2.Show();
                step3.Hide();
                step1Label.Hide();
                step2Label.Show();
                step3Label.Hide();
                textCursorTut.AppendText(Environment.NewLine + Environment.NewLine + step2L);
            }
            else if (pressVal2 == 3)
            {
                step1.Show(); //GIF 3
                step2.Show();
                step3.Show();
                step1Label.Hide();
                step2Label.Hide();
                step3Label.Show();
                textCursorTut.AppendText(Environment.NewLine + Environment.NewLine + step3L);
            }
            if (pressVal2 == 4)
            {
                step1.Show(); //GIF 1
                step2.Hide();
                step3.Hide();
                step1Label.Show();
                step2Label.Hide();
                step3Label.Hide();
                pressVal2 = 1;
                textCursorTut.Text = step1L;
            }
        }


        private void step2_Click(object sender, EventArgs e)
        {

        }

        private void changeTextSize_Scroll(object sender, EventArgs e)
        {
            textCursorTut.Font = new Font(textCursorTut.Font.FontFamily, changeTextSize.Value);
        }
    }
}
