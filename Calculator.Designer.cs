namespace Calculator
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
            textBoxShow = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnC = new Button();
            btnCL = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnOpen = new Button();
            btnClose = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxShow
            // 
            textBoxShow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxShow.Location = new Point(3, 3);
            textBoxShow.Name = "textBoxShow";
            textBoxShow.ReadOnly = true;
            textBoxShow.Size = new Size(474, 27);
            textBoxShow.TabIndex = 0;
            textBoxShow.TextAlign = HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBoxShow);
            flowLayoutPanel1.Controls.Add(btn7);
            flowLayoutPanel1.Controls.Add(btn8);
            flowLayoutPanel1.Controls.Add(btn9);
            flowLayoutPanel1.Controls.Add(btnC);
            flowLayoutPanel1.Controls.Add(btnCL);
            flowLayoutPanel1.Controls.Add(btn4);
            flowLayoutPanel1.Controls.Add(btn5);
            flowLayoutPanel1.Controls.Add(btn6);
            flowLayoutPanel1.Controls.Add(btnDiv);
            flowLayoutPanel1.Controls.Add(btnMulti);
            flowLayoutPanel1.Controls.Add(btn1);
            flowLayoutPanel1.Controls.Add(btn2);
            flowLayoutPanel1.Controls.Add(btn3);
            flowLayoutPanel1.Controls.Add(btnMinus);
            flowLayoutPanel1.Controls.Add(btnPlus);
            flowLayoutPanel1.Controls.Add(btn0);
            flowLayoutPanel1.Controls.Add(btnDot);
            flowLayoutPanel1.Controls.Add(btnEqual);
            flowLayoutPanel1.Controls.Add(btnOpen);
            flowLayoutPanel1.Controls.Add(btnClose);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(481, 419);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(3, 36);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 90);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(99, 36);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 90);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(195, 36);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 90);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Gold;
            btnC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = SystemColors.ControlText;
            btnC.Location = new Point(291, 36);
            btnC.Name = "btnC";
            btnC.Size = new Size(90, 90);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCL
            // 
            btnCL.BackColor = Color.Red;
            btnCL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCL.ForeColor = SystemColors.Control;
            btnCL.Location = new Point(387, 36);
            btnCL.Name = "btnCL";
            btnCL.Size = new Size(90, 90);
            btnCL.TabIndex = 17;
            btnCL.Text = "CL";
            btnCL.UseVisualStyleBackColor = false;
            btnCL.Click += btnCL_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(3, 132);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 90);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(99, 132);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 90);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(195, 132);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 90);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(291, 132);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(90, 90);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnSign_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(387, 132);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(90, 90);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnSign_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(3, 228);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 90);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(99, 228);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 90);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(195, 228);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 90);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(291, 228);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(90, 90);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnSign_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(387, 228);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(90, 90);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnSign_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(3, 324);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 90);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(99, 324);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(90, 90);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LimeGreen;
            btnEqual.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.Control;
            btnEqual.Location = new Point(195, 324);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(90, 90);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(291, 324);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(90, 90);
            btnOpen.TabIndex = 19;
            btnOpen.Text = "(";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnSign_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(387, 324);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 90);
            btnClose.TabIndex = 21;
            btnClose.Text = ")";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnSign_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 419);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "Calculator";
            ShowIcon = false;
            Text = "Caculator";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxShow;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnC;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnDiv;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMulti;
        private Button btn0;
        private Button btnDot;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnCL;
        private Button btnOpen;
        private Button btnClose;
    }
}
