namespace Magma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.VideoLessonButton = new System.Windows.Forms.Button();
            this.TheoryButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.CryptButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.AutoSize = true;
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.VideoLessonButton, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.TheoryButton, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.TestButton, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.CryptButton, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.AboutButton, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.ExitButton, 0, 5);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(50, 50);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 6;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(325, 302);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // VideoLessonButton
            // 
            this.VideoLessonButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoLessonButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoLessonButton.Location = new System.Drawing.Point(10, 210);
            this.VideoLessonButton.Margin = new System.Windows.Forms.Padding(10);
            this.VideoLessonButton.Name = "VideoLessonButton";
            this.VideoLessonButton.Size = new System.Drawing.Size(305, 30);
            this.VideoLessonButton.TabIndex = 5;
            this.VideoLessonButton.Text = "Видеоурок по шифру \"Магма\"";
            this.VideoLessonButton.UseVisualStyleBackColor = true;
            this.VideoLessonButton.Click += new System.EventHandler(this.VideoLessonButton_Click);
            // 
            // TheoryButton
            // 
            this.TheoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheoryButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheoryButton.Location = new System.Drawing.Point(10, 160);
            this.TheoryButton.Margin = new System.Windows.Forms.Padding(10);
            this.TheoryButton.Name = "TheoryButton";
            this.TheoryButton.Size = new System.Drawing.Size(305, 30);
            this.TheoryButton.TabIndex = 4;
            this.TheoryButton.Text = "Теоретические основы шифра \"Магма\"";
            this.TheoryButton.UseVisualStyleBackColor = true;
            this.TheoryButton.Click += new System.EventHandler(this.TheoryButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestButton.Location = new System.Drawing.Point(10, 10);
            this.TestButton.Margin = new System.Windows.Forms.Padding(10);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(305, 30);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Тест";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // CryptButton
            // 
            this.CryptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CryptButton.Location = new System.Drawing.Point(10, 60);
            this.CryptButton.Margin = new System.Windows.Forms.Padding(10);
            this.CryptButton.Name = "CryptButton";
            this.CryptButton.Size = new System.Drawing.Size(305, 30);
            this.CryptButton.TabIndex = 1;
            this.CryptButton.Text = "Шифрование/Дешифрование";
            this.CryptButton.UseVisualStyleBackColor = true;
            this.CryptButton.Click += new System.EventHandler(this.CryptButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutButton.Location = new System.Drawing.Point(10, 110);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(10);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(305, 30);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "О программе";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(10, 260);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(305, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 402);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(441, 441);
            this.MinimumSize = new System.Drawing.Size(441, 441);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Шифр \"Магма\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button CryptButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TheoryButton;
        private System.Windows.Forms.Button VideoLessonButton;
    }
}

