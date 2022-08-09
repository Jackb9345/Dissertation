using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Text;
using System.Threading;




namespace test
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class HomeScreen : Form
    {
        private string path;
        private string path2;
        private string hyperlink;

        public HomeScreen()
        {
            InitializeComponent();

            this.Text = "AssistantU";   //Program Name
            navBar.BringToFront();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Navigation Click Event
            toolStripMenuItem1.Click += new EventHandler(this.item1Clicked);
            toolStripMenuItem4.Click += new EventHandler(this.item4Clicked);
            toolStripMenuItem5.Click += new EventHandler(this.item5Clicked);
            toolStripMenuItem6.Click += new EventHandler(this.item6Clicked);
        }


        //Open New Pages On-Click
        private void item1Clicked(object sender, EventArgs e)
        {
            TextSize recommendedForm = new TextSize();
            recommendedForm.Show(this);
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

        private void item6Clicked(object sender, EventArgs e)
        {
            step1Label narratorForm = new step1Label();
            narratorForm.Show();
            this.Hide();
        }

        private void navBarButton_Click(object sender, EventArgs e)
        {


        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Personalisation & User Input
            string userName = Environment.UserName;
            string newText = searchBox.Text;

            //Enter Key Pressed & Command Features
            if (e.KeyCode == Keys.Enter)
            {
                userText.Text += Environment.NewLine + "    " + newText;

                File.AppendAllText(path, Environment.NewLine + newText);    //Output input to file
                File.AppendAllText(path2, Environment.NewLine + chatField.Text);    //Command results to output file

                if (newText =="files" || newText == "Files")
                {
                    //File explorer shortcut
                    chatField.Text += Environment.NewLine + "   " + "Opening Your Files, " + userName;
                    System.Diagnostics.Process.Start("explorer.exe");
                }
                else if (newText == "email" || newText == "Email")
                {
                    //Email shortcut
                    chatField.Text = "Opening Your Emails, " + userName;
                    System.Diagnostics.Process.Start("C:/Program Files/Microsoft Office/root/Office16/OUTLOOK.EXE");
                }
                else if (newText == "clear" || newText == "Clear")
                {
                    //Clear chat log function
                    chatField.Clear();
                    userText.Clear();
                    File.Delete(@"C:\temp\userInput.txt");
                    File.Delete(@"C:\temp\userOutput.txt");
                }
                else
                {
                    //YouTube search function call
                    Main1(null, newText, searchBox, chatField);
                }
            }
        }


        static private void updatedChat(string newSearchTerm, RichTextBox chatField, string hyperlink)
        {
            //Updates chat boxes with search results from YouTube API
            string url = "https://www.youtube.com/results?search_query=" + hyperlink;
            chatField.Text += Environment.NewLine + "   " + newSearchTerm;
            chatField.Text += Environment.NewLine + url;

            //Open YouTube search results
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.youtube.com/search?q=" + hyperlink,
                UseShellExecute = true
            });

        }

        private void chatField_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_Click_1(object sender, EventArgs e)
        {
            //Auto removes search box text
            searchBox.Text = "";
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            //INPUT File creation & write to
            string sepratedPath = @"C:\temp";
            string sepratedFileName = "userInput.txt";

            path = Path.Combine(sepratedPath, sepratedFileName);

            if (!File.Exists(path))
            {
                using FileStream fs = File.Create(path);
            }

            //Chat contents output to chatLog files
            string userInput = System.IO.File.ReadAllText(@"C:\temp\userInput.txt");
            userText.Text = userInput;

            //OUTPUT File creation & write to
            string separatedPath2 = @"C:\temp";
            string sepratedFileName2 = "userOutput.txt";

            path2 = Path.Combine(separatedPath2, sepratedFileName2);

            if (!File.Exists(path2))
            {
                using FileStream fs = File.Create(path2);
            }

            //Chat contents output to chatLog files
            string userOutput = System.IO.File.ReadAllText(@"C:\temp\userOutput.txt");
            chatField.Text = userOutput;

            marginCommandBox.SendToBack();
        }

        private void navBarButton_MouseHover(object sender, EventArgs e)
        {
            //Open NAV Bar
            navBar.Visible = true;
        }

        private void navBarButton_MouseLeave(object sender, EventArgs e)
        {
            //Close NAV Bar
            navBar.Visible = false;
        }

        public async Task Main1(string[] args, string newText, TextBox searchBox, RichTextBox chatField)
        {
            //Try YouTube search
            try
            {
                await new Search().Run(newText, searchBox, chatField);
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {

                }
            }
        }



        private void chatField_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //Open YouTube search results
           // System.Diagnostics.Process.Start(new ProcessStartInfo
           //{
           //     FileName = "http://www.youtube.com/search?q=" + hyperlink,
           //     UseShellExecute = true
           // });
        }

        private void searchBox_MouseLeave(object sender, EventArgs e)
        {
            searchBox.Text = "Search Box";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Resising text functionality
            userText.Font = new Font(userText.Font.FontFamily, changeTextSize.Value);
            chatField.Font = new Font(chatField.Font.FontFamily, changeTextSize.Value);
            navBar.Font = new Font(navBar.Font.FontFamily, changeTextSize.Value);
            searchBox.Font = new Font(searchBox.Font.FontFamily, changeTextSize.Value);
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {

        }

        private void marginCommandBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}