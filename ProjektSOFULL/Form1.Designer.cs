namespace ProjektSOFULL
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
            this.czytnik1 = new System.Windows.Forms.TextBox();
            this.drukarka1 = new System.Windows.Forms.TextBox();
            this.czytnik2 = new System.Windows.Forms.TextBox();
            this.logger = new System.Windows.Forms.TextBox();
            this.drukarka2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zaladuj1 = new System.Windows.Forms.Button();
            this.zaladuj2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // czytnik1
            // 
            this.czytnik1.Location = new System.Drawing.Point(53, 28);
            this.czytnik1.Multiline = true;
            this.czytnik1.Name = "czytnik1";
            this.czytnik1.Size = new System.Drawing.Size(192, 195);
            this.czytnik1.TabIndex = 0;
            // 
            // drukarka1
            // 
            this.drukarka1.Location = new System.Drawing.Point(53, 265);
            this.drukarka1.Multiline = true;
            this.drukarka1.Name = "drukarka1";
            this.drukarka1.ReadOnly = true;
            this.drukarka1.Size = new System.Drawing.Size(192, 195);
            this.drukarka1.TabIndex = 1;
            // 
            // czytnik2
            // 
            this.czytnik2.Location = new System.Drawing.Point(292, 28);
            this.czytnik2.Multiline = true;
            this.czytnik2.Name = "czytnik2";
            this.czytnik2.Size = new System.Drawing.Size(192, 195);
            this.czytnik2.TabIndex = 2;
            // 
            // logger
            // 
            this.logger.Location = new System.Drawing.Point(640, 28);
            this.logger.Multiline = true;
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            this.logger.Size = new System.Drawing.Size(307, 409);
            this.logger.TabIndex = 3;
            // 
            // drukarka2
            // 
            this.drukarka2.Location = new System.Drawing.Point(292, 265);
            this.drukarka2.Multiline = true;
            this.drukarka2.Name = "drukarka2";
            this.drukarka2.ReadOnly = true;
            this.drukarka2.Size = new System.Drawing.Size(192, 195);
            this.drukarka2.TabIndex = 4;
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
            // zaladuj1
            // 
            this.zaladuj1.Location = new System.Drawing.Point(536, 133);
            this.zaladuj1.Name = "zaladuj1";
            this.zaladuj1.Size = new System.Drawing.Size(75, 23);
            this.zaladuj1.TabIndex = 10;
            this.zaladuj1.Text = "Zaladuj1";
            this.zaladuj1.UseVisualStyleBackColor = true;
            this.zaladuj1.Click += new System.EventHandler(this.zaladuj1_Click);
            // 
            // zaladuj2
            // 
            this.zaladuj2.Location = new System.Drawing.Point(536, 260);
            this.zaladuj2.Name = "zaladuj2";
            this.zaladuj2.Size = new System.Drawing.Size(75, 23);
            this.zaladuj2.TabIndex = 11;
            this.zaladuj2.Text = "Zaladuj2";
            this.zaladuj2.UseVisualStyleBackColor = true;
            this.zaladuj2.Click += new System.EventHandler(this.zaladuj2_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(536, 28);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 12;
            this.start.Text = "Uruchom";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Czysc1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Czysc2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.zaladuj2);
            this.Controls.Add(this.zaladuj1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drukarka2);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.czytnik2);
            this.Controls.Add(this.drukarka1);
            this.Controls.Add(this.czytnik1);
            this.Name = "Form1";
            this.Text = "System SO FULL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox czytnik1;
        private System.Windows.Forms.TextBox drukarka1;
        private System.Windows.Forms.TextBox czytnik2;
        private System.Windows.Forms.TextBox logger;
        private System.Windows.Forms.TextBox drukarka2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button zaladuj1;
        private System.Windows.Forms.Button zaladuj2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        
    }
}