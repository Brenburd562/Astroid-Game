namespace Nuke_Astroid_Game
{
    partial class MainMenu
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
            this.TItle = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.endGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TItle
            // 
            this.TItle.AutoSize = true;
            this.TItle.Font = new System.Drawing.Font("OCR A Extended", 40F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TItle.ForeColor = System.Drawing.Color.White;
            this.TItle.Location = new System.Drawing.Point(150, 223);
            this.TItle.Name = "TItle";
            this.TItle.Size = new System.Drawing.Size(700, 123);
            this.TItle.TabIndex = 0;
            this.TItle.Text = "ASTEROIDS";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.FlatAppearance.BorderSize = 2;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("OCR A Extended", 40F, System.Drawing.FontStyle.Underline);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(186, 365);
            this.StartButton.Margin = new System.Windows.Forms.Padding(0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(628, 181);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // endGame
            // 
            this.endGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.endGame.FlatAppearance.BorderSize = 2;
            this.endGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGame.Font = new System.Drawing.Font("OCR A Extended", 40F, System.Drawing.FontStyle.Underline);
            this.endGame.ForeColor = System.Drawing.Color.White;
            this.endGame.Location = new System.Drawing.Point(186, 561);
            this.endGame.Margin = new System.Windows.Forms.Padding(0);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(628, 181);
            this.endGame.TabIndex = 2;
            this.endGame.Text = "EXIT";
            this.endGame.UseVisualStyleBackColor = false;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TItle);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TItle;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button endGame;
    }
}
