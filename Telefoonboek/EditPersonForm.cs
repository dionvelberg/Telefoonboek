using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefoonboek
{
    public partial class EditPersonForm : Form
    {
        private PersonsListForm personsListForm;
        private Person currentPerson;
        public EditPersonForm(PersonsListForm formNamesList, Person currentPersonData)
        {
            InitializeComponent();
            this.personsListForm = formNamesList;
            this.currentPerson = currentPersonData;
 
        }

        private void EditPersonForm_Load(object sender, EventArgs e)
        {
            // Set textbox values of the current person
            textBoxFirstName.Text = currentPerson.FirstName;
            textBoxLastName.Text = currentPerson.LastName;
            textBoxAge.Text = currentPerson.Age;
            textBoxPhoneNumber.Text = currentPerson.PhoneNumber;
            textBoxEmail.Text = currentPerson.Email;

            textBoxZipcode.Text = currentPerson.Address?.zip_code;
            textBoxNumber.Text = currentPerson.Address?.house_number;
            textBoxStreet.Text = currentPerson.Address?.street;
            textBoxCity.Text = currentPerson.Address?.city;
            textBoxLongitude.Text = currentPerson.Address?.longitude;
            textBoxLatitude.Text = currentPerson.Address?.latitude;
            textBoxProvince.Text = currentPerson.Address?.province;
        }

        private void EditPersonForm_FormClosing(Object sender, FormClosingEventArgs e)// onClosing event
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)// Assume that X has been clicked
            {
                e.Cancel = true;
            }
        }

        private void buttonSavePerson_Click(object sender, EventArgs e)// Save button click event
        {
            Person personUpdated = new Person(); // Create updated person
            PersonAddress UpdatedPersonAddress = new PersonAddress();
            personUpdated.FirstName = textBoxFirstName.Text;
            personUpdated.LastName = textBoxLastName.Text;
            personUpdated.Age = textBoxAge.Text;
            personUpdated.PhoneNumber = textBoxPhoneNumber.Text;
            personUpdated.Email = textBoxEmail.Text;

            UpdatedPersonAddress.zip_code = textBoxZipcode.Text;
            UpdatedPersonAddress.house_number = textBoxNumber.Text;
            UpdatedPersonAddress.street = textBoxStreet.Text;
            UpdatedPersonAddress.city = textBoxCity.Text;
            UpdatedPersonAddress.longitude = textBoxLongitude.Text;
            UpdatedPersonAddress.latitude = textBoxLatitude.Text;
            UpdatedPersonAddress.province = textBoxProvince.Text;
            personUpdated.Address = UpdatedPersonAddress;

            currentPerson = personsListForm.UpdatePerson(currentPerson, personUpdated);// Set new values to current person
            this.Update();
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)// Delete button click event
        {
            personsListForm.DeletePerson(currentPerson);// Delete current person
            this.Dispose();
        }

        private async void TextBoxGetAddres_TextChanged(object sender, EventArgs e)// textBoxPostcode or textBoxNumber  onChange event
        {
            if (!String.IsNullOrWhiteSpace(textBoxZipcode.Text) && !String.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                string number = textBoxNumber.Text;// Get house number
                string zipcode = textBoxZipcode.Text;// Get zipcode
                PersonAddress result = await personsListForm.getPersonAddressClient.GetPersonAddress(zipcode, number);//Get Request person address

                //Set Address values
                textBoxStreet.Text = result?.street ?? "";
                textBoxCity.Text = result?.city ?? "";
                textBoxProvince.Text = result?.province ?? "";
                textBoxLongitude.Text = result?.longitude ?? "";
                textBoxLatitude.Text = result?.latitude ?? "";
            }

        }

    }
}
