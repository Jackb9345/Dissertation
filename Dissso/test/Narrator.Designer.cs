namespace test
{
    partial class step1Label
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step1Label));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSizeLabel = new System.Windows.Forms.Label();
            this.openNav = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.changeTextSize = new System.Windows.Forms.TrackBar();
            this.narratorNav = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardSlide = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.Button();
            this.labelstep1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Button();
            this.step2Label = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.step3 = new System.Windows.Forms.Button();
            this.stepsInfo = new System.Windows.Forms.RichTextBox();
            this.marginPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).BeginInit();
            this.narratorNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.textSizeLabel);
            this.panel1.Controls.Add(this.openNav);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.changeTextSize);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textSizeLabel
            // 
            this.textSizeLabel.AutoSize = true;
            this.textSizeLabel.ForeColor = System.Drawing.Color.White;
            this.textSizeLabel.Location = new System.Drawing.Point(917, 35);
            this.textSizeLabel.Name = "textSizeLabel";
            this.textSizeLabel.Size = new System.Drawing.Size(51, 15);
            this.textSizeLabel.TabIndex = 2;
            this.textSizeLabel.Text = "Text Size";
            // 
            // openNav
            // 
            this.openNav.BackColor = System.Drawing.Color.Transparent;
            this.openNav.FlatAppearance.BorderSize = 0;
            this.openNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNav.Image = ((System.Drawing.Image)(resources.GetObject("openNav.Image")));
            this.openNav.Location = new System.Drawing.Point(30, 7);
            this.openNav.Name = "openNav";
            this.openNav.Size = new System.Drawing.Size(62, 46);
            this.openNav.TabIndex = 1;
            this.openNav.UseVisualStyleBackColor = false;
            this.openNav.MouseLeave += new System.EventHandler(this.openNav_MouseLeave);
            this.openNav.MouseHover += new System.EventHandler(this.openNav_MouseHover);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.titleLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(122, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Narrator";
            // 
            // changeTextSize
            // 
            this.changeTextSize.Location = new System.Drawing.Point(889, 7);
            this.changeTextSize.Maximum = 20;
            this.changeTextSize.Minimum = 10;
            this.changeTextSize.Name = "changeTextSize";
            this.changeTextSize.Size = new System.Drawing.Size(104, 45);
            this.changeTextSize.TabIndex = 3;
            this.changeTextSize.Value = 10;
            this.changeTextSize.Scroll += new System.EventHandler(this.changeTextSize_Scroll);
            // 
            // narratorNav
            // 
            this.narratorNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.narratorNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.narratorNav.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.narratorNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.narratorNav.Location = new System.Drawing.Point(0, 0);
            this.narratorNav.Name = "narratorNav";
            this.narratorNav.Size = new System.Drawing.Size(116, 751);
            this.narratorNav.TabIndex = 1;
            this.narratorNav.Text = "menuStrip1";
            this.narratorNav.Visible = false;
            this.narratorNav.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.narratorNav.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.narratorNav.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem1.Text = "Home Page";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem2.Text = "Text Size";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem4.Text = "Cursor";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem5.Text = "Mouse Pointer";
            // 
            // forwardSlide
            // 
            this.forwardSlide.FlatAppearance.BorderSize = 0;
            this.forwardSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardSlide.Image = ((System.Drawing.Image)(resources.GetObject("forwardSlide.Image")));
            this.forwardSlide.Location = new System.Drawing.Point(593, 191);
            this.forwardSlide.Name = "forwardSlide";
            this.forwardSlide.Size = new System.Drawing.Size(45, 33);
            this.forwardSlide.TabIndex = 3;
            this.forwardSlide.UseVisualStyleBackColor = true;
            this.forwardSlide.Click += new System.EventHandler(this.forwardSlide_Click);
            // 
            // step1
            // 
            this.step1.FlatAppearance.BorderSize = 0;
            this.step1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.step1.Image = ((System.Drawing.Image)(resources.GetObject("step1.Image")));
            this.step1.Location = new System.Drawing.Point(91, 101);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(434, 45);
            this.step1.TabIndex = 4;
            this.step1.UseVisualStyleBackColor = true;
            // 
            // labelstep1
            // 
            this.labelstep1.AutoSize = true;
            this.labelstep1.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelstep1.ForeColor = System.Drawing.Color.White;
            this.labelstep1.Location = new System.Drawing.Point(660, 61);
            this.labelstep1.Name = "labelstep1";
            this.labelstep1.Size = new System.Drawing.Size(69, 25);
            this.labelstep1.TabIndex = 5;
            this.labelstep1.Text = "Step 1";
            // 
            // step2
            // 
            this.step2.FlatAppearance.BorderSize = 0;
            this.step2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step2.Image = ((System.Drawing.Image)(resources.GetObject("step2.Image")));
            this.step2.Location = new System.Drawing.Point(91, 204);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(442, 82);
            this.step2.TabIndex = 6;
            this.step2.UseVisualStyleBackColor = true;
            this.step2.Visible = false;
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step2Label.ForeColor = System.Drawing.Color.White;
            this.step2Label.Location = new System.Drawing.Point(660, 61);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(69, 25);
            this.step2Label.TabIndex = 7;
            this.step2Label.Text = "Step 2";
            this.step2Label.Visible = false;
            // 
            // step3Label
            // 
            this.step3Label.AutoSize = true;
            this.step3Label.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step3Label.ForeColor = System.Drawing.Color.White;
            this.step3Label.Location = new System.Drawing.Point(660, 61);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(69, 25);
            this.step3Label.TabIndex = 8;
            this.step3Label.Text = "Step 3";
            this.step3Label.Visible = false;
            // 
            // step3
            // 
            this.step3.FlatAppearance.BorderSize = 0;
            this.step3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step3.Image = ((System.Drawing.Image)(resources.GetObject("step3.Image")));
            this.step3.Location = new System.Drawing.Point(91, 357);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(899, 382);
            this.step3.TabIndex = 9;
            this.step3.Text = "button3";
            this.step3.UseVisualStyleBackColor = true;
            this.step3.Visible = false;
            // 
            // stepsInfo
            // 
            this.stepsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.stepsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stepsInfo.ForeColor = System.Drawing.Color.White;
            this.stepsInfo.Location = new System.Drawing.Point(660, 101);
            this.stepsInfo.Name = "stepsInfo";
            this.stepsInfo.Size = new System.Drawing.Size(307, 221);
            this.stepsInfo.TabIndex = 10;
            this.stepsInfo.Text = " - Open the Windows Search box located in the bottom right of your screen";
            this.stepsInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // marginPanel
            // 
            this.marginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.marginPanel.Location = new System.Drawing.Point(649, 88);
            this.marginPanel.Name = "marginPanel";
            this.marginPanel.Size = new System.Drawing.Size(330, 242);
            this.marginPanel.TabIndex = 11;
            // 
            // step1Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(124)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1002, 751);
            this.Controls.Add(this.stepsInfo);
            this.Controls.Add(this.forwardSlide);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step3Label);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.labelstep1);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.narratorNav);
            this.Controls.Add(this.marginPanel);
            this.Name = "step1Label";
            this.Text = "Narrator";
            this.Load += new System.EventHandler(this.Narrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).EndInit();
            this.narratorNav.ResumeLayout(false);
            this.narratorNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openNav;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MenuStrip narratorNav;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button forwardSlide;
        private System.Windows.Forms.Button step1;
        private System.Windows.Forms.Label labelstep1;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.Button step3;
        private System.Windows.Forms.RichTextBox stepsInfo;
        private System.Windows.Forms.Panel marginPanel;
        private System.Windows.Forms.Label textSizeLabel;
        private System.Windows.Forms.TrackBar changeTextSize;
    }
}