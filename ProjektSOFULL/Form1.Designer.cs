﻿namespace ProjektSOFULL
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
            this.czytnik_1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.czytnik_2 = new System.Windows.Forms.TextBox();
            this.logger = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zaladuj_1 = new System.Windows.Forms.Button();
            this.zaladuj_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // czytnik_1
            // 
            this.czytnik_1.AccessibleName = "";
            this.czytnik_1.Location = new System.Drawing.Point(53, 28);
            this.czytnik_1.Multiline = true;
            this.czytnik_1.Name = "czytnik_1";
            this.czytnik_1.Size = new System.Drawing.Size(192, 195);
            this.czytnik_1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 265);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 195);
            this.textBox2.TabIndex = 1;
            // 
            // czytnik_2
            // 
            this.czytnik_2.AccessibleName = "czytnik_2";
            this.czytnik_2.Location = new System.Drawing.Point(292, 28);
            this.czytnik_2.Multiline = true;
            this.czytnik_2.Name = "czytnik_2";
            this.czytnik_2.Size = new System.Drawing.Size(192, 195);
            this.czytnik_2.TabIndex = 2;
            // 
            // logger
            // 
            this.logger.Location = new System.Drawing.Point(640, 28);
            this.logger.Multiline = true;
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(307, 409);
            this.logger.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 265);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 195);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Czytnik 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Czytnik 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drukarka 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Drukarka 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logger";
            // 
            // zaladuj_1
            // 
            this.zaladuj_1.Location = new System.Drawing.Point(536, 73);
            this.zaladuj_1.Name = "zaladuj_1";
            this.zaladuj_1.Size = new System.Drawing.Size(75, 23);
            this.zaladuj_1.TabIndex = 10;
            this.zaladuj_1.Text = "Zaladuj1";
            this.zaladuj_1.UseVisualStyleBackColor = true;
            this.zaladuj_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zaladuj_2
            // 
            this.zaladuj_2.Location = new System.Drawing.Point(536, 153);
            this.zaladuj_2.Name = "zaladuj_2";
            this.zaladuj_2.Size = new System.Drawing.Size(75, 23);
            this.zaladuj_2.TabIndex = 11;
            this.zaladuj_2.Text = "Zaladuj2";
            this.zaladuj_2.UseVisualStyleBackColor = true;
            this.zaladuj_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 485);
            this.Controls.Add(this.zaladuj_2);
            this.Controls.Add(this.zaladuj_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.czytnik_2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.czytnik_1);
            this.Name = "Form1";
            this.Text = "Two-men project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox czytnik_1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox czytnik_2;
        private System.Windows.Forms.TextBox logger;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button zaladuj_1;
        private System.Windows.Forms.Button zaladuj_2;

        
    }
}