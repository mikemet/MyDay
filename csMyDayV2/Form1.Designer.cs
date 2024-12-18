namespace csMyDayV2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Январь", "Февраль", "Февраль*29", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Ноябрь", "Декабрь" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 29);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Выберите месяц";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 81);
            button1.Name = "button1";
            button1.Size = new Size(280, 43);
            button1.TabIndex = 1;
            button1.Text = "Ваш ДЕНЬ!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("MV Boli", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(158, 154);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 346);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
    }
}
