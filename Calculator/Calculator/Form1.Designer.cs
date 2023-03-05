namespace Calculator
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
            calculatorDisplay = new Label();
            oneButton = new Button();
            twoButton = new Button();
            threeButton = new Button();
            fourButton = new Button();
            fiveButton = new Button();
            sixButton = new Button();
            sevenButton = new Button();
            eightButton = new Button();
            nineButton = new Button();
            zeroButton = new Button();
            clearButton = new Button();
            titikButton = new Button();
            samaDengan = new Button();
            minusButton = new Button();
            plusButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            SuspendLayout();
            // 
            // calculatorDisplay
            // 
            calculatorDisplay.BackColor = SystemColors.ActiveCaptionText;
            calculatorDisplay.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            calculatorDisplay.ForeColor = SystemColors.ButtonFace;
            calculatorDisplay.Location = new Point(12, 19);
            calculatorDisplay.Name = "calculatorDisplay";
            calculatorDisplay.Size = new Size(390, 85);
            calculatorDisplay.TabIndex = 0;
            calculatorDisplay.Text = "0";
            // 
            // oneButton
            // 
            oneButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            oneButton.Location = new Point(12, 251);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(93, 56);
            oneButton.TabIndex = 1;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += oneButton_Click;
            // 
            // twoButton
            // 
            twoButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            twoButton.Location = new Point(111, 251);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(93, 56);
            twoButton.TabIndex = 2;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += twoButton_Click;
            // 
            // threeButton
            // 
            threeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            threeButton.Location = new Point(210, 253);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(93, 56);
            threeButton.TabIndex = 3;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += threeButton_Click;
            // 
            // fourButton
            // 
            fourButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fourButton.Location = new Point(12, 315);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(93, 56);
            fourButton.TabIndex = 4;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += fourButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fiveButton.Location = new Point(111, 315);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(93, 56);
            fiveButton.TabIndex = 5;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += fiveButton_Click;
            // 
            // sixButton
            // 
            sixButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sixButton.Location = new Point(210, 315);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(93, 56);
            sixButton.TabIndex = 6;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += sixButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sevenButton.Location = new Point(12, 377);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(93, 56);
            sevenButton.TabIndex = 7;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += sevenButton_Click;
            // 
            // eightButton
            // 
            eightButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            eightButton.Location = new Point(111, 377);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(93, 56);
            eightButton.TabIndex = 8;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += eightButton_Click;
            // 
            // nineButton
            // 
            nineButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            nineButton.Location = new Point(210, 377);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(93, 56);
            nineButton.TabIndex = 9;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += nineButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(12, 439);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(192, 56);
            zeroButton.TabIndex = 15;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += zeroButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(12, 192);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(291, 56);
            clearButton.TabIndex = 11;
            clearButton.Text = "A/C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // titikButton
            // 
            titikButton.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            titikButton.Location = new Point(210, 439);
            titikButton.Name = "titikButton";
            titikButton.Size = new Size(93, 56);
            titikButton.TabIndex = 12;
            titikButton.Text = ".";
            titikButton.UseVisualStyleBackColor = true;
            titikButton.Click += titikButton_Click;
            // 
            // samaDengan
            // 
            samaDengan.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            samaDengan.Location = new Point(309, 377);
            samaDengan.Name = "samaDengan";
            samaDengan.Size = new Size(93, 118);
            samaDengan.TabIndex = 13;
            samaDengan.Text = "=";
            samaDengan.UseVisualStyleBackColor = true;
            samaDengan.Click += samaDengan_Click;
            // 
            // minusButton
            // 
            minusButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            minusButton.Location = new Point(309, 315);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(93, 56);
            minusButton.TabIndex = 14;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // plusButton
            // 
            plusButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            plusButton.Location = new Point(309, 253);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(93, 56);
            plusButton.TabIndex = 15;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyButton.Location = new Point(309, 191);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(93, 56);
            multiplyButton.TabIndex = 16;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            divideButton.Location = new Point(309, 129);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(93, 56);
            divideButton.TabIndex = 17;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 511);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(plusButton);
            Controls.Add(minusButton);
            Controls.Add(samaDengan);
            Controls.Add(titikButton);
            Controls.Add(clearButton);
            Controls.Add(zeroButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(calculatorDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label calculatorDisplay;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button zeroButton;
        private Button clearButton;
        private Button titikButton;
        private Button samaDengan;
        private Button minusButton;
        private Button plusButton;
        private Button multiplyButton;
        private Button divideButton;
    }
}