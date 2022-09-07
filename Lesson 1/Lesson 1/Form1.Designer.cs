namespace Lesson_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TimerDemo = new System.Windows.Forms.Button();
            this.RemoveButtons = new System.Windows.Forms.Button();
            this.child = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clicker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Catch me!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Moving Window";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TimerDemo
            // 
            this.TimerDemo.Location = new System.Drawing.Point(11, 128);
            this.TimerDemo.Name = "TimerDemo";
            this.TimerDemo.Size = new System.Drawing.Size(141, 33);
            this.TimerDemo.TabIndex = 3;
            this.TimerDemo.Text = "Timer";
            this.TimerDemo.UseVisualStyleBackColor = true;
            this.TimerDemo.Click += new System.EventHandler(this.TimerDemo_Click);
            // 
            // RemoveButtons
            // 
            this.RemoveButtons.Location = new System.Drawing.Point(11, 167);
            this.RemoveButtons.Name = "RemoveButtons";
            this.RemoveButtons.Size = new System.Drawing.Size(141, 33);
            this.RemoveButtons.TabIndex = 4;
            this.RemoveButtons.Text = "Remove Buttons";
            this.RemoveButtons.UseVisualStyleBackColor = true;
            this.RemoveButtons.Click += new System.EventHandler(this.RemoveButtons_Click);
            // 
            // child
            // 
            this.child.AutoSize = true;
            this.child.Location = new System.Drawing.Point(100, 266);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(221, 16);
            this.child.TabIndex = 5;
            this.child.TabStop = true;
            this.child.Text = "child сделать норм диайзн потом";
            this.child.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.child_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(397, 327);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "задание2";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(248, 300);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 16);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "задание 3";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.child);
            this.Controls.Add(this.RemoveButtons);
            this.Controls.Add(this.TimerDemo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Portal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button TimerDemo;
        private System.Windows.Forms.Button RemoveButtons;
        private System.Windows.Forms.LinkLabel child;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

