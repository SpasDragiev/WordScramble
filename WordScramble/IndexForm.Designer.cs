namespace WordScramble
{
    partial class IndexForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelScrambledWordCaption;
        private System.Windows.Forms.Label labelScrambledWord;
        private System.Windows.Forms.Label labelAttempts;
        private System.Windows.Forms.Label labelAttemptsCount;
        private System.Windows.Forms.Label labelGuessedWords;
        private System.Windows.Forms.Label labelGuessedCount;
        private System.Windows.Forms.Label labelFailedAttempts;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxFailedAttempts;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonSkip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelScrambledWordCaption = new System.Windows.Forms.Label();
            this.labelScrambledWord = new System.Windows.Forms.Label();
            this.labelAttempts = new System.Windows.Forms.Label();
            this.labelAttemptsCount = new System.Windows.Forms.Label();
            this.labelGuessedWords = new System.Windows.Forms.Label();
            this.labelGuessedCount = new System.Windows.Forms.Label();
            this.labelFailedAttempts = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxFailedAttempts = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(120, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(280, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Word Scramble";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelScrambledWordCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelScrambledWordCaption.Location = new System.Drawing.Point(30, 80);
            this.labelScrambledWordCaption.Name = "labelScrambledWordCaption";
            this.labelScrambledWordCaption.Size = new System.Drawing.Size(150, 25);
            this.labelScrambledWordCaption.TabIndex = 1;
            this.labelScrambledWordCaption.Text = "Scrambled word:";
            this.labelScrambledWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScrambledWord.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.labelScrambledWord.Location = new System.Drawing.Point(180, 75);
            this.labelScrambledWord.Name = "labelScrambledWord";
            this.labelScrambledWord.Size = new System.Drawing.Size(280, 40);
            this.labelScrambledWord.TabIndex = 2;
            this.labelScrambledWord.Text = "...";
            this.labelScrambledWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxInput.Location = new System.Drawing.Point(180, 130);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(180, 29);
            this.textBoxInput.TabIndex = 1;
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCheck.Location = new System.Drawing.Point(370, 128);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(90, 32);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            this.buttonSkip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSkip.Location = new System.Drawing.Point(370, 168);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(90, 32);
            this.buttonSkip.TabIndex = 4;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            this.labelAttempts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAttempts.Location = new System.Drawing.Point(30, 175);
            this.labelAttempts.Name = "labelAttempts";
            this.labelAttempts.Size = new System.Drawing.Size(120, 25);
            this.labelAttempts.TabIndex = 5;
            this.labelAttempts.Text = "Attempts:";
            this.labelAttemptsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelAttemptsCount.Location = new System.Drawing.Point(120, 175);
            this.labelAttemptsCount.Name = "labelAttemptsCount";
            this.labelAttemptsCount.Size = new System.Drawing.Size(40, 25);
            this.labelAttemptsCount.TabIndex = 6;
            this.labelAttemptsCount.Text = "0";
            this.labelGuessedWords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGuessedWords.Location = new System.Drawing.Point(30, 210);
            this.labelGuessedWords.Name = "labelGuessedWords";
            this.labelGuessedWords.Size = new System.Drawing.Size(120, 25);
            this.labelGuessedWords.TabIndex = 7;
            this.labelGuessedWords.Text = "Guessed words:";
            this.labelGuessedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelGuessedCount.Location = new System.Drawing.Point(155, 210);
            this.labelGuessedCount.Name = "labelGuessedCount";
            this.labelGuessedCount.Size = new System.Drawing.Size(40, 25);
            this.labelGuessedCount.TabIndex = 8;
            this.labelGuessedCount.Text = "0";
            this.labelFailedAttempts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFailedAttempts.Location = new System.Drawing.Point(30, 250);
            this.labelFailedAttempts.Name = "labelFailedAttempts";
            this.labelFailedAttempts.Size = new System.Drawing.Size(150, 25);
            this.labelFailedAttempts.TabIndex = 9;
            this.labelFailedAttempts.Text = "Failed attempts:";
            this.textBoxFailedAttempts.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxFailedAttempts.Location = new System.Drawing.Point(30, 280);
            this.textBoxFailedAttempts.Multiline = true;
            this.textBoxFailedAttempts.Name = "textBoxFailedAttempts";
            this.textBoxFailedAttempts.ReadOnly = true;
            this.textBoxFailedAttempts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFailedAttempts.Size = new System.Drawing.Size(430, 100);
            this.textBoxFailedAttempts.TabIndex = 2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 411);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelScrambledWordCaption);
            this.Controls.Add(this.labelScrambledWord);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.labelAttemptsCount);
            this.Controls.Add(this.labelGuessedWords);
            this.Controls.Add(this.labelGuessedCount);
            this.Controls.Add(this.labelFailedAttempts);
            this.Controls.Add(this.textBoxFailedAttempts);
            this.MinimumSize = new System.Drawing.Size(510, 450);
            this.MaximumSize = new System.Drawing.Size(510, 450);
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Scramble";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
