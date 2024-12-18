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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelect = new Button();
            cmbxMonth = new ComboBox();
            lbYourDay = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSelect
            // 
            resources.ApplyResources(btnSelect, "btnSelect");
            btnSelect.BackColor = Color.PaleGreen;
            btnSelect.ForeColor = Color.Indigo;
            btnSelect.Name = "btnSelect";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // cmbxMonth
            // 
            cmbxMonth.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(cmbxMonth, "cmbxMonth");
            cmbxMonth.FormatString = "N0";
            cmbxMonth.FormattingEnabled = true;
            cmbxMonth.Items.AddRange(new object[] { resources.GetString("cmbxMonth.Items"), resources.GetString("cmbxMonth.Items1"), resources.GetString("cmbxMonth.Items2"), resources.GetString("cmbxMonth.Items3") });
            cmbxMonth.Name = "cmbxMonth";
            cmbxMonth.Sorted = true;
            cmbxMonth.SelectedIndexChanged += cmbxMonth_SelectedIndexChanged;
            // 
            // lbYourDay
            // 
            lbYourDay.BackColor = Color.MintCream;
            lbYourDay.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(lbYourDay, "lbYourDay");
            lbYourDay.ForeColor = Color.Green;
            lbYourDay.Name = "lbYourDay";
            lbYourDay.Click += lbYourDay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Great;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Great;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbYourDay);
            Controls.Add(cmbxMonth);
            Controls.Add(btnSelect);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelect;
        private ComboBox cmbxMonth;
        private Label lbYourDay;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
