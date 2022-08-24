namespace Telefoonboek
{
    partial class PersonsListForm
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
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.sortNamesBtn = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchNamesBtn = new System.Windows.Forms.Button();
            this.listViewNames = new System.Windows.Forms.ListView();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAge = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNamesBtn
            // 
            this.showNamesBtn.Location = new System.Drawing.Point(117, 406);
            this.showNamesBtn.Name = "showNamesBtn";
            this.showNamesBtn.Size = new System.Drawing.Size(99, 32);
            this.showNamesBtn.TabIndex = 0;
            this.showNamesBtn.Text = "Laad lijst";
            this.showNamesBtn.UseVisualStyleBackColor = true;
            this.showNamesBtn.Click += new System.EventHandler(this.ShowNamesBtn_Click);
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(12, 12);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(89, 33);
            this.addPersonBtn.TabIndex = 3;
            this.addPersonBtn.Text = "Voeg toe";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.AddPersonBtn_Click);
            // 
            // sortNamesBtn
            // 
            this.sortNamesBtn.Location = new System.Drawing.Point(12, 77);
            this.sortNamesBtn.Name = "sortNamesBtn";
            this.sortNamesBtn.Size = new System.Drawing.Size(89, 33);
            this.sortNamesBtn.TabIndex = 4;
            this.sortNamesBtn.Text = "Sorteer";
            this.sortNamesBtn.UseVisualStyleBackColor = true;
            this.sortNamesBtn.Click += new System.EventHandler(this.SortNamesBtn_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(270, 77);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Zoeken...";
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
            this.searchNamesBtn.Text = "Zoek";
            this.searchNamesBtn.UseVisualStyleBackColor = true;
            this.searchNamesBtn.Click += new System.EventHandler(this.SearchNamesBtn_Click);
            // 
            // listViewNames
            // 
            this.listViewNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderAge,
            this.columnHeaderPhoneNumber,
            this.columnHeaderEmail});
            this.listViewNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewNames.Location = new System.Drawing.Point(12, 116);
            this.listViewNames.Name = "listViewNames";
            this.listViewNames.Size = new System.Drawing.Size(776, 279);
            this.listViewNames.TabIndex = 7;
            this.listViewNames.UseCompatibleStateImageBehavior = false;
            this.listViewNames.View = System.Windows.Forms.View.Details;
            this.listViewNames.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.ListViewNames_ItemMouseHover);
            this.listViewNames.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewNames_ItemSelectionChanged);
            this.listViewNames.MouseLeave += new System.EventHandler(this.ListViewNames_MouseLeave);
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "Voornaam";
            this.columnHeaderFirstName.Width = 154;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Achternaam";
            this.columnHeaderLastName.Width = 154;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Leeftijd";
            this.columnHeaderAge.Width = 154;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Telefoonnummer";
            this.columnHeaderPhoneNumber.Width = 154;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 154;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(12, 406);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(99, 32);
            this.buttonSaveAll.TabIndex = 8;
            this.buttonSaveAll.Text = "Bewaar alles";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // PersonsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.listViewNames);
            this.Controls.Add(this.searchNamesBtn);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.sortNamesBtn);
            this.Controls.Add(this.addPersonBtn);
            this.Controls.Add(this.showNamesBtn);
            this.Name = "PersonsListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PersonsListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showNamesBtn;
        private Button addPersonBtn;
        private Button sortNamesBtn;
        private TextBox textBoxSearch;
        private Button searchNamesBtn;
        private ListView listViewNames;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderLastName;
        private ColumnHeader columnHeaderAge;
        private ColumnHeader columnHeaderPhoneNumber;
        private ColumnHeader columnHeaderEmail;
        private Button buttonSaveAll;
    }
}