namespace Windows_Forms
{
    partial class MSGBox_via_Button_click
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
            this.ButtonMSGBoxClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMSGBoxClick
            // 
            this.ButtonMSGBoxClick.BackColor = System.Drawing.Color.Beige;
            this.ButtonMSGBoxClick.Location = new System.Drawing.Point(12, 12);
            this.ButtonMSGBoxClick.Name = "ButtonMSGBoxClick";
            this.ButtonMSGBoxClick.Size = new System.Drawing.Size(205, 153);
            this.ButtonMSGBoxClick.TabIndex = 0;
            this.ButtonMSGBoxClick.Text = "Press Me!";
            this.ButtonMSGBoxClick.UseVisualStyleBackColor = false;
            this.ButtonMSGBoxClick.Click += new System.EventHandler(this.ButtonMSGBoxClick_Click);
            // 
            // MSGBox_via_Button_click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(229, 177);
            this.Controls.Add(this.ButtonMSGBoxClick);
            this.Name = "MSGBox_via_Button_click";
            this.Text = "MSGBox";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonMSGBoxClick;
    }
}