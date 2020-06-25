namespace Hangman
{
    partial class Gratulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMistakes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gewonnen!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fehlversuche:";
            // 
            // labelMistakes
            // 
            this.labelMistakes.AutoSize = true;
            this.labelMistakes.Location = new System.Drawing.Point(127, 152);
            this.labelMistakes.Name = "labelMistakes";
            this.labelMistakes.Size = new System.Drawing.Size(46, 17);
            this.labelMistakes.TabIndex = 2;
            this.labelMistakes.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zeit in Sekunden:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(126, 227);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(46, 17);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "label4";
            // 
            // Gratulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 328);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMistakes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gratulation";
            this.Text = "Gratulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMistakes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTime;
    }
}