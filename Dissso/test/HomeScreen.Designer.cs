namespace test
{
    partial class HomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.functionOptions = new System.Windows.Forms.Label();
            this.navBarButton = new System.Windows.Forms.Button();
            this.chatField = new System.Windows.Forms.RichTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.userText = new System.Windows.Forms.RichTextBox();
            this.changeTextSize = new System.Windows.Forms.TrackBar();
            this.textSizeLabel = new System.Windows.Forms.Label();
            this.marginCommandBox = new System.Windows.Forms.Panel();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.searchBox.Location = new System.Drawing.Point(19, 496);
            this.searchBox.MaximumSize = new System.Drawing.Size(360, 60);
            this.searchBox.MinimumSize = new System.Drawing.Size(370, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(370, 60);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click_1);
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            this.searchBox.MouseLeave += new System.EventHandler(this.searchBox_MouseLeave);
            // 
            // navBar
            // 
            this.navBar.AllowDrop = true;
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.navBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navBar.GripMargin = new System.Windows.Forms.Padding(2, 4, 0, 2);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.navBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navBar.Size = new System.Drawing.Size(131, 568);
            this.navBar.TabIndex = 2;
            this.navBar.TabStop = true;
            this.navBar.Text = "Windows Basic Features";
            this.navBar.Visible = false;
            this.navBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.navBar.MouseLeave += new System.EventHandler(this.navBarButton_MouseLeave);
            this.navBar.MouseHover += new System.EventHandler(this.navBarButton_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FloralWhite;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem1.Text = "Text Size";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FloralWhite;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem4.Text = "Text Cursor";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FloralWhite;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem5.Text = "Mouse Pointer";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FloralWhite;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem6.Text = "Narrator";
            // 
            // functionOptions
            // 
            this.functionOptions.AutoSize = true;
            this.functionOptions.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.functionOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.functionOptions.Location = new System.Drawing.Point(79, 14);
            this.functionOptions.Name = "functionOptions";
            this.functionOptions.Size = new System.Drawing.Size(111, 25);
            this.functionOptions.TabIndex = 3;
            this.functionOptions.Text = "AssistantU";
            // 
            // navBarButton
            // 
            this.navBarButton.BackColor = System.Drawing.Color.Transparent;
            this.navBarButton.FlatAppearance.BorderSize = 0;
            this.navBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navBarButton.Image = ((System.Drawing.Image)(resources.GetObject("navBarButton.Image")));
            this.navBarButton.Location = new System.Drawing.Point(19, 11);
            this.navBarButton.Name = "navBarButton";
            this.navBarButton.Size = new System.Drawing.Size(54, 34);
            this.navBarButton.TabIndex = 5;
            this.navBarButton.UseVisualStyleBackColor = false;
            this.navBarButton.Click += new System.EventHandler(this.navBarButton_Click);
            this.navBarButton.MouseHover += new System.EventHandler(this.navBarButton_MouseHover);
            // 
            // chatField
            // 
            this.chatField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.chatField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatField.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatField.ForeColor = System.Drawing.Color.White;
            this.chatField.Location = new System.Drawing.Point(203, 52);
            this.chatField.Margin = new System.Windows.Forms.Padding(10, 3, 6, 3);
            this.chatField.Name = "chatField";
            this.chatField.ReadOnly = true;
            this.chatField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatField.Size = new System.Drawing.Size(187, 424);
            this.chatField.TabIndex = 7;
            this.chatField.Text = "";
            this.chatField.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.chatField_LinkClicked);
            this.chatField.TextChanged += new System.EventHandler(this.chatField_TextChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(93, 19);
            this.toolStripMenuItem3.Text = "Recommended";
            // 
            // userText
            // 
            this.userText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userText.ForeColor = System.Drawing.Color.White;
            this.userText.Location = new System.Drawing.Point(33, 52);
            this.userText.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(172, 424);
            this.userText.TabIndex = 8;
            this.userText.Text = "";
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            // 
            // changeTextSize
            // 
            this.changeTextSize.Location = new System.Drawing.Point(286, 5);
            this.changeTextSize.Maximum = 20;
            this.changeTextSize.Minimum = 10;
            this.changeTextSize.Name = "changeTextSize";
            this.changeTextSize.Size = new System.Drawing.Size(104, 45);
            this.changeTextSize.TabIndex = 9;
            this.changeTextSize.Value = 10;
            this.changeTextSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textSizeLabel
            // 
            this.textSizeLabel.AutoSize = true;
            this.textSizeLabel.ForeColor = System.Drawing.Color.White;
            this.textSizeLabel.Location = new System.Drawing.Point(310, 33);
            this.textSizeLabel.Name = "textSizeLabel";
            this.textSizeLabel.Size = new System.Drawing.Size(51, 15);
            this.textSizeLabel.TabIndex = 10;
            this.textSizeLabel.Text = "Text Size";
            // 
            // marginCommandBox
            // 
            this.marginCommandBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.marginCommandBox.Location = new System.Drawing.Point(19, 52);
            this.marginCommandBox.Name = "marginCommandBox";
            this.marginCommandBox.Size = new System.Drawing.Size(186, 424);
            this.marginCommandBox.TabIndex = 12;
            this.marginCommandBox.Paint += new System.Windows.Forms.PaintEventHandler(this.marginCommandBox_Paint);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(400, 568);
            this.Controls.Add(this.marginCommandBox);
            this.Controls.Add(this.textSizeLabel);
            this.Controls.Add(this.changeTextSize);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.chatField);
            this.Controls.Add(this.navBarButton);
            this.Controls.Add(this.functionOptions);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.Label functionOptions;
        private System.Windows.Forms.Button navBarButton;
        private System.Windows.Forms.RichTextBox chatField;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.RichTextBox userText;
        private System.Windows.Forms.TrackBar changeTextSize;
        private System.Windows.Forms.Label textSizeLabel;
        private System.Windows.Forms.Panel marginCommandBox;
    }
}

