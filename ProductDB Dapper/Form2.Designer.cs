namespace ProductDB_Dapper
{
    partial class Form2
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
            OKButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CostTextBox = new TextBox();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.Location = new Point(11, 200);
            OKButton.Margin = new Padding(3, 2, 3, 2);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(82, 22);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(158, 200);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "Origin Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 127);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Product Cost";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(11, 31);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(230, 23);
            NameTextBox.TabIndex = 5;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(11, 90);
            CountryTextBox.Margin = new Padding(3, 2, 3, 2);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(230, 23);
            CountryTextBox.TabIndex = 6;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(11, 154);
            CostTextBox.Margin = new Padding(3, 2, 3, 2);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(230, 23);
            CostTextBox.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 293);
            Controls.Add(CostTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKButton;
        private Button CancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox CountryTextBox;
        private TextBox CostTextBox;
    }
}