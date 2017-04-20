namespace WildFireGDI
{
    partial class MainForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxRandomWind = new System.Windows.Forms.CheckBox();
            this.trackBarWindSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonMiddle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(20, 167);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(82, 26);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxRandomWind
            // 
            this.checkBoxRandomWind.AutoSize = true;
            this.checkBoxRandomWind.Location = new System.Drawing.Point(12, 219);
            this.checkBoxRandomWind.Name = "checkBoxRandomWind";
            this.checkBoxRandomWind.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRandomWind.TabIndex = 1;
            this.checkBoxRandomWind.Text = "Random Wind";
            this.checkBoxRandomWind.UseVisualStyleBackColor = true;
            this.checkBoxRandomWind.CheckedChanged += new System.EventHandler(this.checkBoxRandomWind_CheckedChanged);
            // 
            // trackBarWindSpeed
            // 
            this.trackBarWindSpeed.Location = new System.Drawing.Point(18, 104);
            this.trackBarWindSpeed.Maximum = 5;
            this.trackBarWindSpeed.Name = "trackBarWindSpeed";
            this.trackBarWindSpeed.Size = new System.Drawing.Size(87, 45);
            this.trackBarWindSpeed.TabIndex = 2;
            this.trackBarWindSpeed.Value = 1;
            this.trackBarWindSpeed.Scroll += new System.EventHandler(this.trackBarWindSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Embers";
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(30, 3);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(23, 23);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.Text = "N";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(30, 61);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(23, 23);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = "S";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(59, 32);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(23, 23);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.Text = "E";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(1, 32);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(23, 23);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Text = "W";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonMiddle
            // 
            this.buttonMiddle.Location = new System.Drawing.Point(30, 32);
            this.buttonMiddle.Name = "buttonMiddle";
            this.buttonMiddle.Size = new System.Drawing.Size(23, 23);
            this.buttonMiddle.TabIndex = 8;
            this.buttonMiddle.Text = "0";
            this.buttonMiddle.UseVisualStyleBackColor = true;
            this.buttonMiddle.Click += new System.EventHandler(this.buttonMiddle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.buttonUp);
            this.panel1.Controls.Add(this.buttonMiddle);
            this.panel1.Controls.Add(this.buttonDown);
            this.panel1.Controls.Add(this.buttonLeft);
            this.panel1.Controls.Add(this.buttonRight);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 86);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarWindSpeed);
            this.Controls.Add(this.checkBoxRandomWind);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WILDFIRE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxRandomWind;
        private System.Windows.Forms.TrackBar trackBarWindSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonMiddle;
        private System.Windows.Forms.Panel panel1;
    }
}

