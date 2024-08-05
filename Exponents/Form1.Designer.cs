namespace Exponents
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
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.xInputLabel = new System.Windows.Forms.Label();
            this.UxOutputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.xResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Location = new System.Drawing.Point(138, 69);
            this.UxInputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(148, 26);
            this.UxInputTextBox.TabIndex = 0;
            // 
            // xInputLabel
            // 
            this.xInputLabel.AutoSize = true;
            this.xInputLabel.Location = new System.Drawing.Point(138, 42);
            this.xInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xInputLabel.Name = "xInputLabel";
            this.xInputLabel.Size = new System.Drawing.Size(127, 20);
            this.xInputLabel.TabIndex = 3;
            this.xInputLabel.Text = "Enter an integer:";
            // 
            // UxOutputLabel
            // 
            this.UxOutputLabel.AutoSize = true;
            this.UxOutputLabel.Location = new System.Drawing.Point(153, 278);
            this.UxOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UxOutputLabel.Name = "UxOutputLabel";
            this.UxOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.UxOutputLabel.TabIndex = 4;
            this.UxOutputLabel.Visible = false;
            // 
            // UxGoButton
            // 
            this.UxGoButton.Location = new System.Drawing.Point(158, 148);
            this.UxGoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(112, 103);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.Text = "Go!";
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // xResetButton
            // 
            this.xResetButton.Location = new System.Drawing.Point(158, 326);
            this.xResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xResetButton.Name = "xResetButton";
            this.xResetButton.Size = new System.Drawing.Size(112, 35);
            this.xResetButton.TabIndex = 7;
            this.xResetButton.Text = "Reset";
            this.xResetButton.UseVisualStyleBackColor = true;
            this.xResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.xResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.UxOutputLabel);
            this.Controls.Add(this.xInputLabel);
            this.Controls.Add(this.UxInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label xInputLabel;
        private System.Windows.Forms.Label UxOutputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button xResetButton;
    }
}

