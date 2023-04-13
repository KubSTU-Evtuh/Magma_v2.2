namespace WinGost
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.encrTextBox = new System.Windows.Forms.TextBox();
            this.decrTextBox = new System.Windows.Forms.TextBox();
            this.fileEncryptButton = new System.Windows.Forms.Button();
            this.fileDecryptButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(77, 10);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(236, 22);
            this.KeyTextBox.TabIndex = 1;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.encrTextBox);
            this.groupBox1.Controls.Add(this.decrTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текст";
            // 
            // encrTextBox
            // 
            this.encrTextBox.Location = new System.Drawing.Point(245, 21);
            this.encrTextBox.Multiline = true;
            this.encrTextBox.Name = "encrTextBox";
            this.encrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encrTextBox.Size = new System.Drawing.Size(209, 162);
            this.encrTextBox.TabIndex = 1;
            // 
            // decrTextBox
            // 
            this.decrTextBox.Location = new System.Drawing.Point(6, 21);
            this.decrTextBox.Multiline = true;
            this.decrTextBox.Name = "decrTextBox";
            this.decrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decrTextBox.Size = new System.Drawing.Size(209, 162);
            this.decrTextBox.TabIndex = 0;
            // 
            // fileEncryptButton
            // 
            this.fileEncryptButton.Location = new System.Drawing.Point(15, 254);
            this.fileEncryptButton.Name = "fileEncryptButton";
            this.fileEncryptButton.Size = new System.Drawing.Size(215, 23);
            this.fileEncryptButton.TabIndex = 7;
            this.fileEncryptButton.Text = "Зашифровать";
            this.fileEncryptButton.UseVisualStyleBackColor = true;
            this.fileEncryptButton.Click += new System.EventHandler(this.FileEncryptButton_Click);
            // 
            // fileDecryptButton
            // 
            this.fileDecryptButton.Location = new System.Drawing.Point(260, 254);
            this.fileDecryptButton.Name = "fileDecryptButton";
            this.fileDecryptButton.Size = new System.Drawing.Size(209, 23);
            this.fileDecryptButton.TabIndex = 8;
            this.fileDecryptButton.Text = "Расшифровать";
            this.fileDecryptButton.UseVisualStyleBackColor = true;
            this.fileDecryptButton.Click += new System.EventHandler(this.FileDecryptButton_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 299);
            this.Controls.Add(this.fileDecryptButton);
            this.Controls.Add(this.fileEncryptButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование алгоритмом Магма";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox encrTextBox;
        private System.Windows.Forms.TextBox decrTextBox;
        private System.Windows.Forms.Button fileEncryptButton;
        private System.Windows.Forms.Button fileDecryptButton;
    }
}

