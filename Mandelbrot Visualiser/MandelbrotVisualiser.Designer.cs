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
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MandelbrotPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IterationTextBox = new System.Windows.Forms.TextBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotPictureBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 3);
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
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Left click to center targeted coordinate.\r\nMWheel to zoom in/out.";
            // 
            // MandelbrotPictureBox
            // 
            this.MandelbrotPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MandelbrotPictureBox.Name = "MandelbrotPictureBox";
            this.MandelbrotPictureBox.Size = new System.Drawing.Size(611, 611);
            this.MandelbrotPictureBox.TabIndex = 11;
            this.MandelbrotPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Iterations:";
            // 
            // IterationTextBox
            // 
            this.IterationTextBox.Location = new System.Drawing.Point(6, 83);
            this.IterationTextBox.Name = "IterationTextBox";
            this.IterationTextBox.Size = new System.Drawing.Size(100, 20);
            this.IterationTextBox.TabIndex = 13;
            this.IterationTextBox.Text = "250";
            this.IterationTextBox.TextChanged += new System.EventHandler(this.IterationTextBox_TextChanged);
            this.IterationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IterationTextBox_KeyPress);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.ResetButton);
            this.ControlPanel.Controls.Add(this.IterationTextBox);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Location = new System.Drawing.Point(617, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(200, 108);
            this.ControlPanel.TabIndex = 14;
            // 
            // VisualiserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 611);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.MandelbrotPictureBox);
            this.Name = "VisualiserWindow";
            this.ShowIcon = false;
            this.Text = "Mandelbrot Visualiser";
            this.Load += new System.EventHandler(this.VisualiserWindow_Load);
            this.SizeChanged += new System.EventHandler(this.VisualiserWindow_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotPictureBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MandelbrotPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IterationTextBox;
        private System.Windows.Forms.Panel ControlPanel;
    }
}

