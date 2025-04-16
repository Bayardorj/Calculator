namespace WinFormsApp1
{
    partial class Calculator
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
            TextBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            EightBtn = new Button();
            FiveBtn = new Button();
            TwoBtn = new Button();
            DotBtn = new Button();
            NineBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            EqualBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            ClearBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            MinusPlusBtn = new Button();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(51, 51);
            TextBox.Name = "TextBox";
            TextBox.ReadOnly = true;
            TextBox.Size = new Size(521, 52);
            TextBox.TabIndex = 0;
            TextBox.Text = "0";
            TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SevenBtn.Location = new Point(51, 121);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(94, 39);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FourBtn.Location = new Point(51, 166);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(94, 39);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OneBtn.Location = new Point(51, 211);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(94, 39);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(51, 256);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(94, 39);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EightBtn.Location = new Point(151, 121);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(94, 39);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FiveBtn.Location = new Point(151, 166);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(94, 39);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TwoBtn.Location = new Point(151, 211);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(94, 39);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DotBtn.Location = new Point(151, 256);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(94, 39);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NineBtn.Location = new Point(251, 121);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(94, 39);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SixBtn.Location = new Point(251, 166);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(94, 39);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(251, 211);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(94, 39);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EqualBtn.Location = new Point(251, 256);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(94, 39);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DivideBtn.Location = new Point(378, 211);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(94, 39);
            DivideBtn.TabIndex = 15;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusBtn.Location = new Point(378, 166);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(94, 39);
            MinusBtn.TabIndex = 14;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(378, 121);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(194, 39);
            ClearBtn.TabIndex = 13;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(478, 211);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(94, 39);
            MultiplyBtn.TabIndex = 19;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlusBtn.Location = new Point(478, 166);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(94, 39);
            PlusBtn.TabIndex = 18;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusPlusBtn.Location = new Point(378, 256);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(194, 39);
            MinusPlusBtn.TabIndex = 20;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += button1_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 520);
            Controls.Add(MinusPlusBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button EightBtn;
        private Button FiveBtn;
        private Button TwoBtn;
        private Button DotBtn;
        private Button NineBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button EqualBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button ClearBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button MinusPlusBtn;
    }
}