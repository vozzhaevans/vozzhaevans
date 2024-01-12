namespace Kursach
{
    partial class ControlTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTest));
            this.btnNext = new System.Windows.Forms.Button();
            this.answerA = new System.Windows.Forms.RadioButton();
            this.answerB = new System.Windows.Forms.RadioButton();
            this.answerC = new System.Windows.Forms.RadioButton();
            this.controlTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(327, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(136, 32);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "ответить";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.Location = new System.Drawing.Point(231, 342);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(32, 17);
            this.answerA.TabIndex = 10;
            this.answerA.TabStop = true;
            this.answerA.Text = "A";
            this.answerA.UseVisualStyleBackColor = true;
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.Location = new System.Drawing.Point(385, 342);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(32, 17);
            this.answerB.TabIndex = 11;
            this.answerB.TabStop = true;
            this.answerB.Text = "B";
            this.answerB.UseVisualStyleBackColor = true;
            // 
            // answerC
            // 
            this.answerC.AutoSize = true;
            this.answerC.Location = new System.Drawing.Point(526, 342);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(32, 17);
            this.answerC.TabIndex = 12;
            this.answerC.TabStop = true;
            this.answerC.Text = "C";
            this.answerC.UseVisualStyleBackColor = true;
            // 
            // controlTextBox
            // 
            this.controlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlTextBox.Location = new System.Drawing.Point(180, 12);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(433, 282);
            this.controlTextBox.TabIndex = 13;
            this.controlTextBox.Text = "";
            // 
            // ControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlTest";
            this.Text = "ControlTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton answerA;
        private System.Windows.Forms.RadioButton answerB;
        private System.Windows.Forms.RadioButton answerC;
        private System.Windows.Forms.RichTextBox controlTextBox;
    }
}