namespace Kursach
{
    partial class PracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm));
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PracticeBox = new System.Windows.Forms.TextBox();
            this.Practice3 = new System.Windows.Forms.Button();
            this.Practice2 = new System.Windows.Forms.Button();
            this.Practice1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonExit.Location = new System.Drawing.Point(64, 485);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(181, 39);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "назад";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // PracticeBox
            // 
            this.PracticeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeBox.Location = new System.Drawing.Point(273, 15);
            this.PracticeBox.Margin = new System.Windows.Forms.Padding(4);
            this.PracticeBox.Multiline = true;
            this.PracticeBox.Name = "PracticeBox";
            this.PracticeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PracticeBox.Size = new System.Drawing.Size(776, 523);
            this.PracticeBox.TabIndex = 8;
            // 
            // Practice3
            // 
            this.Practice3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Practice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Practice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Practice3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Practice3.Location = new System.Drawing.Point(65, 330);
            this.Practice3.Margin = new System.Windows.Forms.Padding(4);
            this.Practice3.Name = "Practice3";
            this.Practice3.Size = new System.Drawing.Size(181, 62);
            this.Practice3.TabIndex = 7;
            this.Practice3.Text = "Практика 3";
            this.Practice3.UseVisualStyleBackColor = false;
            this.Practice3.Click += new System.EventHandler(this.Practice3_Click);
            // 
            // Practice2
            // 
            this.Practice2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Practice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Practice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Practice2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Practice2.Location = new System.Drawing.Point(65, 245);
            this.Practice2.Margin = new System.Windows.Forms.Padding(4);
            this.Practice2.Name = "Practice2";
            this.Practice2.Size = new System.Drawing.Size(181, 62);
            this.Practice2.TabIndex = 6;
            this.Practice2.Text = "Практика 2";
            this.Practice2.UseVisualStyleBackColor = false;
            this.Practice2.Click += new System.EventHandler(this.Practice2_Click);
            // 
            // Practice1
            // 
            this.Practice1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Practice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Practice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Practice1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Practice1.Location = new System.Drawing.Point(65, 160);
            this.Practice1.Margin = new System.Windows.Forms.Padding(4);
            this.Practice1.Name = "Practice1";
            this.Practice1.Size = new System.Drawing.Size(181, 62);
            this.Practice1.TabIndex = 5;
            this.Practice1.Text = "Практика 1";
            this.Practice1.UseVisualStyleBackColor = false;
            this.Practice1.Click += new System.EventHandler(this.Practice1_Click);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PracticeBox);
            this.Controls.Add(this.Practice3);
            this.Controls.Add(this.Practice2);
            this.Controls.Add(this.Practice1);
            this.Controls.Add(this.ButtonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracticeForm";
            this.Text = "Практика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox PracticeBox;
        private System.Windows.Forms.Button Practice3;
        private System.Windows.Forms.Button Practice2;
        private System.Windows.Forms.Button Practice1;
    }
}