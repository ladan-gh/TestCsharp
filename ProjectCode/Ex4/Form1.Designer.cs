﻿namespace Ex4
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
            this.textMonth = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textRate = new System.Windows.Forms.TextBox();
            this.textSod = new System.Windows.Forms.TextBox();
            this.textQest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textMonth
            // 
            this.textMonth.Location = new System.Drawing.Point(189, 48);
            this.textMonth.Name = "textMonth";
            this.textMonth.Size = new System.Drawing.Size(100, 22);
            this.textMonth.TabIndex = 0;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(189, 98);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(100, 22);
            this.textAmount.TabIndex = 1;
            // 
            // textRate
            // 
            this.textRate.Location = new System.Drawing.Point(189, 151);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(100, 22);
            this.textRate.TabIndex = 2;
            // 
            // textSod
            // 
            this.textSod.Location = new System.Drawing.Point(203, 320);
            this.textSod.Name = "textSod";
            this.textSod.Size = new System.Drawing.Size(100, 22);
            this.textSod.TabIndex = 3;
            // 
            // textQest
            // 
            this.textQest.Location = new System.Drawing.Point(203, 280);
            this.textQest.Name = "textQest";
            this.textQest.Size = new System.Drawing.Size(100, 22);
            this.textQest.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "محاسبه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "مدت به ماه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "اصل وام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "نرخ وام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "قسط";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "سود";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textQest);
            this.Controls.Add(this.textSod);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMonth;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.TextBox textSod;
        private System.Windows.Forms.TextBox textQest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

