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
            this.showNames = new System.Windows.Forms.Button();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.Button();
            this.sortNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNames
            // 
            this.showNames.Location = new System.Drawing.Point(12, 12);
            this.showNames.Name = "showNames";
            this.showNames.Size = new System.Drawing.Size(99, 32);
            this.showNames.TabIndex = 0;
            this.showNames.Text = "Show names";
            this.showNames.UseVisualStyleBackColor = true;
            this.showNames.Click += new System.EventHandler(this.ShowNames_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 15;
            this.listBoxNames.Location = new System.Drawing.Point(12, 79);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(252, 109);
            this.listBoxNames.TabIndex = 1;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(155, 18);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(109, 23);
            this.textBoxAddName.TabIndex = 2;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(270, 17);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(75, 23);
            this.addName.TabIndex = 3;
            this.addName.Text = "Add";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // sortNames
            // 
            this.sortNames.Location = new System.Drawing.Point(12, 50);
            this.sortNames.Name = "sortNames";
            this.sortNames.Size = new System.Drawing.Size(75, 23);
            this.sortNames.TabIndex = 4;
            this.sortNames.Text = "Sort";
            this.sortNames.UseVisualStyleBackColor = true;
            this.sortNames.Click += new System.EventHandler(this.SortNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortNames);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.showNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showNames;
        private ListBox listBoxNames;
        private TextBox textBoxAddName;
        private Button addName;
        private Button sortNames;
    }
}