namespace Kursach
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonToTheory = new System.Windows.Forms.Button();
            this.buttonToPract = new System.Windows.Forms.Button();
            this.buttonToTest = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mainLabelText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToTheory
            // 
            this.buttonToTheory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonToTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToTheory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonToTheory.Location = new System.Drawing.Point(49, 129);
            this.buttonToTheory.Name = "buttonToTheory";
            this.buttonToTheory.Size = new System.Drawing.Size(177, 63);
            this.buttonToTheory.TabIndex = 0;
            this.buttonToTheory.Text = "Теория";
            this.buttonToTheory.UseVisualStyleBackColor = false;
            this.buttonToTheory.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonToPract
            // 
            this.buttonToPract.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonToPract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToPract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonToPract.Location = new System.Drawing.Point(49, 198);
            this.buttonToPract.Name = "buttonToPract";
            this.buttonToPract.Size = new System.Drawing.Size(177, 63);
            this.buttonToPract.TabIndex = 1;
            this.buttonToPract.Text = "Практика";
            this.buttonToPract.UseVisualStyleBackColor = false;
            this.buttonToPract.Click += new System.EventHandler(this.buttonToPract_Click);
            // 
            // buttonToTest
            // 
            this.buttonToTest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonToTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToTest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonToTest.Location = new System.Drawing.Point(49, 267);
            this.buttonToTest.Name = "buttonToTest";
            this.buttonToTest.Size = new System.Drawing.Size(177, 63);
            this.buttonToTest.TabIndex = 2;
            this.buttonToTest.Text = "Тест";
            this.buttonToTest.UseVisualStyleBackColor = false;
            this.buttonToTest.Click += new System.EventHandler(this.buttonToTest_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.exitToolStripMenuItem.Text = "выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.инструкцияToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.оПрограммеToolStripMenuItem1.Text = "о программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click_1);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.инструкцияToolStripMenuItem.Text = "инструкция";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // mainLabelText
            // 
            this.mainLabelText.AutoSize = true;
            this.mainLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabelText.Location = new System.Drawing.Point(273, 220);
            this.mainLabelText.MaximumSize = new System.Drawing.Size(500, 300);
            this.mainLabelText.Name = "mainLabelText";
            this.mainLabelText.Size = new System.Drawing.Size(487, 72);
            this.mainLabelText.TabIndex = 5;
            this.mainLabelText.Text = "Электронное учебное пособие на тему \'поиск слов в тексте\' с теоретической, практи" +
    "ческой частью и тестированием";
            this.mainLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 145);
            this.label1.MaximumSize = new System.Drawing.Size(500, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск слов в тексте\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainLabelText);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonToTest);
            this.Controls.Add(this.buttonToPract);
            this.Controls.Add(this.buttonToTheory);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Курсовая";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToTheory;
        private System.Windows.Forms.Button buttonToPract;
        private System.Windows.Forms.Button buttonToTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label mainLabelText;
        private System.Windows.Forms.Label label1;
    }
}

