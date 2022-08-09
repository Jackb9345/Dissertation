namespace test
{
    partial class MousePointer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MousePointer));
            this.topPanel = new System.Windows.Forms.Panel();
            this.textSizeLabel = new System.Windows.Forms.Label();
            this.changeTextSize = new System.Windows.Forms.TrackBar();
            this.openNav = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardSlide = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.Button();
            this.step3 = new System.Windows.Forms.Button();
            this.step1L = new System.Windows.Forms.Label();
            this.step2L = new System.Windows.Forms.Label();
            this.step3L = new System.Windows.Forms.Label();
            this.mousePointerTut = new System.Windows.Forms.RichTextBox();
            this.marginPanel = new System.Windows.Forms.Panel();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.topPanel.Controls.Add(this.textSizeLabel);
            this.topPanel.Controls.Add(this.changeTextSize);
            this.topPanel.Controls.Add(this.openNav);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Font = new System.Drawing.Font("Adobe Gothic Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topPanel.Location = new System.Drawing.Point(-4, -3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1133, 59);
            this.topPanel.TabIndex = 0;
            // 
            // textSizeLabel
            // 
            this.textSizeLabel.AutoSize = true;
            this.textSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSizeLabel.ForeColor = System.Drawing.Color.White;
            this.textSizeLabel.Location = new System.Drawing.Point(1009, 39);
            this.textSizeLabel.Name = "textSizeLabel";
            this.textSizeLabel.Size = new System.Drawing.Size(51, 15);
            this.textSizeLabel.TabIndex = 3;
            this.textSizeLabel.Text = "Text Size";
            // 
            // changeTextSize
            // 
            this.changeTextSize.Location = new System.Drawing.Point(979, 6);
            this.changeTextSize.Maximum = 20;
            this.changeTextSize.Minimum = 10;
            this.changeTextSize.Name = "changeTextSize";
            this.changeTextSize.Size = new System.Drawing.Size(104, 45);
            this.changeTextSize.TabIndex = 2;
            this.changeTextSize.Value = 10;
            this.changeTextSize.Scroll += new System.EventHandler(this.changeTextSize_Scroll);
            // 
            // openNav
            // 
            this.openNav.BackColor = System.Drawing.Color.Transparent;
            this.openNav.FlatAppearance.BorderSize = 0;
            this.openNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openNav.Image = ((System.Drawing.Image)(resources.GetObject("openNav.Image")));
            this.openNav.Location = new System.Drawing.Point(12, 11);
            this.openNav.Name = "openNav";
            this.openNav.Size = new System.Drawing.Size(92, 38);
            this.openNav.TabIndex = 1;
            this.openNav.UseVisualStyleBackColor = false;
            this.openNav.Click += new System.EventHandler(this.mousePointerNavBar_Click);
            this.openNav.MouseLeave += new System.EventHandler(this.mousePointerNavBar_MouseLeave);
            this.openNav.MouseHover += new System.EventHandler(this.mousePointerNavBar_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Pointer ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem11,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 23);
            this.toolStripMenuItem1.Text = "Home Page";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(85, 23);
            this.toolStripMenuItem11.Text = "Text Size";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(85, 23);
            this.toolStripMenuItem3.Text = "Cursor";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(85, 23);
            this.toolStripMenuItem5.Text = "Narrator";
            // 
            // forwardSlide
            // 
            this.forwardSlide.FlatAppearance.BorderSize = 0;
            this.forwardSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardSlide.Image = ((System.Drawing.Image)(resources.GetObject("forwardSlide.Image")));
            this.forwardSlide.Location = new System.Drawing.Point(565, 149);
            this.forwardSlide.Name = "forwardSlide";
            this.forwardSlide.Size = new System.Drawing.Size(75, 37);
            this.forwardSlide.TabIndex = 3;
            this.forwardSlide.UseVisualStyleBackColor = true;
            this.forwardSlide.Click += new System.EventHandler(this.rightSlide_Click);
            // 
            // step2
            // 
            this.step2.FlatAppearance.BorderSize = 0;
            this.step2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step2.Image = ((System.Drawing.Image)(resources.GetObject("step2.Image")));
            this.step2.Location = new System.Drawing.Point(133, 292);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(330, 92);
            this.step2.TabIndex = 4;
            this.step2.UseVisualStyleBackColor = true;
            this.step2.Visible = false;
            // 
            // step1
            // 
            this.step1.FlatAppearance.BorderSize = 0;
            this.step1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step1.Image = ((System.Drawing.Image)(resources.GetObject("step1.Image")));
            this.step1.Location = new System.Drawing.Point(76, 149);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(473, 63);
            this.step1.TabIndex = 5;
            this.step1.UseVisualStyleBackColor = true;
            // 
            // step3
            // 
            this.step3.Image = ((System.Drawing.Image)(resources.GetObject("step3.Image")));
            this.step3.Location = new System.Drawing.Point(649, 260);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(404, 459);
            this.step3.TabIndex = 6;
            this.step3.UseVisualStyleBackColor = true;
            this.step3.Visible = false;
            // 
            // step1L
            // 
            this.step1L.AutoSize = true;
            this.step1L.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1L.ForeColor = System.Drawing.Color.White;
            this.step1L.Location = new System.Drawing.Point(660, 68);
            this.step1L.Name = "step1L";
            this.step1L.Size = new System.Drawing.Size(69, 25);
            this.step1L.TabIndex = 7;
            this.step1L.Text = "Step 1";
            // 
            // step2L
            // 
            this.step2L.AutoSize = true;
            this.step2L.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step2L.ForeColor = System.Drawing.Color.White;
            this.step2L.Location = new System.Drawing.Point(660, 68);
            this.step2L.Name = "step2L";
            this.step2L.Size = new System.Drawing.Size(69, 25);
            this.step2L.TabIndex = 8;
            this.step2L.Text = "Step 2";
            this.step2L.Visible = false;
            // 
            // step3L
            // 
            this.step3L.AutoSize = true;
            this.step3L.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step3L.ForeColor = System.Drawing.Color.White;
            this.step3L.Location = new System.Drawing.Point(660, 68);
            this.step3L.Name = "step3L";
            this.step3L.Size = new System.Drawing.Size(69, 25);
            this.step3L.TabIndex = 9;
            this.step3L.Text = "Step 3";
            this.step3L.Visible = false;
            // 
            // mousePointerTut
            // 
            this.mousePointerTut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.mousePointerTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mousePointerTut.ForeColor = System.Drawing.Color.White;
            this.mousePointerTut.Location = new System.Drawing.Point(649, 105);
            this.mousePointerTut.Name = "mousePointerTut";
            this.mousePointerTut.ReadOnly = true;
            this.mousePointerTut.Size = new System.Drawing.Size(404, 131);
            this.mousePointerTut.TabIndex = 10;
            this.mousePointerTut.Text = " 1. Open the Windows Search box located in the bottom left corner. Search \'Mouse " +
    "Pointer\'.";
            // 
            // marginPanel
            // 
            this.marginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.marginPanel.Location = new System.Drawing.Point(639, 96);
            this.marginPanel.Name = "marginPanel";
            this.marginPanel.Size = new System.Drawing.Size(424, 149);
            this.marginPanel.TabIndex = 11;
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem10.Text = "Mouse";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem9.Text = "Keyboard";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem8.Text = "Keyboard";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem7.Text = "Audio";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem6.Text = "Colour Filter";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 23);
            this.toolStripMenuItem2.Text = "Magnifier";
            // 
            // MousePointer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(124)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1094, 731);
            this.Controls.Add(this.mousePointerTut);
            this.Controls.Add(this.step3L);
            this.Controls.Add(this.step2L);
            this.Controls.Add(this.forwardSlide);
            this.Controls.Add(this.step1L);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.marginPanel);
            this.Name = "MousePointer";
            this.Text = "AssistantU - Mouse Pointer";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTextSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openNav;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button forwardSlide;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Button step1;
        private System.Windows.Forms.Button step3;
        private System.Windows.Forms.Label step1L;
        private System.Windows.Forms.Label step2L;
        private System.Windows.Forms.Label step3L;
        private System.Windows.Forms.RichTextBox mousePointerTut;
        private System.Windows.Forms.Panel marginPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label textSizeLabel;
        private System.Windows.Forms.TrackBar changeTextSize;
    }
}