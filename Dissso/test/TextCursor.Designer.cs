namespace test
{
    partial class TextCursor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextCursor));
            this.topPanel = new System.Windows.Forms.Panel();
            this.textSizeLabel = new System.Windows.Forms.Label();
            this.openNav = new System.Windows.Forms.Button();
            this.textCursorTitle = new System.Windows.Forms.Label();
            this.changeTextSize = new System.Windows.Forms.TrackBar();
            this.step1 = new System.Windows.Forms.Button();
            this.step1Label = new System.Windows.Forms.Label();
            this.step2Label = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.step3 = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.Button();
            this.forwardSlide = new System.Windows.Forms.Button();
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.textCursorTut = new System.Windows.Forms.RichTextBox();
            this.marginPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).BeginInit();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.topPanel.Controls.Add(this.textSizeLabel);
            this.topPanel.Controls.Add(this.openNav);
            this.topPanel.Controls.Add(this.textCursorTitle);
            this.topPanel.Controls.Add(this.changeTextSize);
            this.topPanel.Location = new System.Drawing.Point(0, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1332, 60);
            this.topPanel.TabIndex = 0;
            // 
            // textSizeLabel
            // 
            this.textSizeLabel.AutoSize = true;
            this.textSizeLabel.ForeColor = System.Drawing.Color.White;
            this.textSizeLabel.Location = new System.Drawing.Point(1038, 38);
            this.textSizeLabel.Name = "textSizeLabel";
            this.textSizeLabel.Size = new System.Drawing.Size(51, 15);
            this.textSizeLabel.TabIndex = 3;
            this.textSizeLabel.Text = "Text Size";
            // 
            // openNav
            // 
            this.openNav.FlatAppearance.BorderSize = 0;
            this.openNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNav.Image = ((System.Drawing.Image)(resources.GetObject("openNav.Image")));
            this.openNav.Location = new System.Drawing.Point(23, 11);
            this.openNav.Name = "openNav";
            this.openNav.Size = new System.Drawing.Size(72, 39);
            this.openNav.TabIndex = 2;
            this.openNav.UseVisualStyleBackColor = true;
            this.openNav.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.openNav.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textCursorTitle
            // 
            this.textCursorTitle.AutoSize = true;
            this.textCursorTitle.BackColor = System.Drawing.Color.Transparent;
            this.textCursorTitle.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textCursorTitle.ForeColor = System.Drawing.Color.White;
            this.textCursorTitle.Location = new System.Drawing.Point(143, 14);
            this.textCursorTitle.Name = "textCursorTitle";
            this.textCursorTitle.Size = new System.Drawing.Size(118, 25);
            this.textCursorTitle.TabIndex = 1;
            this.textCursorTitle.Text = "Text Cursor";
            // 
            // changeTextSize
            // 
            this.changeTextSize.Location = new System.Drawing.Point(1012, 5);
            this.changeTextSize.Maximum = 20;
            this.changeTextSize.Minimum = 10;
            this.changeTextSize.Name = "changeTextSize";
            this.changeTextSize.Size = new System.Drawing.Size(104, 45);
            this.changeTextSize.TabIndex = 4;
            this.changeTextSize.Value = 10;
            this.changeTextSize.Scroll += new System.EventHandler(this.changeTextSize_Scroll);
            // 
            // step1
            // 
            this.step1.FlatAppearance.BorderSize = 0;
            this.step1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step1.Image = ((System.Drawing.Image)(resources.GetObject("step1.Image")));
            this.step1.Location = new System.Drawing.Point(639, 385);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(440, 42);
            this.step1.TabIndex = 2;
            this.step1.UseVisualStyleBackColor = true;
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1Label.ForeColor = System.Drawing.Color.White;
            this.step1Label.Location = new System.Drawing.Point(734, 76);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(69, 25);
            this.step1Label.TabIndex = 3;
            this.step1Label.Text = "Step 1";
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step2Label.ForeColor = System.Drawing.Color.White;
            this.step2Label.Location = new System.Drawing.Point(734, 77);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(69, 25);
            this.step2Label.TabIndex = 4;
            this.step2Label.Text = "Step 2";
            this.step2Label.Visible = false;
            // 
            // step3Label
            // 
            this.step3Label.AutoSize = true;
            this.step3Label.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step3Label.ForeColor = System.Drawing.Color.White;
            this.step3Label.Location = new System.Drawing.Point(734, 76);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(69, 25);
            this.step3Label.TabIndex = 5;
            this.step3Label.Text = "Step 3";
            this.step3Label.Visible = false;
            // 
            // step3
            // 
            this.step3.FlatAppearance.BorderSize = 0;
            this.step3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step3.Image = ((System.Drawing.Image)(resources.GetObject("step3.Image")));
            this.step3.Location = new System.Drawing.Point(102, 131);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(489, 593);
            this.step3.TabIndex = 6;
            this.step3.UseVisualStyleBackColor = true;
            this.step3.Visible = false;
            // 
            // step2
            // 
            this.step2.FlatAppearance.BorderSize = 0;
            this.step2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step2.Image = ((System.Drawing.Image)(resources.GetObject("step2.Image")));
            this.step2.Location = new System.Drawing.Point(693, 495);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(332, 66);
            this.step2.TabIndex = 7;
            this.step2.UseVisualStyleBackColor = true;
            this.step2.Visible = false;
            this.step2.Click += new System.EventHandler(this.step2_Click);
            // 
            // forwardSlide
            // 
            this.forwardSlide.FlatAppearance.BorderSize = 0;
            this.forwardSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardSlide.Image = ((System.Drawing.Image)(resources.GetObject("forwardSlide.Image")));
            this.forwardSlide.Location = new System.Drawing.Point(625, 161);
            this.forwardSlide.Name = "forwardSlide";
            this.forwardSlide.Size = new System.Drawing.Size(75, 41);
            this.forwardSlide.TabIndex = 9;
            this.forwardSlide.UseVisualStyleBackColor = true;
            this.forwardSlide.Click += new System.EventHandler(this.forwardSlide_Click);
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(131, 816);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "menuStrip1";
            this.navBar.Visible = false;
            this.navBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            this.navBar.MouseLeave += new System.EventHandler(this.navBar_MouseLeave);
            this.navBar.MouseHover += new System.EventHandler(this.navBar_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem1.Text = "Home";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem2.Text = "Text Size";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem5.Text = "Mouse Pointer";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem6.Text = "Narrator";
            // 
            // textCursorTut
            // 
            this.textCursorTut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.textCursorTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCursorTut.ForeColor = System.Drawing.Color.White;
            this.textCursorTut.Location = new System.Drawing.Point(715, 118);
            this.textCursorTut.Name = "textCursorTut";
            this.textCursorTut.ReadOnly = true;
            this.textCursorTut.Size = new System.Drawing.Size(349, 208);
            this.textCursorTut.TabIndex = 10;
            this.textCursorTut.Text = " 1.  Open the Windows Search Box located in the bottom left hand corner. Search \"" +
    "Text Cursor\".";
            // 
            // marginPanel
            // 
            this.marginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.marginPanel.Location = new System.Drawing.Point(703, 105);
            this.marginPanel.Name = "marginPanel";
            this.marginPanel.Size = new System.Drawing.Size(371, 233);
            this.marginPanel.TabIndex = 11;
            // 
            // TextCursor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(124)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1128, 832);
            this.Controls.Add(this.textCursorTut);
            this.Controls.Add(this.forwardSlide);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step3Label);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.step1Label);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.marginPanel);
            this.Name = "TextCursor";
            this.Text = "TextCursor";
            this.Load += new System.EventHandler(this.TextCursor_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).EndInit();
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button openNav;
        private System.Windows.Forms.Label textCursorTitle;
        private System.Windows.Forms.Button step1;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.Button step3;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Button forwardSlide;
        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.RichTextBox textCursorTut;
        private System.Windows.Forms.Panel marginPanel;
        private System.Windows.Forms.Label textSizeLabel;
        private System.Windows.Forms.TrackBar changeTextSize;
    }
}