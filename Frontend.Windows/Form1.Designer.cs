using System;
using System.Drawing;
using System.Windows.Forms;

namespace Frontend.Windows
{
    partial class Form1
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
            btn1 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            txtDisplay = new TextBox();
            btn0 = new Button();
            btnDot = new Button();
            btnPow = new Button();
            btnDelete = new Button();
            btnOpenParenthesis = new Button();
            btnPlus = new Button();
            btnMultiplay = new Button();
            btnResult = new Button();
            btnCloseParenthesis = new Button();
            btnMinus = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(1, 109);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 46);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(153, 163);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 46);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(153, 213);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 46);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(77, 213);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 46);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(77, 161);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 46);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(1, 213);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 46);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(1, 161);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 46);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(153, 111);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 46);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(77, 109);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 46);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.ActiveCaption;
            txtDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(1, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(396, 34);
            txtDisplay.TabIndex = 9;
            // 
            // btn0
            // 
            btn0.Location = new Point(40, 265);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 46);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(153, 265);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(70, 46);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnPow
            // 
            btnPow.Location = new Point(153, 59);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(70, 46);
            btnPow.TabIndex = 10;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnPow_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(229, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 46);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.Location = new Point(1, 57);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(70, 46);
            btnOpenParenthesis.TabIndex = 15;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = true;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(229, 111);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(70, 46);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMultiplay
            // 
            btnMultiplay.Location = new Point(229, 57);
            btnMultiplay.Name = "btnMultiplay";
            btnMultiplay.Size = new Size(70, 46);
            btnMultiplay.TabIndex = 13;
            btnMultiplay.Text = "*";
            btnMultiplay.UseVisualStyleBackColor = true;
            btnMultiplay.Click += btnMultiplay_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(229, 265);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(146, 46);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.Location = new Point(77, 57);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(70, 46);
            btnCloseParenthesis.TabIndex = 19;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = true;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(305, 111);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(70, 46);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(305, 57);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(70, 46);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(229, 213);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 46);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 501);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnDivide);
            Controls.Add(btnDelete);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiplay);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btnPow);
            Controls.Add(txtDisplay);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn6;
        private Button btn9;
        private Button btn8;
        private Button btn5;
        private Button btn7;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private TextBox txtDisplay;
        private Button btn0;
        private Button btnDot;
        private Button btnPow;
        private Button btnDelete;
        private Button btnOpenParenthesis;
        private Button btnPlus;
        private Button btnMultiplay;
        private Button btnResult;
        private Button btnCloseParenthesis;
        private Button btnMinus;
        private Button btnDivide;
        private Button btnClear;
    }
}