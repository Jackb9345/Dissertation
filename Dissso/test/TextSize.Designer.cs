namespace test
{
    partial class TextSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextSize));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSizeLabel = new System.Windows.Forms.Label();
            this.changeTextSize = new System.Windows.Forms.TrackBar();
            this.openNav = new System.Windows.Forms.Button();
            this.textSizeTitle = new System.Windows.Forms.Label();
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextSlide = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.Button();
            this.step3 = new System.Windows.Forms.Button();
            this.stepLabel = new System.Windows.Forms.Label();
            this.marginPanel = new System.Windows.Forms.Panel();
            this.textSizeTut = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).BeginInit();
            this.navBar.SuspendLayout();
            this.marginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.textSizeLabel);
            this.panel1.Controls.Add(this.changeTextSize);
            this.panel1.Controls.Add(this.openNav);
            this.panel1.Controls.Add(this.textSizeTitle);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 65);
            this.panel1.TabIndex = 0;
            // 
            // textSizeLabel
            // 
            this.textSizeLabel.AutoSize = true;
            this.textSizeLabel.ForeColor = System.Drawing.Color.White;
            this.textSizeLabel.Location = new System.Drawing.Point(939, 44);
            this.textSizeLabel.Name = "textSizeLabel";
            this.textSizeLabel.Size = new System.Drawing.Size(95, 15);
            this.textSizeLabel.TabIndex = 4;
            this.textSizeLabel.Text = "Change Text Size";
            // 
            // changeTextSize
            // 
            this.changeTextSize.Location = new System.Drawing.Point(935, 15);
            this.changeTextSize.Maximum = 20;
            this.changeTextSize.Minimum = 10;
            this.changeTextSize.Name = "changeTextSize";
            this.changeTextSize.Size = new System.Drawing.Size(104, 45);
            this.changeTextSize.TabIndex = 3;
            this.changeTextSize.Value = 10;
            this.changeTextSize.Scroll += new System.EventHandler(this.changeTextSize_Scroll);
            // 
            // openNav
            // 
            this.openNav.FlatAppearance.BorderSize = 0;
            this.openNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openNav.Image = ((System.Drawing.Image)(resources.GetObject("openNav.Image")));
            this.openNav.Location = new System.Drawing.Point(12, 15);
            this.openNav.Name = "openNav";
            this.openNav.Size = new System.Drawing.Size(75, 48);
            this.openNav.TabIndex = 2;
            this.openNav.UseVisualStyleBackColor = true;
            this.openNav.MouseHover += new System.EventHandler(this.openNav_MouseHover);
            // 
            // textSizeTitle
            // 
            this.textSizeTitle.AutoSize = true;
            this.textSizeTitle.BackColor = System.Drawing.Color.Transparent;
            this.textSizeTitle.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textSizeTitle.ForeColor = System.Drawing.Color.White;
            this.textSizeTitle.Location = new System.Drawing.Point(119, 22);
            this.textSizeTitle.Name = "textSizeTitle";
            this.textSizeTitle.Size = new System.Drawing.Size(95, 25);
            this.textSizeTitle.TabIndex = 0;
            this.textSizeTitle.Text = "Text Size";
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(102, 679);
            this.navBar.TabIndex = 1;
            this.navBar.Text = "navBar";
            this.navBar.Visible = false;
            this.navBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.navBar_ItemClicked);
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
            this.toolStripMenuItem2.Text = "Narrator";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem3.Text = "Mouse Cursor";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(89, 19);
            this.toolStripMenuItem4.Text = "Mouse Pointer";
            // 
            // nextSlide
            // 
            this.nextSlide.FlatAppearance.BorderSize = 0;
            this.nextSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSlide.Image = ((System.Drawing.Image)(resources.GetObject("nextSlide.Image")));
            this.nextSlide.Location = new System.Drawing.Point(616, 169);
            this.nextSlide.Name = "nextSlide";
            this.nextSlide.Size = new System.Drawing.Size(75, 39);
            this.nextSlide.TabIndex = 2;
            this.nextSlide.UseVisualStyleBackColor = true;
            this.nextSlide.Click += new System.EventHandler(this.nextSlide_Click);
            // 
            // step1
            // 
            this.step1.FlatAppearance.BorderSize = 0;
            this.step1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step1.Image = ((System.Drawing.Image)(resources.GetObject("step1.Image")));
            this.step1.Location = new System.Drawing.Point(88, 134);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(443, 35);
            this.step1.TabIndex = 3;
            this.step1.UseVisualStyleBackColor = true;
            // 
            // step2
            // 
            this.step2.FlatAppearance.BorderSize = 0;
            this.step2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step2.Image = ((System.Drawing.Image)(resources.GetObject("step2.Image")));
            this.step2.Location = new System.Drawing.Point(77, 236);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(487, 457);
            this.step2.TabIndex = 4;
            this.step2.UseVisualStyleBackColor = true;
            // 
            // step3
            // 
            this.step3.FlatAppearance.BorderSize = 0;
            this.step3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step3.Image = ((System.Drawing.Image)(resources.GetObject("step3.Image")));
            this.step3.Location = new System.Drawing.Point(616, 270);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(436, 423);
            this.step3.TabIndex = 5;
            this.step3.Text = "button4";
            this.step3.UseVisualStyleBackColor = true;
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stepLabel.ForeColor = System.Drawing.Color.White;
            this.stepLabel.Location = new System.Drawing.Point(714, 94);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(69, 25);
            this.stepLabel.TabIndex = 7;
            this.stepLabel.Text = "Step 1";
            // 
            // marginPanel
            // 
            this.marginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.marginPanel.Controls.Add(this.textSizeTut);
            this.marginPanel.Location = new System.Drawing.Point(702, 122);
            this.marginPanel.Name = "marginPanel";
            this.marginPanel.Size = new System.Drawing.Size(337, 142);
            this.marginPanel.TabIndex = 8;
            // 
            // textSizeTut
            // 
            this.textSizeTut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.textSizeTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSizeTut.ForeColor = System.Drawing.Color.White;
            this.textSizeTut.Location = new System.Drawing.Point(11, 12);
            this.textSizeTut.Name = "textSizeTut";
            this.textSizeTut.Size = new System.Drawing.Size(315, 119);
            this.textSizeTut.TabIndex = 0;
            this.textSizeTut.Text = "1. Open the Windows Search Box located in the bottom left side of your screen and" +
    " type \'Text Size\'";
            // 
            // TextSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(124)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1064, 705);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.nextSlide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.marginPanel);
            this.Name = "TextSize";
            this.Text = "TextSize";
            this.Load += new System.EventHandler(this.TextSize_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).EndInit();
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.marginPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textSizeTitle;
        private System.Windows.Forms.Button openNav;
        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button nextSlide;
        private System.Windows.Forms.Button step1;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Button step3;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.Panel marginPanel;
        private System.Windows.Forms.RichTextBox textSizeTut;
        private System.Windows.Forms.Label textSizeLabel;
        private System.Windows.Forms.TrackBar changeTextSize;
    }
}