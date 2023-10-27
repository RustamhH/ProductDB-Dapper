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
            ProductsList = new ListBox();
            AddButton = new Button();
            EditButton = new Button();
            ClearButton = new Button();
            RemoveButton = new Button();
            SuspendLayout();
            // 
            // ProductsList
            // 
            ProductsList.FormattingEnabled = true;
            ProductsList.ItemHeight = 15;
            ProductsList.Location = new Point(1, 0);
            ProductsList.Margin = new Padding(3, 2, 3, 2);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(420, 289);
            ProductsList.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(10, 315);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(401, 22);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add Product";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(10, 350);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(401, 22);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit Product";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(10, 422);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(401, 22);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear List";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(10, 385);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(401, 22);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove Product";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 490);
            Controls.Add(RemoveButton);
            Controls.Add(ClearButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(ProductsList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Catalog";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ProductsList;
        private Button AddButton;
        private Button EditButton;
        private Button ClearButton;
        private Button RemoveButton;
    }
}