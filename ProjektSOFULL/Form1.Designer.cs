﻿namespace ProjektSOFULL
{

        public static partial class Form1
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
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.textBox3 = new System.Windows.Forms.TextBox();
                this.textBox4 = new System.Windows.Forms.TextBox();
                this.textBox5 = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(29, 29);
                this.textBox1.Multiline = true;
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(260, 235);
                this.textBox1.TabIndex = 0;
                this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(356, 26);
                this.textBox2.Multiline = true;
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(260, 235);
                this.textBox2.TabIndex = 1;
                // 
                // textBox3
                // 
                this.textBox3.Location = new System.Drawing.Point(356, 366);
                this.textBox3.Multiline = true;
                this.textBox3.Name = "textBox3";
                this.textBox3.ReadOnly = true;
                this.textBox3.Size = new System.Drawing.Size(260, 235);
                this.textBox3.TabIndex = 2;
                // 
                // textBox4
                // 
                this.textBox4.Location = new System.Drawing.Point(29, 366);
                this.textBox4.Multiline = true;
                this.textBox4.Name = "textBox4";
                this.textBox4.ReadOnly = true;
                this.textBox4.Size = new System.Drawing.Size(260, 235);
                this.textBox4.TabIndex = 3;
                // 
                // textBox5
                // 
                this.textBox5.Location = new System.Drawing.Point(643, 47);
                this.textBox5.Multiline = true;
                this.textBox5.Name = "textBox5";
                this.textBox5.ReadOnly = true;
                this.textBox5.Size = new System.Drawing.Size(289, 449);
                this.textBox5.TabIndex = 4;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(151, 9);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(50, 13);
                this.label1.TabIndex = 5;
                this.label1.Text = "Czytnik 1";
                this.label1.Click += new System.EventHandler(this.label1_Click);
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(462, 9);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(50, 13);
                this.label2.TabIndex = 6;
                this.label2.Text = "Czytnik 2";
                this.label2.Click += new System.EventHandler(this.label2_Click);
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(123, 333);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(60, 13);
                this.label3.TabIndex = 7;
                this.label3.Text = "Drukarka 1";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(453, 333);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(60, 13);
                this.label4.TabIndex = 8;
                this.label4.Text = "Drukarka 2";
                this.label4.Click += new System.EventHandler(this.label4_Click);
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(774, 26);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(40, 13);
                this.label5.TabIndex = 9;
                this.label5.Text = "Logger";
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(126, 267);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.TabIndex = 10;
                this.button1.Text = "Załaduj";
                this.button1.UseVisualStyleBackColor = true;
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(456, 267);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(75, 23);
                this.button2.TabIndex = 11;
                this.button2.Text = "Załaduj";
                this.button2.UseVisualStyleBackColor = true;
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(948, 741);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.textBox5);
                this.Controls.Add(this.textBox4);
                this.Controls.Add(this.textBox3);
                this.Controls.Add(this.textBox2);
                this.Controls.Add(this.textBox1);
                this.Name = "Form1";
                this.Text = "Projekt Systemy Operacyjne";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button button2;
            public System.Windows.Forms.TextBox textBox1;
            public System.Windows.Forms.TextBox textBox2;
            public System.Windows.Forms.TextBox textBox3;
            public System.Windows.Forms.TextBox textBox4;
            public System.Windows.Forms.TextBox textBox5;
            public int x;
        }
}


