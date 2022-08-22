namespace Telefoonboek
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
            this.showNamesBtn = new System.Windows.Forms.Button();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.addNameBtn = new System.Windows.Forms.Button();
            this.sortNamesBtn = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchNamesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNamesBtn
            // 
            this.showNamesBtn.Location = new System.Drawing.Point(107, 77);
            this.showNamesBtn.Name = "showNamesBtn";
            this.showNamesBtn.Size = new System.Drawing.Size(99, 32);
            this.showNamesBtn.TabIndex = 0;
            this.showNamesBtn.Text = "Show names";
            this.showNamesBtn.UseVisualStyleBackColor = true;
            this.showNamesBtn.Click += new System.EventHandler(this.ShowNamesBtn_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 25;
            this.listBoxNames.Location = new System.Drawing.Point(12, 116);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(776, 279);
            this.listBoxNames.TabIndex = 1;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddName.Location = new System.Drawing.Point(12, 24);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(252, 33);
            this.textBoxAddName.TabIndex = 2;
            // 
            // addNameBtn
            // 
            this.addNameBtn.Location = new System.Drawing.Point(270, 24);
            this.addNameBtn.Name = "addNameBtn";
            this.addNameBtn.Size = new System.Drawing.Size(89, 33);
            this.addNameBtn.TabIndex = 3;
            this.addNameBtn.Text = "Add";
            this.addNameBtn.UseVisualStyleBackColor = true;
            this.addNameBtn.Click += new System.EventHandler(this.AddNameBtn_Click);
            // 
            // sortNamesBtn
            // 
            this.sortNamesBtn.Location = new System.Drawing.Point(12, 77);
            this.sortNamesBtn.Name = "sortNamesBtn";
            this.sortNamesBtn.Size = new System.Drawing.Size(89, 33);
            this.sortNamesBtn.TabIndex = 4;
            this.sortNamesBtn.Text = "Sort";
            this.sortNamesBtn.UseVisualStyleBackColor = true;
            this.sortNamesBtn.Click += new System.EventHandler(this.SortNamesBtn_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(270, 77);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Search...";
            this.textBoxSearch.Size = new System.Drawing.Size(423, 33);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // searchNamesBtn
            // 
            this.searchNamesBtn.Location = new System.Drawing.Point(699, 77);
            this.searchNamesBtn.Name = "searchNamesBtn";
            this.searchNamesBtn.Size = new System.Drawing.Size(89, 33);
            this.searchNamesBtn.TabIndex = 6;
            this.searchNamesBtn.Text = "Search";
            this.searchNamesBtn.UseVisualStyleBackColor = true;
            this.searchNamesBtn.Click += new System.EventHandler(this.SearchNamesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchNamesBtn);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.sortNamesBtn);
            this.Controls.Add(this.addNameBtn);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.showNamesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showNamesBtn;
        private ListBox listBoxNames;
        private TextBox textBoxAddName;
        private Button addNameBtn;
        private Button sortNamesBtn;
        private TextBox textBoxSearch;
        private Button searchNamesBtn;
    }
}