namespace ProductDB_Dapper
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
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.ItemHeight = 20;
            this.ProductsList.Location = new System.Drawing.Point(1, 0);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(479, 384);
            this.ProductsList.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 420);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(458, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Product";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 466);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(458, 29);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit Product";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 562);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(458, 29);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear List";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 513);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(458, 29);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove Product";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProductsList);
            this.Name = "Form1";
            this.Text = "Catalog";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ProductsList;
        private Button AddButton;
        private Button EditButton;
        private Button ClearButton;
        private Button RemoveButton;
    }
}