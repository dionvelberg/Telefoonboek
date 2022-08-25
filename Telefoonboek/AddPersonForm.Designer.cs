namespace Telefoonboek
{
    partial class AddPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonForm));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxZipcode = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            resources.ApplyResources(this.textBoxFirstName, "textBoxFirstName");
            this.textBoxFirstName.Name = "textBoxFirstName";
            // 
            // textBoxLastName
            // 
            resources.ApplyResources(this.textBoxLastName, "textBoxLastName");
            this.textBoxLastName.Name = "textBoxLastName";
            // 
            // textBoxAge
            // 
            resources.ApplyResources(this.textBoxAge, "textBoxAge");
            this.textBoxAge.Name = "textBoxAge";
            // 
            // textBoxPhoneNumber
            // 
            resources.ApplyResources(this.textBoxPhoneNumber, "textBoxPhoneNumber");
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.Name = "textBoxEmail";
            // 
            // labelFirstName
            // 
            resources.ApplyResources(this.labelFirstName, "labelFirstName");
            this.labelFirstName.Name = "labelFirstName";
            // 
            // labelLastName
            // 
            resources.ApplyResources(this.labelLastName, "labelLastName");
            this.labelLastName.Name = "labelLastName";
            // 
            // labelAge
            // 
            resources.ApplyResources(this.labelAge, "labelAge");
            this.labelAge.Name = "labelAge";
            // 
            // labelPhoneNumber
            // 
            resources.ApplyResources(this.labelPhoneNumber, "labelPhoneNumber");
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.Name = "labelEmail";
            // 
            // buttonAddPerson
            // 
            resources.ApplyResources(this.buttonAddPerson, "buttonAddPerson");
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // textBoxProvince
            // 
            resources.ApplyResources(this.textBoxProvince, "textBoxProvince");
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.ReadOnly = true;
            // 
            // textBoxCity
            // 
            resources.ApplyResources(this.textBoxCity, "textBoxCity");
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            // 
            // textBoxStreet
            // 
            resources.ApplyResources(this.textBoxStreet, "textBoxStreet");
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.ReadOnly = true;
            // 
            // textBoxZipcode
            // 
            resources.ApplyResources(this.textBoxZipcode, "textBoxZipcode");
            this.textBoxZipcode.Name = "textBoxZipcode";
            this.textBoxZipcode.TextChanged += new System.EventHandler(this.TextBoxGetAddres_TextChanged);
            // 
            // textBoxNumber
            // 
            resources.ApplyResources(this.textBoxNumber, "textBoxNumber");
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.TextChanged += new System.EventHandler(this.TextBoxGetAddres_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxLongitude
            // 
            resources.ApplyResources(this.textBoxLongitude, "textBoxLongitude");
            this.textBoxLongitude.Name = "textBoxLongitude";
            // 
            // textBoxLatitude
            // 
            resources.ApplyResources(this.textBoxLatitude, "textBoxLatitude");
            this.textBoxLatitude.Name = "textBoxLatitude";
            // 
            // AddPersonForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxZipcode);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "AddPersonForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPersonForm_FormClosing);
            this.Load += new System.EventHandler(this.AddPersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAge;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelAge;
        private Label labelPhoneNumber;
        private Label labelEmail;
        private Button buttonAddPerson;
        private Button button1;
        private TextBox textBoxProvince;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxZipcode;
        private TextBox textBoxNumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxLongitude;
        private TextBox textBoxLatitude;
    }
}