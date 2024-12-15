namespace csMyDayForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxInput = new TextBox();
            btnSelect = new Button();
            tbxDay = new TextBox();
            SuspendLayout();
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(323, 116);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(100, 29);
            tbxInput.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(323, 186);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(100, 41);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select Day";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // tbxDay
            // 
            tbxDay.Location = new Point(323, 248);
            tbxDay.Name = "tbxDay";
            tbxDay.Size = new Size(100, 29);
            tbxDay.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxDay);
            Controls.Add(btnSelect);
            Controls.Add(tbxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxInput;
        private Button btnSelect;
        private TextBox tbxDay;
    }
}
