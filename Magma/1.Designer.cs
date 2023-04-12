namespace Magma
{
    partial class InsertValuesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertValuesForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NextStepButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.AutoSize = true;
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainTableLayoutPanel.Controls.Add(this.KeyLabel, 1, 5);
            this.MainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.label3, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.KeyTextBox, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.label4, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.NextStepButton, 1, 6);
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 7;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(837, 385);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyLabel.Location = new System.Drawing.Point(552, 265);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(15);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(270, 20);
            this.KeyLabel.TabIndex = 8;
            this.KeyLabel.Text = "Количество символов в строке: 32.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для прохождения теста нужно ввести исходные данные. \r\nДля получения 64 бит шифруе" +
    "мого текста используйте 8 первых букв из своих данных: Фамилии Имени Отчества";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(815, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шифруемое сообщение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(815, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Для получения ключа (256 бит) используют текст, состоящий из 32 букв, ключ придум" +
    "ать самостоятельно.";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyTextBox.Location = new System.Drawing.Point(11, 261);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(11);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(515, 26);
            this.KeyTextBox.TabIndex = 1;
            this.KeyTextBox.Text = "Саня уехал к себе домой в Туапсе";
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(11, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(815, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ключ шифрования:";
            // 
            // NextStepButton
            // 
            this.NextStepButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextStepButton.Location = new System.Drawing.Point(552, 315);
            this.NextStepButton.Margin = new System.Windows.Forms.Padding(15);
            this.NextStepButton.Name = "NextStepButton";
            this.NextStepButton.Size = new System.Drawing.Size(270, 63);
            this.NextStepButton.TabIndex = 2;
            this.NextStepButton.Text = "Следующий шаг >>";
            this.NextStepButton.UseVisualStyleBackColor = true;
            this.NextStepButton.Click += new System.EventHandler(this.NextStepButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MessageTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MessageLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 56);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTextBox.Location = new System.Drawing.Point(11, 11);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(11);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(243, 26);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = "ГОЛОЩАПО";
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Location = new System.Drawing.Point(280, 15);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(15);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(236, 26);
            this.MessageLabel.TabIndex = 7;
            this.MessageLabel.Text = "Количество символов в строке: 8.";
            // 
            // InsertValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(837, 385);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertValuesForm";
            this.Text = "Ввод сообщения и ключа шифрования";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NextStepButton;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}