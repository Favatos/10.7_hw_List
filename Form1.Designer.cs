namespace _10._7_hw_List
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
            comboBoxCountry = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxStreet = new ComboBox();
            comboBoxHouse = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(277, 127);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(201, 28);
            comboBoxCountry.TabIndex = 0;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.Enabled = false;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(277, 185);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(201, 28);
            comboBoxCity.TabIndex = 0;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxStreet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStreet.Enabled = false;
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(277, 239);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(201, 28);
            comboBoxStreet.TabIndex = 0;
            comboBoxStreet.SelectedIndexChanged += comboBoxStreet_SelectedIndexChanged;
            // 
            // comboBoxHouse
            // 
            comboBoxHouse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxHouse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHouse.Enabled = false;
            comboBoxHouse.FormattingEnabled = true;
            comboBoxHouse.Location = new Point(277, 295);
            comboBoxHouse.Name = "comboBoxHouse";
            comboBoxHouse.Size = new Size(201, 28);
            comboBoxHouse.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(218, 129);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Страна";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(218, 188);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Город";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(218, 242);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Улица";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(218, 298);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 1;
            label4.Text = "Дом";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(335, 373);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxHouse);
            Controls.Add(comboBoxStreet);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxCountry);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCountry;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxStreet;
        private ComboBox comboBoxHouse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
