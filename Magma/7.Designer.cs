namespace Magma
{
    partial class XORForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XORForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.NextStepButton = new System.Windows.Forms.Button();
            this.DemonstrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L0TextBox = new System.Windows.Forms.TextBox();
            this.N0ShiftedTextBox = new System.Windows.Forms.TextBox();
            this.XORResultTextBox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainTableLayoutPanel.RowCount = 5;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1306, 666);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.MainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.NextStepButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DemonstrationButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 559);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1280, 94);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // NextStepButton
            // 
            this.NextStepButton.AutoSize = true;
            this.NextStepButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextStepButton.Location = new System.Drawing.Point(655, 15);
            this.NextStepButton.Margin = new System.Windows.Forms.Padding(15);
            this.NextStepButton.Name = "NextStepButton";
            this.NextStepButton.Size = new System.Drawing.Size(610, 70);
            this.NextStepButton.TabIndex = 29;
            this.NextStepButton.Text = "Следующий шаг >>";
            this.NextStepButton.UseVisualStyleBackColor = true;
            this.NextStepButton.Click += new System.EventHandler(this.NextStepButton_Click);
            // 
            // DemonstrationButton
            // 
            this.DemonstrationButton.AutoSize = true;
            this.DemonstrationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DemonstrationButton.Location = new System.Drawing.Point(15, 15);
            this.DemonstrationButton.Margin = new System.Windows.Forms.Padding(15);
            this.DemonstrationButton.Name = "DemonstrationButton";
            this.DemonstrationButton.Size = new System.Drawing.Size(610, 70);
            this.DemonstrationButton.TabIndex = 28;
            this.DemonstrationButton.Text = ">> Демонстрация <<";
            this.DemonstrationButton.UseVisualStyleBackColor = true;
            this.DemonstrationButton.Click += new System.EventHandler(this.DemonstrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1274, 160);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.MainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 942F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.L0TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.N0ShiftedTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.XORResultTextBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 440);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 96);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "N0 << 11 =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "L0 =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "N0 << 11 XOR L0 =";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L0TextBox
            // 
            this.L0TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L0TextBox.Location = new System.Drawing.Point(133, 3);
            this.L0TextBox.Name = "L0TextBox";
            this.L0TextBox.ReadOnly = true;
            this.L0TextBox.Size = new System.Drawing.Size(234, 26);
            this.L0TextBox.TabIndex = 3;
            // 
            // N0ShiftedTextBox
            // 
            this.N0ShiftedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N0ShiftedTextBox.Location = new System.Drawing.Point(133, 35);
            this.N0ShiftedTextBox.Name = "N0ShiftedTextBox";
            this.N0ShiftedTextBox.ReadOnly = true;
            this.N0ShiftedTextBox.Size = new System.Drawing.Size(234, 26);
            this.N0ShiftedTextBox.TabIndex = 4;
            // 
            // XORResultTextBox
            // 
            this.XORResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XORResultTextBox.Location = new System.Drawing.Point(133, 67);
            this.XORResultTextBox.Name = "XORResultTextBox";
            this.XORResultTextBox.Size = new System.Drawing.Size(234, 26);
            this.XORResultTextBox.TabIndex = 5;
            this.XORResultTextBox.TextChanged += new System.EventHandler(this.XORResultTextBox_TextChanged);
            // 
            // XORForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 666);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1322, 705);
            this.MinimumSize = new System.Drawing.Size(1322, 705);
            this.Name = "XORForm";
            this.Text = "XOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L0TextBox;
        private System.Windows.Forms.TextBox N0ShiftedTextBox;
        private System.Windows.Forms.TextBox XORResultTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button NextStepButton;
        private System.Windows.Forms.Button DemonstrationButton;
    }
}