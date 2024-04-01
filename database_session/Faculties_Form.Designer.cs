namespace database_session
{
    partial class Faculties_Form
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
            this.First_Faculty_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First_Faculty_Button
            // 
            this.First_Faculty_Button.Location = new System.Drawing.Point(251, 107);
            this.First_Faculty_Button.Name = "First_Faculty_Button";
            this.First_Faculty_Button.Size = new System.Drawing.Size(238, 61);
            this.First_Faculty_Button.TabIndex = 0;
            this.First_Faculty_Button.Text = "Первый факультет";
            this.First_Faculty_Button.UseVisualStyleBackColor = true;
            this.First_Faculty_Button.Click += new System.EventHandler(this.First_Faculty_Button_Click);
            // 
            // Faculties_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.First_Faculty_Button);
            this.Name = "Faculties_Form";
            this.Text = "Faculties_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button First_Faculty_Button;
    }
}