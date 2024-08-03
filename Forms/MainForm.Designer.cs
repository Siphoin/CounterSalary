namespace CounterSalary
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.newWeekButton = new System.Windows.Forms.Button();
            this.salaryText = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.NumericUpDown();
            this.daysText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(3, 285);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(785, 57);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Calculate);
            // 
            // newWeekButton
            // 
            this.newWeekButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newWeekButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWeekButton.Location = new System.Drawing.Point(3, 349);
            this.newWeekButton.Name = "newWeekButton";
            this.newWeekButton.Size = new System.Drawing.Size(785, 57);
            this.newWeekButton.TabIndex = 1;
            this.newWeekButton.Text = "Новая неделя";
            this.newWeekButton.UseVisualStyleBackColor = true;
            this.newWeekButton.Click += new System.EventHandler(this.NewWeek);
            // 
            // salaryText
            // 
            this.salaryText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryText.AutoSize = true;
            this.salaryText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salaryText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryText.Location = new System.Drawing.Point(12, 107);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(89, 38);
            this.salaryText.TabIndex = 3;
            this.salaryText.Text = "1000 ";
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary.Location = new System.Drawing.Point(12, 12);
            this.salary.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(775, 26);
            this.salary.TabIndex = 4;
            this.salary.ValueChanged += new System.EventHandler(this.salary_ValueChanged);
            // 
            // daysText
            // 
            this.daysText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daysText.AutoSize = true;
            this.daysText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daysText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysText.Location = new System.Drawing.Point(12, 50);
            this.daysText.Name = "daysText";
            this.daysText.Size = new System.Drawing.Size(102, 38);
            this.daysText.TabIndex = 5;
            this.daysText.Text = "0 days";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.daysText);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.newWeekButton);
            this.Controls.Add(this.calculateButton);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Counter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button newWeekButton;
        private System.Windows.Forms.Label salaryText;
        private System.Windows.Forms.NumericUpDown salary;
        private System.Windows.Forms.Label daysText;
    }
}

