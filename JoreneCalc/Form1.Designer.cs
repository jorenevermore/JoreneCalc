namespace JoreneCalc
{
    partial class Form1
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
            numDisplay = new TextBox();
            resultDisplay = new Label();
            btnNumOne = new Button();
            btnNumTwo = new Button();
            btnNumThree = new Button();
            btnNumFour = new Button();
            btnNumSix = new Button();
            btnNumFive = new Button();
            btnNumSeven = new Button();
            btnNumEight = new Button();
            btnNumNine = new Button();
            btnNumZero = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btnEquals = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnPoint = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numDisplay
            // 
            numDisplay.BackColor = SystemColors.ButtonHighlight;
            numDisplay.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDisplay.Location = new Point(163, 142);
            numDisplay.MaximumSize = new Size(365, 50);
            numDisplay.Multiline = true;
            numDisplay.Name = "numDisplay";
            numDisplay.Size = new Size(354, 37);
            numDisplay.TabIndex = 0;
            numDisplay.TextChanged += numDisplay_TextChanged;
            // 
            // resultDisplay
            // 
            resultDisplay.AutoSize = true;
            resultDisplay.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            resultDisplay.Location = new Point(458, 105);
            resultDisplay.Name = "resultDisplay";
            resultDisplay.Size = new Size(59, 19);
            resultDisplay.TabIndex = 1;
            resultDisplay.Text = "RESULT";
            resultDisplay.Click += resultDisplay_Click;
            // 
            // btnNumOne
            // 
            btnNumOne.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumOne.Location = new Point(163, 260);
            btnNumOne.Name = "btnNumOne";
            btnNumOne.Size = new Size(75, 35);
            btnNumOne.TabIndex = 2;
            btnNumOne.Text = "1";
            btnNumOne.UseVisualStyleBackColor = true;
            btnNumOne.Click += btnNumOne_Click;
            // 
            // btnNumTwo
            // 
            btnNumTwo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumTwo.Location = new Point(254, 260);
            btnNumTwo.Name = "btnNumTwo";
            btnNumTwo.Size = new Size(75, 35);
            btnNumTwo.TabIndex = 3;
            btnNumTwo.Text = "2";
            btnNumTwo.UseVisualStyleBackColor = true;
            btnNumTwo.Click += btnNumTwo_Click;
            // 
            // btnNumThree
            // 
            btnNumThree.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumThree.Location = new Point(348, 260);
            btnNumThree.Name = "btnNumThree";
            btnNumThree.Size = new Size(75, 35);
            btnNumThree.TabIndex = 4;
            btnNumThree.Text = "3";
            btnNumThree.UseVisualStyleBackColor = true;
            btnNumThree.Click += btnNumThree_Click;
            // 
            // btnNumFour
            // 
            btnNumFour.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumFour.Location = new Point(442, 260);
            btnNumFour.Name = "btnNumFour";
            btnNumFour.Size = new Size(75, 35);
            btnNumFour.TabIndex = 5;
            btnNumFour.Text = "4";
            btnNumFour.UseVisualStyleBackColor = true;
            btnNumFour.Click += btnNumFour_Click;
            // 
            // btnNumSix
            // 
            btnNumSix.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumSix.Location = new Point(254, 310);
            btnNumSix.Name = "btnNumSix";
            btnNumSix.Size = new Size(75, 34);
            btnNumSix.TabIndex = 6;
            btnNumSix.Text = "6";
            btnNumSix.UseVisualStyleBackColor = true;
            btnNumSix.Click += btnNumSix_Click;
            // 
            // btnNumFive
            // 
            btnNumFive.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumFive.Location = new Point(163, 310);
            btnNumFive.Name = "btnNumFive";
            btnNumFive.Size = new Size(75, 34);
            btnNumFive.TabIndex = 7;
            btnNumFive.Text = "5";
            btnNumFive.UseVisualStyleBackColor = true;
            btnNumFive.Click += btnNumFive_Click;
            // 
            // btnNumSeven
            // 
            btnNumSeven.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumSeven.Location = new Point(348, 310);
            btnNumSeven.Name = "btnNumSeven";
            btnNumSeven.Size = new Size(75, 34);
            btnNumSeven.TabIndex = 8;
            btnNumSeven.Text = "7";
            btnNumSeven.UseVisualStyleBackColor = true;
            btnNumSeven.Click += btnNumSeven_Click;
            // 
            // btnNumEight
            // 
            btnNumEight.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumEight.Location = new Point(442, 310);
            btnNumEight.Name = "btnNumEight";
            btnNumEight.Size = new Size(75, 34);
            btnNumEight.TabIndex = 9;
            btnNumEight.Text = "8";
            btnNumEight.UseVisualStyleBackColor = true;
            btnNumEight.Click += btnNumEight_Click;
            // 
            // btnNumNine
            // 
            btnNumNine.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumNine.Location = new Point(163, 360);
            btnNumNine.Name = "btnNumNine";
            btnNumNine.Size = new Size(75, 34);
            btnNumNine.TabIndex = 10;
            btnNumNine.Text = "9";
            btnNumNine.UseVisualStyleBackColor = true;
            btnNumNine.Click += btnNumNine_Click;
            // 
            // btnNumZero
            // 
            btnNumZero.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumZero.Location = new Point(254, 360);
            btnNumZero.Name = "btnNumZero";
            btnNumZero.Size = new Size(75, 34);
            btnNumZero.TabIndex = 11;
            btnNumZero.Text = "0";
            btnNumZero.UseVisualStyleBackColor = true;
            btnNumZero.Click += btnNumZero_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(163, 208);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "＋";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(254, 208);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 35);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(348, 208);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 35);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(442, 208);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 35);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(442, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(442, 360);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 34);
            btnEquals.TabIndex = 17;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.scs_123;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Sitka Heading", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 79);
            label1.TabIndex = 19;
            label1.Text = "Simple Calculator ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 486);
            label2.Name = "label2";
            label2.Size = new Size(214, 37);
            label2.TabIndex = 20;
            label2.Text = "Pamaos, Jorene BSIT 3";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPoint.ForeColor = SystemColors.ControlText;
            btnPoint.Location = new Point(348, 360);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(75, 34);
            btnPoint.TabIndex = 21;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(668, 523);
            Controls.Add(btnPoint);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnNumZero);
            Controls.Add(btnNumNine);
            Controls.Add(btnNumEight);
            Controls.Add(btnNumSeven);
            Controls.Add(btnNumFive);
            Controls.Add(btnNumSix);
            Controls.Add(btnNumFour);
            Controls.Add(btnNumThree);
            Controls.Add(btnNumTwo);
            Controls.Add(btnNumOne);
            Controls.Add(resultDisplay);
            Controls.Add(numDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numDisplay;
        private Label resultDisplay;
        private Button btnNumOne;
        private Button btnNumTwo;
        private Button btnNumThree;
        private Button btnNumFour;
        private Button btnNumSix;
        private Button btnNumFive;
        private Button btnNumSeven;
        private Button btnNumEight;
        private Button btnNumNine;
        private Button btnNumZero;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
        private Button btnEquals;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnPoint;
    }
}
