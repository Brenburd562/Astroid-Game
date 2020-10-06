namespace Nuke_Astroid_Game
{
    partial class endScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreLabel = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Underline);
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(168, 307);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(580, 93);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "SCORE: 000";
            // 
            // MainButton
            // 
            this.MainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MainButton.FlatAppearance.BorderSize = 2;
            this.MainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Font = new System.Drawing.Font("OCR A Extended", 40F, System.Drawing.FontStyle.Underline);
            this.MainButton.ForeColor = System.Drawing.Color.White;
            this.MainButton.Location = new System.Drawing.Point(172, 507);
            this.MainButton.Margin = new System.Windows.Forms.Padding(0);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(628, 302);
            this.MainButton.TabIndex = 5;
            this.MainButton.Text = "MAIN MENU";
            this.MainButton.UseVisualStyleBackColor = false;
            this.MainButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "Good Try Pilot!";
            // 
            // endScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.label1);
            this.Name = "endScreen";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.Load += new System.EventHandler(this.endScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label label1;
    }
}
