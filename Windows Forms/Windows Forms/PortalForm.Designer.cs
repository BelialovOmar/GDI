namespace Windows_Forms
{
    partial class PortalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkMessageBoxviaBtnClick = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkMessageBoxviaBtnClick
            // 
            this.linkMessageBoxviaBtnClick.AutoSize = true;
            this.linkMessageBoxviaBtnClick.Location = new System.Drawing.Point(12, 9);
            this.linkMessageBoxviaBtnClick.Name = "linkMessageBoxviaBtnClick";
            this.linkMessageBoxviaBtnClick.Size = new System.Drawing.Size(200, 20);
            this.linkMessageBoxviaBtnClick.TabIndex = 0;
            this.linkMessageBoxviaBtnClick.TabStop = true;
            this.linkMessageBoxviaBtnClick.Text = "Message Box via Button click";
            this.linkMessageBoxviaBtnClick.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMessageBoxviaBtnClick_LinkClicked);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkMessageBoxviaBtnClick);
            this.Name = "PortalForm";
            this.Text = "Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkMessageBoxviaBtnClick;
    }
}