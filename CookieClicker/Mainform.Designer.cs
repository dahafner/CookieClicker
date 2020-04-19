namespace Danisoft.AutoClicker
{
    partial class Mainform
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
            this.btnGo1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudPause1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClicks1 = new System.Windows.Forms.Label();
            this.lblClicks2 = new System.Windows.Forms.Label();
            this.nudPause2 = new System.Windows.Forms.NumericUpDown();
            this.nudClickCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudInitialDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(16, 95);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(256, 23);
            this.btnGo1.TabIndex = 0;
            this.btnGo1.Text = "Los";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.BtnGo1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dauer in Sekunden:";
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(131, 38);
            this.nudDuration.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(82, 20);
            this.nudDuration.TabIndex = 2;
            // 
            // nudPause1
            // 
            this.nudPause1.Location = new System.Drawing.Point(131, 64);
            this.nudPause1.Name = "nudPause1";
            this.nudPause1.Size = new System.Drawing.Size(82, 20);
            this.nudPause1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pause zwischen Klicks:";
            // 
            // lblClicks1
            // 
            this.lblClicks1.Location = new System.Drawing.Point(219, 11);
            this.lblClicks1.Name = "lblClicks1";
            this.lblClicks1.Size = new System.Drawing.Size(53, 73);
            this.lblClicks1.TabIndex = 4;
            this.lblClicks1.Text = "0";
            this.lblClicks1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClicks2
            // 
            this.lblClicks2.Location = new System.Drawing.Point(219, 139);
            this.lblClicks2.Name = "lblClicks2";
            this.lblClicks2.Size = new System.Drawing.Size(53, 72);
            this.lblClicks2.TabIndex = 10;
            this.lblClicks2.Text = "0";
            this.lblClicks2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPause2
            // 
            this.nudPause2.Location = new System.Drawing.Point(131, 191);
            this.nudPause2.Name = "nudPause2";
            this.nudPause2.Size = new System.Drawing.Size(82, 20);
            this.nudPause2.TabIndex = 9;
            // 
            // nudClickCount
            // 
            this.nudClickCount.Location = new System.Drawing.Point(131, 165);
            this.nudClickCount.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.nudClickCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClickCount.Name = "nudClickCount";
            this.nudClickCount.Size = new System.Drawing.Size(82, 20);
            this.nudClickCount.TabIndex = 8;
            this.nudClickCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pause zwischen Klicks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Anzahl Klicks:";
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(16, 217);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(256, 23);
            this.btnGo2.TabIndex = 5;
            this.btnGo2.Text = "Los";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Click += new System.EventHandler(this.BtnGo2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Startverzögerung:";
            // 
            // nudInitialDelay
            // 
            this.nudInitialDelay.Location = new System.Drawing.Point(131, 12);
            this.nudInitialDelay.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudInitialDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitialDelay.Name = "nudInitialDelay";
            this.nudInitialDelay.Size = new System.Drawing.Size(82, 20);
            this.nudInitialDelay.TabIndex = 2;
            this.nudInitialDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 139);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Startverzögerung:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblClicks2);
            this.Controls.Add(this.nudPause2);
            this.Controls.Add(this.nudClickCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.lblClicks1);
            this.Controls.Add(this.nudPause1);
            this.Controls.Add(this.nudInitialDelay);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CookieClicker";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudPause1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClicks1;
        private System.Windows.Forms.Label lblClicks2;
        private System.Windows.Forms.NumericUpDown nudPause2;
        private System.Windows.Forms.NumericUpDown nudClickCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudInitialDelay;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}

