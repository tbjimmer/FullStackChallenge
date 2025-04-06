namespace FullStackChallenge
{
    partial class GameForm
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
            this.lblWordDisplay = new System.Windows.Forms.Label();
            this.lblStrikes = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblCorrectLetters = new System.Windows.Forms.Label();
            this.lblWrongLetters = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWordDisplay
            // 
            this.lblWordDisplay.AutoSize = true;
            this.lblWordDisplay.Location = new System.Drawing.Point(345, 74);
            this.lblWordDisplay.Name = "lblWordDisplay";
            this.lblWordDisplay.Size = new System.Drawing.Size(165, 16);
            this.lblWordDisplay.TabIndex = 0;
            this.lblWordDisplay.Text = "wordToGuessPlaceholder";
            // 
            // lblStrikes
            // 
            this.lblStrikes.AutoSize = true;
            this.lblStrikes.Location = new System.Drawing.Point(599, 162);
            this.lblStrikes.Name = "lblStrikes";
            this.lblStrikes.Size = new System.Drawing.Size(48, 16);
            this.lblStrikes.TabIndex = 1;
            this.lblStrikes.Text = "Strikes";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(286, 194);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(102, 22);
            this.txtGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(415, 192);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(98, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblCorrectLetters
            // 
            this.lblCorrectLetters.AutoSize = true;
            this.lblCorrectLetters.Location = new System.Drawing.Point(249, 294);
            this.lblCorrectLetters.Name = "lblCorrectLetters";
            this.lblCorrectLetters.Size = new System.Drawing.Size(96, 16);
            this.lblCorrectLetters.TabIndex = 4;
            this.lblCorrectLetters.Text = "Correct Letters:";
            // 
            // lblWrongLetters
            // 
            this.lblWrongLetters.AutoSize = true;
            this.lblWrongLetters.Location = new System.Drawing.Point(518, 294);
            this.lblWrongLetters.Name = "lblWrongLetters";
            this.lblWrongLetters.Size = new System.Drawing.Size(93, 16);
            this.lblWrongLetters.TabIndex = 5;
            this.lblWrongLetters.Text = "Wrong Letters:";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(286, 395);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(158, 24);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWrongLetters);
            this.Controls.Add(this.lblCorrectLetters);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblStrikes);
            this.Controls.Add(this.lblWordDisplay);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordDisplay;
        private System.Windows.Forms.Label lblStrikes;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblCorrectLetters;
        private System.Windows.Forms.Label lblWrongLetters;
        private System.Windows.Forms.Button btnRestart;
    }
}