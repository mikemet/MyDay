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
            btnSelect = new Button();
            cmbxMonth = new ComboBox();
            lbYourDay = new Label();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(33, 109);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(100, 41);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select Day";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // cmbxMonth
            // 
            cmbxMonth.FormatString = "N0";
            cmbxMonth.FormattingEnabled = true;
            cmbxMonth.Items.AddRange(new object[] { "28", "29", "30", "31" });
            cmbxMonth.Location = new Point(33, 38);
            cmbxMonth.Name = "cmbxMonth";
            cmbxMonth.Size = new Size(175, 29);
            cmbxMonth.Sorted = true;
            cmbxMonth.TabIndex = 4;
            cmbxMonth.Text = "Enter number of days";
            cmbxMonth.SelectedIndexChanged += cmbxMonth_SelectedIndexChanged;
            // 
            // lbYourDay
            // 
            lbYourDay.AutoSize = true;
            lbYourDay.BackColor = Color.Teal;
            lbYourDay.BorderStyle = BorderStyle.FixedSingle;
            lbYourDay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbYourDay.Location = new Point(33, 189);
            lbYourDay.Name = "lbYourDay";
            lbYourDay.Size = new Size(2, 47);
            lbYourDay.TabIndex = 5;
            lbYourDay.Click += lbYourDay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(lbYourDay);
            Controls.Add(cmbxMonth);
            Controls.Add(btnSelect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelect;
        private ComboBox cmbxMonth;
        private Label lbYourDay;
    }
}
