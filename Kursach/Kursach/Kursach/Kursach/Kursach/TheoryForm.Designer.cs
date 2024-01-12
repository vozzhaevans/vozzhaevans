namespace Kursach
{
    partial class TheoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryForm));
            this.Theme1 = new System.Windows.Forms.Button();
            this.Theme2 = new System.Windows.Forms.Button();
            this.Theme3 = new System.Windows.Forms.Button();
            this.ThemeBox = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Theme1
            // 
            this.Theme1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Theme1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Theme1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Theme1.Location = new System.Drawing.Point(49, 129);
            this.Theme1.Name = "Theme1";
            this.Theme1.Size = new System.Drawing.Size(136, 50);
            this.Theme1.TabIndex = 0;
            this.Theme1.Text = "Тема 1";
            this.Theme1.UseVisualStyleBackColor = false;
            this.Theme1.Click += new System.EventHandler(this.Theme1_Click);
            // 
            // Theme2
            // 
            this.Theme2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Theme2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Theme2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Theme2.Location = new System.Drawing.Point(49, 198);
            this.Theme2.Name = "Theme2";
            this.Theme2.Size = new System.Drawing.Size(136, 50);
            this.Theme2.TabIndex = 1;
            this.Theme2.Text = "Тема 2";
            this.Theme2.UseVisualStyleBackColor = false;
            this.Theme2.Click += new System.EventHandler(this.Theme2_Click);
            // 
            // Theme3
            // 
            this.Theme3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Theme3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theme3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Theme3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Theme3.Location = new System.Drawing.Point(49, 267);
            this.Theme3.Name = "Theme3";
            this.Theme3.Size = new System.Drawing.Size(136, 50);
            this.Theme3.TabIndex = 3;
            this.Theme3.Text = "Тема 3";
            this.Theme3.UseVisualStyleBackColor = false;
            this.Theme3.Click += new System.EventHandler(this.Theme3_Click);
            // 
            // ThemeBox
            // 
            this.ThemeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeBox.Location = new System.Drawing.Point(205, 12);
            this.ThemeBox.Multiline = true;
            this.ThemeBox.Name = "ThemeBox";
            this.ThemeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ThemeBox.Size = new System.Drawing.Size(440, 426);
            this.ThemeBox.TabIndex = 4;
            this.ThemeBox.TextChanged += new System.EventHandler(this.ThemeBox_TextChanged);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonExit.Location = new System.Drawing.Point(48, 394);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(136, 32);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "назад";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PreviousButton.Location = new System.Drawing.Point(734, 394);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(136, 32);
            this.PreviousButton.TabIndex = 6;
            this.PreviousButton.Text = "<---";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextButton.Location = new System.Drawing.Point(1019, 394);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(136, 32);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "--->";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ThemeBox);
            this.Controls.Add(this.Theme3);
            this.Controls.Add(this.Theme2);
            this.Controls.Add(this.Theme1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheoryForm";
            this.Text = "Теория";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Theme1;
        private System.Windows.Forms.Button Theme2;
        private System.Windows.Forms.Button Theme3;
        private System.Windows.Forms.TextBox ThemeBox;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
    }
}