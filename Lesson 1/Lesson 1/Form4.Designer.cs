namespace Lesson_1
{
    partial class Form4
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
            this.textBox_Demo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Demo
            // 
            this.textBox_Demo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Demo.BackColor = System.Drawing.Color.Wheat;
            this.textBox_Demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Demo.Location = new System.Drawing.Point(306, 134);
            this.textBox_Demo.Multiline = true;
            this.textBox_Demo.Name = "textBox_Demo";
            this.textBox_Demo.ReadOnly = true;
            this.textBox_Demo.Size = new System.Drawing.Size(165, 154);
            this.textBox_Demo.TabIndex = 0;
            this.textBox_Demo.Text = "       Move me!\r\n\r\n \"A\"  or  ←  — left\r\n \"S\"  or   ↓   — down\r\n \"D\"  or  →  — rig" +
    "ht\r\n \"W\" or  ↑    — up\r\n";
            this.textBox_Demo.WordWrap = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Demo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Demo;
    }
}