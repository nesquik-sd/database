namespace database_session
{
    partial class Courses_Form
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
            this.First_Coutse_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First_Coutse_Button
            // 
            this.First_Coutse_Button.Location = new System.Drawing.Point(303, 91);
            this.First_Coutse_Button.Name = "First_Coutse_Button";
            this.First_Coutse_Button.Size = new System.Drawing.Size(224, 55);
            this.First_Coutse_Button.TabIndex = 0;
            this.First_Coutse_Button.Text = "Первый курс";
            this.First_Coutse_Button.UseVisualStyleBackColor = true;
            this.First_Coutse_Button.Click += new System.EventHandler(this.First_Coutse_Button_Click);
            // 
            // Courses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 509);
            this.Controls.Add(this.First_Coutse_Button);
            this.Name = "Courses_Form";
            this.Text = "Courses_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button First_Coutse_Button;
    }
}