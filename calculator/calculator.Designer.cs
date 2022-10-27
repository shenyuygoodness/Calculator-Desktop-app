namespace calculator
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.btnAddition = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddition
            // 
            this.btnAddition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddition.Location = new System.Drawing.Point(217, 90);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(67, 29);
            this.btnAddition.TabIndex = 16;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(24, 49);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(260, 35);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnThree
            // 
            this.btnThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThree.BackColor = System.Drawing.Color.Teal;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThree.Location = new System.Drawing.Point(156, 90);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(67, 29);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTwo.BackColor = System.Drawing.Color.Teal;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwo.Location = new System.Drawing.Point(89, 90);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(67, 29);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOne.BackColor = System.Drawing.Color.Teal;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOne.Location = new System.Drawing.Point(24, 90);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(67, 29);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubtraction.FlatAppearance.BorderSize = 0;
            this.btnSubtraction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubtraction.Location = new System.Drawing.Point(217, 110);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(67, 29);
            this.btnSubtraction.TabIndex = 17;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnSix
            // 
            this.btnSix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSix.BackColor = System.Drawing.Color.Teal;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSix.Location = new System.Drawing.Point(156, 110);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(67, 29);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFive.BackColor = System.Drawing.Color.Teal;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFive.Location = new System.Drawing.Point(89, 110);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(67, 29);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFour.BackColor = System.Drawing.Color.Teal;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFour.Location = new System.Drawing.Point(24, 110);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(67, 29);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivision.Location = new System.Drawing.Point(217, 129);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(67, 29);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnNine
            // 
            this.btnNine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNine.BackColor = System.Drawing.Color.Teal;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNine.Location = new System.Drawing.Point(156, 129);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(67, 29);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEight.BackColor = System.Drawing.Color.Teal;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEight.Location = new System.Drawing.Point(89, 129);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(67, 29);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeven.BackColor = System.Drawing.Color.Teal;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeven.Location = new System.Drawing.Point(24, 129);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(67, 29);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMultiplication.FlatAppearance.BorderSize = 0;
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiplication.Location = new System.Drawing.Point(217, 149);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(67, 29);
            this.btnMultiplication.TabIndex = 19;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFactorial.BackColor = System.Drawing.Color.Teal;
            this.btnFactorial.FlatAppearance.BorderSize = 0;
            this.btnFactorial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFactorial.Location = new System.Drawing.Point(156, 149);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(67, 29);
            this.btnFactorial.TabIndex = 12;
            this.btnFactorial.Text = "!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnZero
            // 
            this.btnZero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZero.BackColor = System.Drawing.Color.Teal;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZero.Location = new System.Drawing.Point(89, 149);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(67, 29);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPoint.BackColor = System.Drawing.Color.Teal;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPoint.Location = new System.Drawing.Point(24, 149);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(67, 29);
            this.btnPoint.TabIndex = 10;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEqual.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEqual.Location = new System.Drawing.Point(154, 169);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(130, 29);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearEntry.Location = new System.Drawing.Point(89, 169);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(67, 29);
            this.btnClearEntry.TabIndex = 14;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(24, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(308, 253);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

