using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class TextSize : Form
    {
        public TextSize()
        {
            InitializeComponent();
        }

        private void TextSize_Load(object sender, EventArgs e)
        {
            navBar.BringToFront();
            step2.Hide();
            step3.Hide();
            this.Text = "AssistantU - Text Size";
        }

        private void openNav_MouseHover(object sender, EventArgs e)
        {
            navBar.Visible = true;
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
        private void nextSlide_Click(object sender, EventArgs e)
        {
            string step1L = " 1. Open the Windows Search Box located in the bottom left side of your screen and type 'Text Size'";
            string step2L = " 2. Right click the button that says 'make text size bigger' ";
            string step3L = " 3. Adjust the settings as shown to fit your needs ";

            pressVal2 = pressVal2 + 1;
            if (pressVal2 == 1)
            {
                stepLabel.Text = "Step 1";  //GIF 1
                step1.Show();
                step2.Hide();
                step3.Hide();
            }
            else if (pressVal2 == 2)
            {
                stepLabel.Text = "Step 2";  //GIF 2
                step1.Show();
                step2.Show();
                step3.Hide();
                textSizeTut.AppendText(Environment.NewLine + Environment.NewLine + step2L);
            }
            else if (pressVal2 == 3)
            {
                stepLabel.Text = "Step 3";  //GIF 3
                step1.Show();
                step2.Show();
                step3.Show();
                textSizeTut.AppendText(Environment.NewLine + Environment.NewLine + step3L);
            }
            if (pressVal2 == 4)
            {
                stepLabel.Text = "Step 1"; //GIF 1
                step1.Show();
                step2.Hide();
                step3.Hide();
                pressVal2 = 1;
                textSizeTut.Text = step1L;
            }
        }

        private void navBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripMenuItem1.Click += new EventHandler(this.item1Clicked);
            toolStripMenuItem2.Click += new EventHandler(this.item2Clicked);
            toolStripMenuItem3.Click += new EventHandler(this.item3Clicked);
            toolStripMenuItem4.Click += new EventHandler(this.item4Clicked);

        }

        private void item1Clicked(object sender, EventArgs e)
        {
            HomeScreen homeScreenForm = new HomeScreen();
            homeScreenForm.Show(this);
            this.Hide();
        }

        private void item2Clicked(object sender, EventArgs e)
        {
            step1Label narratorForm = new step1Label();
            narratorForm.Show();
            this.Hide();
        }


        private void item3Clicked(object sender, EventArgs e)
        {
            TextCursor textCursorForm = new TextCursor();
            textCursorForm.Show();
            this.Hide();
        }

        private void item4Clicked(object sender, EventArgs e)
        {
            MousePointer mousePointerForm = new MousePointer();
            mousePointerForm.Show();
            this.Hide();
        }

        private void changeTextSize_Scroll(object sender, EventArgs e)
        {
            textSizeTut.Font = new Font(textSizeTut.Font.FontFamily, changeTextSize.Value);

        }
    }
}
