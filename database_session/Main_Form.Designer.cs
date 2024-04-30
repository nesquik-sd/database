namespace database_session
{
    partial class Mainn_Form
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
            this.Results_Button = new System.Windows.Forms.Button();
            this.Timetable_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results_Button
            // 
            this.Results_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Results_Button.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results_Button.Location = new System.Drawing.Point(354, 206);
            this.Results_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Results_Button.Name = "Results_Button";
            this.Results_Button.Size = new System.Drawing.Size(202, 74);
            this.Results_Button.TabIndex = 0;
            this.Results_Button.Text = "Результаты";
            this.Results_Button.UseVisualStyleBackColor = false;
            this.Results_Button.Click += new System.EventHandler(this.Results_Button_Click);
            // 
            // Timetable_Button
            // 
            this.Timetable_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Timetable_Button.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timetable_Button.Location = new System.Drawing.Point(354, 332);
            this.Timetable_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Timetable_Button.Name = "Timetable_Button";
            this.Timetable_Button.Size = new System.Drawing.Size(202, 76);
            this.Timetable_Button.TabIndex = 1;
            this.Timetable_Button.Text = "Расписание";
            this.Timetable_Button.UseVisualStyleBackColor = false;
            this.Timetable_Button.Click += new System.EventHandler(this.Timetable_Button_Click);
            // 
            // Mainn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(971, 607);
            this.Controls.Add(this.Timetable_Button);
            this.Controls.Add(this.Results_Button);
            this.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Mainn_Form";
            this.ShowInTaskbar = false;
            this.Text = "Сессия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Results_Button;
        private System.Windows.Forms.Button Timetable_Button;
    }
}

