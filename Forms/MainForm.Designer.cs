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
            this._salaryText = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.NumericUpDown();
            this._daysText = new System.Windows.Forms.Label();
            this._formatWork = new System.Windows.Forms.ComboBox();
            this._formatWorkText = new System.Windows.Forms.Label();
            this._yearText = new System.Windows.Forms.Label();
            this._yearLabel = new System.Windows.Forms.Label();
            this._buttonResetYear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(3, 310);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(785, 57);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Calculate);
            // 
            // newWeekButton
            // 
            this.newWeekButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWeekButton.Location = new System.Drawing.Point(3, 374);
            this.newWeekButton.Name = "newWeekButton";
            this.newWeekButton.Size = new System.Drawing.Size(785, 57);
            this.newWeekButton.TabIndex = 1;
            this.newWeekButton.Text = "New calculating";
            this.newWeekButton.UseVisualStyleBackColor = true;
            this.newWeekButton.Click += new System.EventHandler(this.NewWeek);
            // 
            // _salaryText
            // 
            this._salaryText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._salaryText.AutoSize = true;
            this._salaryText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._salaryText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._salaryText.Location = new System.Drawing.Point(12, 107);
            this._salaryText.Name = "_salaryText";
            this._salaryText.Size = new System.Drawing.Size(89, 38);
            this._salaryText.TabIndex = 3;
            this._salaryText.Text = "1000 ";
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
            this.salary.ValueChanged += new System.EventHandler(this.SalaryWeekChanged);
            // 
            // _daysText
            // 
            this._daysText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._daysText.AutoSize = true;
            this._daysText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._daysText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._daysText.Location = new System.Drawing.Point(12, 50);
            this._daysText.Name = "_daysText";
            this._daysText.Size = new System.Drawing.Size(102, 38);
            this._daysText.TabIndex = 5;
            this._daysText.Text = "0 days";
            // 
            // _formatWork
            // 
            this._formatWork.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._formatWork.FormattingEnabled = true;
            this._formatWork.Items.AddRange(new object[] {
            "Hour",
            "Day"});
            this._formatWork.Location = new System.Drawing.Point(12, 218);
            this._formatWork.Name = "_formatWork";
            this._formatWork.Size = new System.Drawing.Size(121, 31);
            this._formatWork.TabIndex = 6;
            this._formatWork.SelectedIndexChanged += new System.EventHandler(this.FormatWorkChanged);
            // 
            // _formatWorkText
            // 
            this._formatWorkText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formatWorkText.AutoSize = true;
            this._formatWorkText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._formatWorkText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._formatWorkText.Location = new System.Drawing.Point(12, 182);
            this._formatWorkText.Name = "_formatWorkText";
            this._formatWorkText.Size = new System.Drawing.Size(126, 24);
            this._formatWorkText.TabIndex = 7;
            this._formatWorkText.Text = "Format work:";
            // 
            // _yearText
            // 
            this._yearText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._yearText.AutoSize = true;
            this._yearText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._yearText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._yearText.Location = new System.Drawing.Point(98, 273);
            this._yearText.Name = "_yearText";
            this._yearText.Size = new System.Drawing.Size(68, 28);
            this._yearText.TabIndex = 8;
            this._yearText.Text = "1000 ";
            // 
            // _yearLabel
            // 
            this._yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._yearLabel.AutoSize = true;
            this._yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._yearLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._yearLabel.Location = new System.Drawing.Point(12, 269);
            this._yearLabel.Name = "_yearLabel";
            this._yearLabel.Size = new System.Drawing.Size(71, 33);
            this._yearLabel.TabIndex = 9;
            this._yearLabel.Text = "Year";
            // 
            // _buttonResetYear
            // 
            this._buttonResetYear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonResetYear.Location = new System.Drawing.Point(3, 437);
            this._buttonResetYear.Name = "_buttonResetYear";
            this._buttonResetYear.Size = new System.Drawing.Size(785, 57);
            this._buttonResetYear.TabIndex = 10;
            this._buttonResetYear.Text = "Reset year";
            this._buttonResetYear.UseVisualStyleBackColor = true;
            this._buttonResetYear.Click += new System.EventHandler(this.ButtonResetYear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this._buttonResetYear);
            this.Controls.Add(this._yearLabel);
            this.Controls.Add(this._yearText);
            this.Controls.Add(this._formatWorkText);
            this.Controls.Add(this._formatWork);
            this.Controls.Add(this._daysText);
            this.Controls.Add(this.salary);
            this.Controls.Add(this._salaryText);
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
        private System.Windows.Forms.Label _salaryText;
        private System.Windows.Forms.NumericUpDown salary;
        private System.Windows.Forms.Label _daysText;
        private System.Windows.Forms.ComboBox _formatWork;
        private System.Windows.Forms.Label _formatWorkText;
        private System.Windows.Forms.Label _yearText;
        private System.Windows.Forms.Label _yearLabel;
        private System.Windows.Forms.Button _buttonResetYear;
    }
}

