namespace Hangman
{
    partial class Play
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
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.labelSearchWord = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Location = new System.Drawing.Point(88, 46);
            this.pictureBoxPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(296, 350);
            this.pictureBoxPlay.TabIndex = 0;
            this.pictureBoxPlay.TabStop = false;
            // 
            // labelSearchWord
            // 
            this.labelSearchWord.AutoSize = true;
            this.labelSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchWord.Location = new System.Drawing.Point(517, 101);
            this.labelSearchWord.Name = "labelSearchWord";
            this.labelSearchWord.Size = new System.Drawing.Size(62, 36);
            this.labelSearchWord.TabIndex = 1;
            this.labelSearchWord.Text = "test";
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(590, 239);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(31, 24);
            this.tbLetter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gib einen Buchstaben ein:";
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(523, 310);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(173, 24);
            this.tbWord.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oder das Wort, das du vermutest:";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(556, 372);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(105, 48);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Raten";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.labelSearchWord);
            this.Controls.Add(this.pictureBoxPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Play";
            this.Text = "Play";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.Label labelSearchWord;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuess;
    }
}