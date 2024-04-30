namespace database_session
{
    partial class Timetable_Form
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
            this.data_view_timetable = new System.Windows.Forms.DataGridView();
            this.Change_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Log_Like_Admin_Button = new System.Windows.Forms.Button();
            this.Login_Text_Box = new System.Windows.Forms.TextBox();
            this.Password_Text_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connection_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_view_timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view_timetable
            // 
            this.data_view_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view_timetable.Location = new System.Drawing.Point(8, 7);
            this.data_view_timetable.Name = "data_view_timetable";
            this.data_view_timetable.RowHeadersWidth = 51;
            this.data_view_timetable.RowTemplate.Height = 24;
            this.data_view_timetable.Size = new System.Drawing.Size(774, 535);
            this.data_view_timetable.TabIndex = 0;
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(919, 362);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(136, 35);
            this.Change_Button.TabIndex = 1;
            this.Change_Button.Text = "изменить";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Log_Like_Admin_Button
            // 
            this.Log_Like_Admin_Button.Location = new System.Drawing.Point(869, 153);
            this.Log_Like_Admin_Button.Name = "Log_Like_Admin_Button";
            this.Log_Like_Admin_Button.Size = new System.Drawing.Size(136, 52);
            this.Log_Like_Admin_Button.TabIndex = 4;
            this.Log_Like_Admin_Button.Text = "Войти как администратор";
            this.Log_Like_Admin_Button.UseVisualStyleBackColor = true;
            this.Log_Like_Admin_Button.Click += new System.EventHandler(this.Log_Like_Admin_Button_Click);
            // 
            // Login_Text_Box
            // 
            this.Login_Text_Box.Location = new System.Drawing.Point(869, 30);
            this.Login_Text_Box.Name = "Login_Text_Box";
            this.Login_Text_Box.Size = new System.Drawing.Size(189, 22);
            this.Login_Text_Box.TabIndex = 5;
            // 
            // Password_Text_Box
            // 
            this.Password_Text_Box.Location = new System.Drawing.Point(869, 96);
            this.Password_Text_Box.Name = "Password_Text_Box";
            this.Password_Text_Box.Size = new System.Drawing.Size(189, 22);
            this.Password_Text_Box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Connection_Button
            // 
            this.Connection_Button.Location = new System.Drawing.Point(869, 233);
            this.Connection_Button.Name = "Connection_Button";
            this.Connection_Button.Size = new System.Drawing.Size(136, 52);
            this.Connection_Button.TabIndex = 9;
            this.Connection_Button.Text = "Переподключить";
            this.Connection_Button.UseVisualStyleBackColor = true;
            this.Connection_Button.Click += new System.EventHandler(this.Connection_Button_Click);
            // 
            // Timetable_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 582);
            this.Controls.Add(this.Connection_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_Text_Box);
            this.Controls.Add(this.Login_Text_Box);
            this.Controls.Add(this.Log_Like_Admin_Button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.data_view_timetable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timetable_Form";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Timetable_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view_timetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view_timetable;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Log_Like_Admin_Button;
        private System.Windows.Forms.TextBox Login_Text_Box;
        private System.Windows.Forms.TextBox Password_Text_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connection_Button;
    }
}