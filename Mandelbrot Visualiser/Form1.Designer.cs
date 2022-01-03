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
            this.xOffsetValue = new System.Windows.Forms.TextBox();
            this.yOffsetValue = new System.Windows.Forms.TextBox();
            this.SetOffsets = new System.Windows.Forms.Button();
            this.ShiftViewRight = new System.Windows.Forms.Button();
            this.ShiftViewLeft = new System.Windows.Forms.Button();
            this.ShiftViewUp = new System.Windows.Forms.Button();
            this.ShiftViewDown = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MandelbrotPanel
            // 
            this.MandelbrotPanel.Location = new System.Drawing.Point(283, 36);
            this.MandelbrotPanel.Name = "MandelbrotPanel";
            this.MandelbrotPanel.Size = new System.Drawing.Size(500, 500);
            this.MandelbrotPanel.TabIndex = 1;
            this.MandelbrotPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MandelbrotPanel_MouseClick);
            // 
            // xOffsetValue
            // 
            this.xOffsetValue.Location = new System.Drawing.Point(841, 140);
            this.xOffsetValue.Name = "xOffsetValue";
            this.xOffsetValue.Size = new System.Drawing.Size(100, 20);
            this.xOffsetValue.TabIndex = 2;
            this.xOffsetValue.Text = "0";
            this.xOffsetValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xOffsetValue_KeyPress);
            // 
            // yOffsetValue
            // 
            this.yOffsetValue.Location = new System.Drawing.Point(841, 187);
            this.yOffsetValue.Name = "yOffsetValue";
            this.yOffsetValue.Size = new System.Drawing.Size(100, 20);
            this.yOffsetValue.TabIndex = 3;
            this.yOffsetValue.Text = "0";
            this.yOffsetValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xOffsetValue_KeyPress);
            // 
            // SetOffsets
            // 
            this.SetOffsets.Location = new System.Drawing.Point(961, 162);
            this.SetOffsets.Name = "SetOffsets";
            this.SetOffsets.Size = new System.Drawing.Size(75, 23);
            this.SetOffsets.TabIndex = 4;
            this.SetOffsets.Text = "Set";
            this.SetOffsets.UseVisualStyleBackColor = true;
            this.SetOffsets.Click += new System.EventHandler(this.SetOffsets_Click);
            // 
            // ShiftViewRight
            // 
            this.ShiftViewRight.Location = new System.Drawing.Point(789, 271);
            this.ShiftViewRight.Name = "ShiftViewRight";
            this.ShiftViewRight.Size = new System.Drawing.Size(29, 23);
            this.ShiftViewRight.TabIndex = 5;
            this.ShiftViewRight.Text = ">";
            this.ShiftViewRight.UseVisualStyleBackColor = true;
            this.ShiftViewRight.Click += new System.EventHandler(this.ShiftView_Click);
            // 
            // ShiftViewLeft
            // 
            this.ShiftViewLeft.Location = new System.Drawing.Point(248, 283);
            this.ShiftViewLeft.Name = "ShiftViewLeft";
            this.ShiftViewLeft.Size = new System.Drawing.Size(29, 23);
            this.ShiftViewLeft.TabIndex = 6;
            this.ShiftViewLeft.Text = "<";
            this.ShiftViewLeft.UseVisualStyleBackColor = true;
            this.ShiftViewLeft.Click += new System.EventHandler(this.ShiftView_Click);
            // 
            // ShiftViewUp
            // 
            this.ShiftViewUp.Location = new System.Drawing.Point(521, 7);
            this.ShiftViewUp.Name = "ShiftViewUp";
            this.ShiftViewUp.Size = new System.Drawing.Size(29, 23);
            this.ShiftViewUp.TabIndex = 7;
            this.ShiftViewUp.Text = "^";
            this.ShiftViewUp.UseVisualStyleBackColor = true;
            this.ShiftViewUp.Click += new System.EventHandler(this.ShiftView_Click);
            // 
            // ShiftViewDown
            // 
            this.ShiftViewDown.Location = new System.Drawing.Point(521, 542);
            this.ShiftViewDown.Name = "ShiftViewDown";
            this.ShiftViewDown.Size = new System.Drawing.Size(29, 23);
            this.ShiftViewDown.TabIndex = 8;
            this.ShiftViewDown.Text = "v";
            this.ShiftViewDown.UseVisualStyleBackColor = true;
            this.ShiftViewDown.Click += new System.EventHandler(this.ShiftView_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(905, 282);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // VisualiserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ShiftViewDown);
            this.Controls.Add(this.ShiftViewUp);
            this.Controls.Add(this.ShiftViewLeft);
            this.Controls.Add(this.ShiftViewRight);
            this.Controls.Add(this.SetOffsets);
            this.Controls.Add(this.yOffsetValue);
            this.Controls.Add(this.xOffsetValue);
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
        private System.Windows.Forms.TextBox xOffsetValue;
        private System.Windows.Forms.TextBox yOffsetValue;
        private System.Windows.Forms.Button SetOffsets;
        private System.Windows.Forms.Button ShiftViewRight;
        private System.Windows.Forms.Button ShiftViewLeft;
        private System.Windows.Forms.Button ShiftViewUp;
        private System.Windows.Forms.Button ShiftViewDown;
        private System.Windows.Forms.Button ResetButton;
    }
}

