namespace Mandelbrot_Visualiser
{
    partial class VisualiserWindow
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
            this.MandelbrotPanel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PowerText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MandelbrotPanel
            // 
            this.MandelbrotPanel.Location = new System.Drawing.Point(270, 36);
            this.MandelbrotPanel.Name = "MandelbrotPanel";
            this.MandelbrotPanel.Size = new System.Drawing.Size(450, 450);
            this.MandelbrotPanel.TabIndex = 1;
            this.MandelbrotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MandelbrotPanel_Paint);
            this.MandelbrotPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MandelbrotPanel_MouseClick);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(838, 139);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Left click to center targeted coordinate.\r\nMWheel to zoom in/out.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Power (z^n + c):";
            // 
            // PowerText
            // 
            this.PowerText.Location = new System.Drawing.Point(838, 52);
            this.PowerText.Name = "PowerText";
            this.PowerText.Size = new System.Drawing.Size(100, 20);
            this.PowerText.TabIndex = 12;
            this.PowerText.Text = "2";
            this.PowerText.TextChanged += new System.EventHandler(this.PowerText_TextChanged);
            this.PowerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PowerText_KeyPress);
            // 
            // VisualiserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.PowerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MandelbrotPanel);
            this.Name = "VisualiserWindow";
            this.ShowIcon = false;
            this.Text = "Mandelbrot Visualiser";
            this.Load += new System.EventHandler(this.VisualiserWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MandelbrotPanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PowerText;
    }
}

