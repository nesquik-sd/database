namespace database_session
{
    partial class Result_Form
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
            this.Numb_Cours_TextBox = new System.Windows.Forms.TextBox();
            this.data_view_results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_view_results)).BeginInit();
            this.SuspendLayout();
            // 
            // Numb_Cours_TextBox
            // 
            this.Numb_Cours_TextBox.Location = new System.Drawing.Point(22, 27);
            this.Numb_Cours_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Numb_Cours_TextBox.Name = "Numb_Cours_TextBox";
            this.Numb_Cours_TextBox.Size = new System.Drawing.Size(167, 22);
            this.Numb_Cours_TextBox.TabIndex = 0;
            // 
            // data_view_results
            // 
            this.data_view_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view_results.Location = new System.Drawing.Point(0, 0);
            this.data_view_results.Name = "data_view_results";
            this.data_view_results.RowHeadersWidth = 51;
            this.data_view_results.RowTemplate.Height = 24;
            this.data_view_results.Size = new System.Drawing.Size(1071, 552);
            this.data_view_results.TabIndex = 1;
            // 
            // Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.data_view_results);
            this.Controls.Add(this.Numb_Cours_TextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Result_Form";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.Result_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numb_Cours_TextBox;
        private System.Windows.Forms.DataGridView data_view_results;
    }
}