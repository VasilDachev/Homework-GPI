namespace Hw_Task1
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnCounter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbCouner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(218, 196);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(150, 87);
            this.btnCounter.TabIndex = 0;
            this.btnCounter.Text = "Click me!";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(382, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 87);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbCouner
            // 
            this.tbCouner.Location = new System.Drawing.Point(218, 168);
            this.tbCouner.Name = "tbCouner";
            this.tbCouner.Size = new System.Drawing.Size(100, 22);
            this.tbCouner.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCouner);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbCouner;
    }
}

