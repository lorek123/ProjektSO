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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.czytnik1, "czytnik1");
            this.czytnik1.Name = "czytnik1";
            // 
            // drukarka1
            // 
            resources.ApplyResources(this.drukarka1, "drukarka1");
            this.drukarka1.Name = "drukarka1";
            this.drukarka1.ReadOnly = true;
            // 
            // czytnik2
            // 
            resources.ApplyResources(this.czytnik2, "czytnik2");
            this.czytnik2.Name = "czytnik2";
            // 
            // logger
            // 
            resources.ApplyResources(this.logger, "logger");
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            // 
            // drukarka2
            // 
            resources.ApplyResources(this.drukarka2, "drukarka2");
            this.drukarka2.Name = "drukarka2";
            this.drukarka2.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // zaladuj1
            // 
            resources.ApplyResources(this.zaladuj1, "zaladuj1");
            this.zaladuj1.Name = "zaladuj1";
            this.zaladuj1.UseVisualStyleBackColor = true;
            this.zaladuj1.Click += new System.EventHandler(this.zaladuj1_Click);
            // 
            // zaladuj2
            // 
            resources.ApplyResources(this.zaladuj2, "zaladuj2");
            this.zaladuj2.Name = "zaladuj2";
            this.zaladuj2.UseVisualStyleBackColor = true;
            this.zaladuj2.Click += new System.EventHandler(this.zaladuj2_Click);
            // 
            // start
            // 
            resources.ApplyResources(this.start, "start");
            this.start.Name = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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