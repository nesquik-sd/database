namespace database_session
{
    partial class Autorization_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Text_Box = new System.Windows.Forms.MaskedTextBox();
            this.Password_Text_Box = new System.Windows.Forms.MaskedTextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // Login_Text_Box
            // 
            this.Login_Text_Box.Location = new System.Drawing.Point(221, 55);
            this.Login_Text_Box.Name = "Login_Text_Box";
            this.Login_Text_Box.Size = new System.Drawing.Size(252, 22);
            this.Login_Text_Box.TabIndex = 2;
            this.Login_Text_Box.TextChanged += new System.EventHandler(this.Login_Text_Box_TextChanged);
            // 
            // Password_Text_Box
            // 
            this.Password_Text_Box.Location = new System.Drawing.Point(221, 105);
            this.Password_Text_Box.Name = "Password_Text_Box";
            this.Password_Text_Box.Size = new System.Drawing.Size(252, 22);
            this.Password_Text_Box.TabIndex = 3;
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Button.Location = new System.Drawing.Point(287, 157);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(102, 51);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Войти";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Autorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 232);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Text_Box);
            this.Controls.Add(this.Login_Text_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autorization_Form";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Login_Text_Box;
        private System.Windows.Forms.MaskedTextBox Password_Text_Box;
        private System.Windows.Forms.Button Login_Button;
    }
}